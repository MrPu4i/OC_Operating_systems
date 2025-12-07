using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FileSystem
{
    public partial class Form1 : Form
    {
        // private MyFileSystem fileSystem = new MyFileSystem(); //Создали класс управляющий всем
        int i = 0;
        public bool isSorted = false;
        public Form1()
        {
            InitializeComponent();
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(16, 16); // Размер иконок
            imageList.ColorDepth = ColorDepth.Depth32Bit;

            // Добавляем иконки (замени на свои или системные)
            imageList.Images.Add(Image.FromFile("images\\file_icon.png")); // Иконка файла
            imageList.Images.Add(Image.FromFile("images\\folder_icon.png"));   // Иконка папки

            // Привязываем ImageList к ListView
            listView.SmallImageList = imageList;
            UpdateVisual();

            SetDataGridView();
        }

        private MyFileSystem FileSystem
        {
            get
            {
                return MyFileSystem.Instance;
            }
        }
        private void SetDataGridView()
        {
            for (int i = 0; i < FileSystem.FATfs.numClusters; i++)
            {
                FATgrid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Width = 20,
                    HeaderText = i.ToString(), // Заголовок = номер колонки
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Alignment = DataGridViewContentAlignment.MiddleCenter,
                        Font = new Font("Arial", 8, FontStyle.Bold)
                    }
                });
            }
            FATgrid.ColumnHeadersDefaultCellStyle.Font =
    new Font("Microsoft Sans Serif", 7, FontStyle.Regular);
            FATgrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            //FATgrid.Rows.Add(); //1 строка
            FATgrid.Rows.Add(); //1 строка

            // Настраиваем внешний вид ячеек
            foreach (DataGridViewRow row in FATgrid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White; // Пустые ячейки серые
                    cell.Value = ""; // Пустое значение
                }
            }
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            FileSystem.CreateFile("File_name" + i, FileSystem.CurFolder, ".txt");
            i++;
            UpdateFAT();
            UpdateVisual();
        }
        public void UpdateFAT() //Обновление таблицы FAT
        {
            //Если ячейка пуста - серое
            //Если занята - голубое/оранж
            //Если последнее значение - красный
            for (int i = 0; i < FileSystem.FATfs.FAT.Count; i++)
            {
                int a = FileSystem.FATfs.FAT[i];
                DataGridViewCell cell = FATgrid.Rows[0].Cells[i];
                //В любом случае пишем значение в ячейку
                cell.Value = a;
                if (a == -1)
                {
                    cell.Style.BackColor = Color.Red;
                }
                if (a > 0)
                {
                    cell.Style.BackColor = Color.LightBlue;
                }
                if (a == FileSystem.FATfs.empty) // < 0 (пусто)
                {
                    cell.Style.BackColor = Color.White;
                    cell.Value = null;
                }
            }
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            FileSystem.CreateFolder("Folder_name" + i, FileSystem.CurFolder);
            i++;
            UpdateVisual();
        }


        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView.SelectedItems.Count > 0) //Есть один
            {
                ListViewItem selectedItem = listView.SelectedItems[0];

                // Проверяем на FileObject (базовый класс)
                if (selectedItem.Tag is Folder folder)
                {
                    FileSystem.CurFolder = folder;
                    Console.WriteLine("Вошли в новую папку");
                }
                else
                {
                    Console.WriteLine("Tag не содержит FileObject");
                }

                UpdateVisual();
            }
        }
        private void UpdateVisual()
        {
            UpdateFullPath();

            listView.Items.Clear();

            List<FileObject> files;

            if (isSorted) //НЕ сортеруем
            {
                files = FileSystem.CurFolder.Files.OrderBy(f => f.Name).ToList();
            }
            else
            {
                files = FileSystem.CurFolder.Files;
            }

            //Показываем текущую папку
            foreach (var item in files)
            {

                ListViewItem listItem = new ListViewItem();
                //✉ ◆ ◇ ☔ 😒 ▲ ◯
                if (item is File file)
                {
                    //Это файл
                    listItem.Text = file.Name + file.Type; //Первый столбец с именем
                    listItem.SubItems.Add(DateTime.Now.ToString()); //Дата создания
                    listItem.SubItems.Add($"{file.GetSize()} bytes"); //Размер
                    listItem.SubItems.Add(file.GetType().ToString()); //Тип файла
                    listItem.Tag = file;
                    listItem.ImageIndex = 0;
                }
                else
                {
                    //Это папка
                    listItem.Text = item.Name;
                    listItem.Tag = item;
                    listItem.ImageIndex = 1;
                }
                listView.Items.Add(listItem);
            }
        }
        private void UpdateFullPath()
        {
            lbl_fullPath.Text = FileSystem.CurFolder.FullPath; //Путь текущей папки
        }

        private void Return_Click(object sender, EventArgs e)
        {
            //Вернуться
            if (FileSystem.CurFolder.Parent != null)
            {
                FileSystem.CurFolder = FileSystem.CurFolder.Parent;
                UpdateVisual();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selectedItem in listView.SelectedItems)
                {
                    if (selectedItem.Tag is FileObject fileToDelete)
                    {
                        FileSystem.DeleteFileObject(fileToDelete);
                        listView.Items.Remove(selectedItem);
                    }
                }
                UpdateFAT();
                UpdateVisual();
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView.SelectedItems[0];

                // Создаем диалог с текущим именем
                using (var renameDialog = new RenameDialog(((FileObject)selectedItem.Tag).Name))
                {
                    // Показываем диалог и проверяем результат
                    if (renameDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Получаем объект из Tag
                        if (selectedItem.Tag is FileObject fileObject)
                        {
                            // Пытаемся переименовать
                            FileSystem.Rename(fileObject, renameDialog.NewName);
                            UpdateVisual();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите элемент для переименования");
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            isSorted = true;
            btnSort.Enabled = false;
            btnSort.BackColor = SystemColors.AppWorkspace;
            btnUnSort.Enabled = true;
            btnUnSort.BackColor = SystemColors.Control;
            UpdateVisual();
        }

        private void btnUnSort_Click(object sender, EventArgs e)
        {
            isSorted = false;
            btnUnSort.Enabled = false;
            btnUnSort.BackColor = SystemColors.AppWorkspace;
            btnSort.Enabled = true;
            btnSort.BackColor = SystemColors.Control;
            UpdateVisual();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                var filesToCopy = new List<FileObject>(); //Список всех объектов, которые у нас выделены
                foreach (ListViewItem selectedItem in listView.SelectedItems) //Все выделенные объекты копируем
                {
                    if (selectedItem.Tag is FileObject fileObject)
                    {
                        filesToCopy.Add(fileObject);
                    }
                }
                Debug.WriteLine(filesToCopy);
                FileSystem.FileClipboard.Clear();
                FileSystem.FileClipboard.AddRange(filesToCopy); //Заменяем кэш на новый список элементов, которые мы копируем
            }
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            FileSystem.Paste();
            UpdateFAT();
            UpdateVisual();
        }

        private void btnMoveStart_Click(object sender, EventArgs e)
        {
            btnMoveEnd.Enabled = true;
            btnMoveEnd.BackColor = SystemColors.Control;

            btnMoveStart.Enabled = false;
            btnMoveStart.BackColor = SystemColors.AppWorkspace;
            //panelMove.BringToFront(); //На передний план, перекрываем всё

            //Выбранный файл
            if (listView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView.SelectedItems[0]; //Выбранный файл
                if (selectedItem.Tag is FileObject file)
                {
                    FileSystem.FileMove = file; // Ссылка на файл, который хотим переместить
                }
            }
        }

        private void btnMoveEnd_Click(object sender, EventArgs e)
        {
            btnMoveStart.Enabled = true;
            btnMoveStart.BackColor = SystemColors.Control;

            btnMoveEnd.Enabled = false;
            btnMoveEnd.BackColor = SystemColors.AppWorkspace;

            FileSystem.Move();
            UpdateVisual();
        }

        private void btn_Defragment_Click(object sender, EventArgs e)
        {
            FileSystem.FATfs.Defragment(); //Дефрагментируем
            UpdateFAT();
        }
    }
}
