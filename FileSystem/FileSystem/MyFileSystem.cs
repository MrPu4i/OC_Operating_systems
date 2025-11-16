using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FileSystem
{
    internal class MyFileSystem
    {
        public RootFolder RootFolder {  get; set; } //Корневая папка
        public Folder CurFolder {  get; set; } //Текущая папка (В которой мы)
        public MyFileSystem()
        {
            Console.WriteLine("RootFolder");
            RootFolder = new RootFolder("Root folder", null); //Создали корневую папку
            CurFolder = RootFolder; //В начале текущая папка - это корневая 
        }

        public void CreateFile(string name, Folder parent, string type) //Метод создания файла/папки в текущей папке, возвращающий значение bool;
        {
            File file = new File(name, parent, type);
            CurFolder.Files.Add(file);
        }

        public void CreateFolder(string name, Folder parent) //Метод создания файла/папки в текущей папке, возвращающий значение bool;
        {
            Folder folder = new Folder(name, parent);
            CurFolder.Files.Add(folder);
        }
        /*•	Метод удаления файла/папки из текущей папки, возвращающий значение bool;
•	Метод переименования выбранного(ой) файла/папки, возвращающий значение bool;
•	Метод сортировки файлов и папок по имени в выбранной папке, возвращающий значение bool;
•	Дополнительно: Метод копирования выбранного(ой) файла/папки, возвращающий значение bool;
•	Дополнительно: Метод перемещения выбранного(ой) файла/папки, возвращающий значение bool.*/

    }
}
