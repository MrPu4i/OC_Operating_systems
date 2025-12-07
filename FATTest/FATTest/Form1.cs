using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FATTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fileSystem = new FileSystem(512, 32); // 32 кластера по 512 байт
            SetupControls();
            UpdateVisualization();
            UpdateFileList();
        }
        public class File
        {
            public string Name { get; set; }
            public string Content { get; set; }
            public int Size { get; set; }
            public int Address { get; set; } // Номер первого кластера
            public bool IsDirectory { get; set; }
            public List<File> Children { get; set; }

            public File(string name, bool isDirectory = false)
            {
                Name = name;
                Content = "";
                Size = 0;
                Address = -1; // -1 означает, что файл не размещен
                IsDirectory = isDirectory;
                Children = new List<File>();
            }
        }
        public class FileSystem
        {
            public int ClusterSize { get; private set; }
            public int NumClusters { get; private set; }
            public int Space { get; private set; }
            public int FreeSpace { get; private set; }
            public int[] FAT { get; private set; }

            private Dictionary<string, File> files;
            private File root;

            public FileSystem(int clusterSize = 512, int numClusters = 64)
            {
                ClusterSize = clusterSize;
                NumClusters = numClusters;
                Space = ClusterSize * NumClusters;
                FreeSpace = Space;

                // Инициализация FAT таблицы
                FAT = new int[NumClusters];
                for (int i = 0; i < NumClusters; i++)
                {
                    FAT[i] = 0; // 0 - свободный кластер
                }

                files = new Dictionary<string, File>();
                root = new File("", true);
                root.Address = 0; // Корневая директория занимает кластер 0
                FAT[0] = -1; // -1 - конец цепочки
            }

            // Проверка наличия свободной памяти
            public bool HasFreeSpace(int size)
            {
                return FreeSpace >= size && GetFreeClustersCount() >= GetRequiredClusters(size);
            }

            // Создание файла
            public bool CreateFile(string path, string content = "")
            {
                try
                {
                    string[] parts = path.Split('/');
                    string fileName = parts[parts.Length - 1];

                    int requiredClusters = GetRequiredClusters(content.Length);
                    if (!HasFreeSpace(content.Length))
                        return false;

                    // Ищем свободные кластеры
                    List<int> freeClusters = FindFreeClusters(requiredClusters);
                    if (freeClusters.Count < requiredClusters)
                        return false;

                    // Создаем файл
                    File newFile = new File(fileName)
                    {
                        Content = content,
                        Size = content.Length,
                        Address = freeClusters[0]
                    };

                    // Занимаем кластеры в FAT
                    for (int i = 0; i < freeClusters.Count; i++)
                    {
                        if (i == freeClusters.Count - 1)
                            FAT[freeClusters[i]] = -1; // Последний кластер
                        else
                            FAT[freeClusters[i]] = freeClusters[i + 1]; // Следующий кластер
                    }

                    // Добавляем файл в систему
                    files[path] = newFile;
                    FreeSpace -= content.Length;

                    return true;
                }
                catch
                {
                    return false;
                }
            }

            // Удаление файла
            public bool DeleteFile(string path)
            {
                if (!files.ContainsKey(path))
                    return false;

                File file = files[path];

                // Освобождаем кластеры в FAT
                int currentCluster = file.Address;
                while (currentCluster != -1 && currentCluster < FAT.Length)
                {
                    int nextCluster = FAT[currentCluster];
                    FAT[currentCluster] = 0; // Освобождаем кластер
                    currentCluster = nextCluster;
                }

                FreeSpace += file.Size;
                files.Remove(path);

                return true;
            }

            // Дефрагментация диска
            public void Defragment()
            {
                // Собираем все занятые кластеры
                List<int> usedClusters = new List<int>();
                foreach (var file in files.Values)
                {
                    int currentCluster = file.Address;
                    while (currentCluster != -1 && currentCluster < FAT.Length)
                    {
                        usedClusters.Add(currentCluster);
                        currentCluster = FAT[currentCluster];
                    }
                }

                // Перераспределяем кластеры последовательно
                for (int i = 0; i < usedClusters.Count - 1; i++)
                {
                    FAT[usedClusters[i]] = usedClusters[i + 1];
                }
                if (usedClusters.Count > 0)
                {
                    FAT[usedClusters[-1]] = -1;
                }
            }

            // Вспомогательные методы
            private int GetRequiredClusters(int size)
            {
                return (int)Math.Ceiling((double)size / ClusterSize);
            }

            private int GetFreeClustersCount()
            {
                return FAT.Count(cluster => cluster == 0);
            }

            private List<int> FindFreeClusters(int count)
            {
                List<int> freeClusters = new List<int>();
                for (int i = 0; i < FAT.Length && freeClusters.Count < count; i++)
                {
                    if (FAT[i] == 0)
                    {
                        freeClusters.Add(i);
                    }
                }
                return freeClusters;
            }

            // Получение информации о файлах для визуализации
            public Dictionary<int, File> GetClusterFileMap()
            {
                var clusterMap = new Dictionary<int, File>();

                foreach (var file in files.Values)
                {
                    int currentCluster = file.Address;
                    while (currentCluster != -1 && currentCluster < FAT.Length)
                    {
                        clusterMap[currentCluster] = file;
                        currentCluster = FAT[currentCluster];
                    }
                }

                return clusterMap;
            }
        }
            private FileSystem fileSystem;
            private DataGridView dataGridView;
            private ListBox listBoxFiles;
            private TextBox textBoxFileName;
            private TextBox textBoxFileContent;
            private Button buttonCreate;
            private Button buttonDelete;
            private Button buttonDefragment;
            private Label labelInfo;


            private void SetupControls()
            {
                this.Text = "FAT File System Visualizer";
                this.Size = new Size(1000, 700);

                // Таблица кластеров
                dataGridView = new DataGridView
                {
                    Location = new Point(10, 10),
                    Size = new Size(700, 400),
                    RowHeadersVisible = false,
                    ColumnHeadersVisible = false,
                    AllowUserToAddRows = false,
                    ReadOnly = true
                };

                // Настраиваем 16 колонок для отображения кластеров
                for (int i = 0; i < 16; i++)
                {
                    dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Width = 40,
                        DefaultCellStyle = new DataGridViewCellStyle
                        {
                            Alignment = DataGridViewContentAlignment.MiddleCenter,
                            Font = new Font("Arial", 9, FontStyle.Bold)
                        }
                    });
                }

                // Добавляем строки для отображения всех кластеров
                int rowsNeeded = (int)Math.Ceiling(fileSystem.NumClusters / 16.0);
                for (int i = 0; i < rowsNeeded; i++)
                {
                    dataGridView.Rows.Add();
                }

                // Список файлов
                listBoxFiles = new ListBox
                {
                    Location = new Point(720, 10),
                    Size = new Size(250, 200)
                };

                // Элементы управления
                textBoxFileName = new TextBox
                {
                    Location = new Point(720, 220),
                    Size = new Size(150, 20),
                    Text = "newfile.txt"
                };

                textBoxFileContent = new TextBox
                {
                    Location = new Point(720, 250),
                    Size = new Size(250, 60),
                    Multiline = true,
                    Text = "File content here"
                };

                buttonCreate = new Button
                {
                    Location = new Point(720, 320),
                    Size = new Size(80, 30),
                    Text = "Create"
                };
                buttonCreate.Click += ButtonCreate_Click;

                buttonDelete = new Button
                {
                    Location = new Point(810, 320),
                    Size = new Size(80, 30),
                    Text = "Delete"
                };
                buttonDelete.Click += ButtonDelete_Click;

                buttonDefragment = new Button
                {
                    Location = new Point(720, 360),
                    Size = new Size(170, 30),
                    Text = "Defragment"
                };
                buttonDefragment.Click += ButtonDefragment_Click;

                labelInfo = new Label
                {
                    Location = new Point(10, 420),
                    Size = new Size(700, 50),
                    Font = new Font("Arial", 10)
                };

                // Добавляем элементы на форму
                Controls.AddRange(new Control[] {
            dataGridView, listBoxFiles, textBoxFileName,
            textBoxFileContent, buttonCreate, buttonDelete,
            buttonDefragment, labelInfo
        });
            }

            private void UpdateVisualization()
            {
                // Очищаем таблицу
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Value = "";
                        cell.Style.BackColor = Color.LightGray;
                        cell.Style.ForeColor = Color.Black;
                    }
                }

                // Получаем информацию о занятых кластерах
                var clusterMap = fileSystem.GetClusterFileMap();
                var fileColors = GenerateFileColors();

                // Заполняем таблицу
                for (int i = 0; i < fileSystem.NumClusters; i++)
                {
                    int row = i / 16;
                    int col = i % 16;

                    if (row < dataGridView.Rows.Count && col < dataGridView.Columns.Count)
                    {
                        var cell = dataGridView.Rows[row].Cells[col];

                        if (fileSystem.FAT[i] == 0) // Свободный кластер
                        {
                            cell.Value = "Free";
                            cell.Style.BackColor = Color.LightGreen;
                        }
                        else if (clusterMap.ContainsKey(i)) // Занятый кластер
                        {
                            File file = clusterMap[i];
                            cell.Value = $"{i}\n→{fileSystem.FAT[i]}";

                            // Генерируем цвет на основе имени файла
                            Color fileColor = fileColors[file.Name];
                            cell.Style.BackColor = fileColor;
                            cell.Style.ForeColor = GetContrastColor(fileColor);
                        }
                        else // Системный или поврежденный
                        {
                            cell.Value = "Sys";
                            cell.Style.BackColor = Color.LightGray;
                        }
                    }
                }

                // Обновляем информацию
                labelInfo.Text = $"Clusters: {fileSystem.NumClusters} | " +
                                $"Cluster Size: {fileSystem.ClusterSize} bytes | " +
                                $"Free Space: {fileSystem.FreeSpace} bytes | " +
                                $"Used: {fileSystem.Space - fileSystem.FreeSpace} bytes";
            }

            private void UpdateFileList()
            {
                listBoxFiles.Items.Clear();
                // Здесь должна быть логика получения списка файлов из fileSystem
                // Для демонстрации добавляем заглушку
                listBoxFiles.Items.Add("file1.txt (3 clusters)");
                listBoxFiles.Items.Add("file2.txt (2 clusters)");
                listBoxFiles.Items.Add("document.doc (5 clusters)");
            }

            private Dictionary<string, Color> GenerateFileColors()
            {
                var colors = new Dictionary<string, Color>();
                var colorPalette = new Color[]
                {
            Color.LightBlue, Color.LightCoral, Color.LightYellow,
            Color.LightPink, Color.LightGreen, Color.LightSeaGreen,
            Color.LightSteelBlue, Color.LightSalmon, Color.LightSkyBlue
                };

                int colorIndex = 0;
                // Здесь нужно получить реальные имена файлов из fileSystem
                string[] sampleFiles = { "file1.txt", "file2.txt", "document.doc" };

                foreach (var fileName in sampleFiles)
                {
                    colors[fileName] = colorPalette[colorIndex % colorPalette.Length];
                    colorIndex++;
                }

                return colors;
            }

            private Color GetContrastColor(Color color)
            {
                double luminance = (0.299 * color.R + 0.587 * color.G + 0.114 * color.B) / 255;
                return luminance > 0.5 ? Color.Black : Color.White;
            }

            // Обработчики событий
            private void ButtonCreate_Click(object sender, EventArgs e)
            {
                string fileName = textBoxFileName.Text;
                string content = textBoxFileContent.Text;

                if (fileSystem.CreateFile(fileName, content))
                {
                    MessageBox.Show("File created successfully!");
                    UpdateVisualization();
                    UpdateFileList();
                }
                else
                {
                    MessageBox.Show("Failed to create file: not enough space!");
                }
            }

            private void ButtonDelete_Click(object sender, EventArgs e)
            {
                if (listBoxFiles.SelectedItem != null)
                {
                    string fileName = listBoxFiles.SelectedItem.ToString().Split(' ')[0];
                    if (fileSystem.DeleteFile(fileName))
                    {
                        MessageBox.Show("File deleted successfully!");
                        UpdateVisualization();
                        UpdateFileList();
                    }
                }
            }

            private void ButtonDefragment_Click(object sender, EventArgs e)
            {
                fileSystem.Defragment();
                UpdateVisualization();
                MessageBox.Show("Disk defragmentation completed!");
            }
        }
    }

