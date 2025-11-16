using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private MyFileSystem fileSystem = new MyFileSystem(); //Создали класс управляющий всем
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            UpdateVisual();
        }

        private void CreateFile_Click(object sender, EventArgs e)
        {
            fileSystem.CreateFile("File_name" + i, fileSystem.CurFolder, ".txt");
            i++;
            UpdateVisual();
        }

        private void CreateFolder_Click(object sender, EventArgs e)
        {
            fileSystem.CreateFolder("Folder_name" + i, fileSystem.CurFolder);
            i++;
            UpdateVisual();
        }


        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView.SelectedItems.Count == 0) return;

            ListViewItem selectedItem = listView.SelectedItems[0];
            Console.WriteLine($"Text: {selectedItem.Text}");
            Console.WriteLine($"Tag type: {selectedItem.Tag?.GetType().Name ?? "NULL"}");
            Console.WriteLine($"Tag value: {selectedItem.Tag}");

            // Проверяем на FileObject (базовый класс)
            if (selectedItem.Tag is FileObject fileObject)
            {
                Console.WriteLine($"FileObject type: {fileObject.Name}");

                // Теперь проверяем, является ли он папкой
                if (fileObject is Folder folder)
                {
                    fileSystem.CurFolder = folder;
                    Console.WriteLine("Вошли в новую папку");
                }
                else
                {
                    Console.WriteLine("Это файл, а не папка");
                }
            }
            else
            {
                Console.WriteLine("Tag не содержит FileObject");
            }

            UpdateVisual();
        }
        private void UpdateVisual()
        {
            UpdateFullPath();

            listView.Items.Clear();

            //Показываем текущую папку
            foreach (var item in fileSystem.CurFolder.Files)
            {
                ListViewItem listItem = new ListViewItem();
                //✉ ◆ ◇ ☔ 😒 ▲ ◯
                if (item is File)
                {
                    //Это файл
                    listItem.Text = item.Name; //Первый столбец с именем
                    listItem.SubItems.Add(DateTime.Now.ToString()); //Дата создания
                    listItem.SubItems.Add($"{item.GetSize()} bytes"); //Размер
                    listItem.SubItems.Add(item.GetType().ToString()); //Тип файла
                    listItem.Tag = item;
                }
                else
                {
                    //Это папка
                    listItem.Text = item.Name;
                    listItem.Tag = item;
                }
                listView.Items.Add(listItem);
            }
            //listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
        private void UpdateFullPath()
        {
            lbl_fullPath.Text = fileSystem.CurFolder.FullPath; //Путь текущей папки
        }

        private void Return_Click(object sender, EventArgs e)
        {
            //Вернуться
            fileSystem.CurFolder = fileSystem.CurFolder.Parent;
            UpdateVisual();
        }
    }
}
