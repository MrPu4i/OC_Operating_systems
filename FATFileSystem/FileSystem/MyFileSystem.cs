using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FileSystem
{
    internal class MyFileSystem
    {
        public FATFileSystem FATfs {  get; set; }
        private static readonly Lazy<MyFileSystem> instance = new Lazy<MyFileSystem>(() => new MyFileSystem());

        public List<FileObject> AllFiles { get; set; } = new List<FileObject>();

        public static MyFileSystem Instance => instance.Value;

        public RootFolder RootFolder { get; set; } //Корневая папка
        public Folder CurFolder { get; set; } //Текущая папка (В которой мы)
        public List<FileObject> FileClipboard { get; set; } = new List<FileObject>();  //Файл, который мы копируем
        public FileObject FileMove { get; set; } //Файл, который хотим переместить
        public MyFileSystem()
        {
            FATfs = new FATFileSystem(); //Экземпляр FAT-системы

            Console.WriteLine("RootFolder");
            RootFolder = new RootFolder("Root folder", null); //Создали корневую папку
            CurFolder = RootFolder; //В начале текущая папка - это корневая 
        }

        public void CreateFile(string name, Folder parent, string type) //Метод создания файла/папки в текущей папке, возвращающий значение bool;
        {
            File file = new File(name, parent, type);

            if (FATfs.Create(file))
            {
                /*FATfs.Create(file);*/
                AllFiles.Add(file);
            }
        }

        public void CreateFolder(string name, Folder parent) //Метод создания файла/папки в текущей папке, возвращающий значение bool;
        {
            Folder folder = new Folder(name, parent);
            AllFiles.Add(folder);
        }

        public void DeleteFileObject(FileObject fileToDelete) //Метод удаления файла/папки из текущей папки, возвращающий значение bool;
        {
            //FATfs.Delete(fileToDelete);
            AllFiles.Remove(fileToDelete);
            //Нужно пройтись по всем файлам внутри папки и удалить
            if (fileToDelete is File file)
            {
                FATfs.DeleteFile(file);
            }
            else if (fileToDelete is Folder folder)
            {
                FATfs.DeleteFolder(folder);
            }
                fileToDelete = null; //И сам файл убираем из памяти
        }

        public void Rename(FileObject fileObject, string newName) //Метод переименования выбранного(ой) файла/папки, возвращающий значение bool;
        {
            // Проверяем валидность имени
            if (string.IsNullOrWhiteSpace(newName) || newName == fileObject.Name)
                return;
            if (CurFolder.Files.Any(f => f.Name == newName && f != fileObject))
            {
                MessageBox.Show("Файл с таким именем уже существует!");
            }
            else
            {
                fileObject.Name = newName; // Меняем имя
            }
        }

        public void Paste() //Вставить
        {
            //В FileClipboard хранятся оригиналы
            FileClipboard.ForEach(fileObject =>
            {
                if (fileObject is File file)
                {
                    File.NewFromFile(file, CurFolder, file.GetSize(), file.Adress);
                }
                if (fileObject is Folder folder)
                {
                    Folder.NewFromFolder(folder, CurFolder);
                }
            });

            //Добавляем запомненный файл в текущую дерикторию
            Debug.WriteLine(CurFolder.Files);
            // AllFiles.AddRange(newList); //Добавляем к текущему списку файлов те, которые мы когда-то скопировали
            Debug.WriteLine(CurFolder.Files);
        }

        public void Move() //Метод перемещения выбранного(ой) файла/папки, возвращающий значение bool.
        {
            FileMove.Parent = CurFolder; //Просто меняем ему parent
        }
    }
}
