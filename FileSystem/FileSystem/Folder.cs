using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    internal class Folder : FileObject
    {
        public List<FileObject> Files; 
        public string FullPath { get; set; } //Полный путь папки
        public Folder(string name, Folder parent) : base(name, parent) //это конструтор FileObject
        {
            Name = name;
            Parent = parent;

            base.isItFile = false;

            Files = new List<FileObject>(); //Пустая папка

            FullPath = Name;
            FindFullPath(Parent);

            Console.WriteLine($"Folder создан {Name}");
        }

        public virtual void FindFullPath(Folder folder) //Рекурсивный метод
        {
            Console.WriteLine(folder);
            if (folder is RootFolder) //Пока не дойдём до корневой папки
            {
                FullPath = folder.Name + "/" + FullPath;
                Console.WriteLine(FullPath);
                return;
            }
            else
            {
                FullPath = folder.Name + "/" + FullPath;
                Console.WriteLine(FullPath);
                FindFullPath(folder.Parent);
            }
            //Выходим из цикла
        }
    }
}
