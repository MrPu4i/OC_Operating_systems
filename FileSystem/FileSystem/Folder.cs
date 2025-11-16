using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    internal class Folder : FileObject
    {
        public List<FileObject> Files
        {
            get
            {
                return MyFileSystem.Instance.AllFiles
                   .Where(file => file.Parent == this)
                   .ToList();
            }
        }
        public string FullPath { get; set; } //Полный путь папки
        public Folder(string name, Folder parent) : base(name, parent) //это конструтор FileObject
        {
            Name = name;
            Parent = parent;

            base.isItFile = false;

            // Files = new List<FileObject>(); //Пустая папка

            FullPath = Name;
            FindFullPath(Parent);

            Console.WriteLine($"Folder создан {Name}");
        }

        public static Folder NewFromFolder(Folder sourceFolder, Folder newParent)
        {
            Folder newFolder = new Folder(sourceFolder.Name + "_copy", newParent);

            sourceFolder.Files.ForEach(fileObject =>
            {
                if (fileObject is File file)
                {
                    File.NewFromFile(file, newFolder);
                }
                if (fileObject is Folder folder)
                {
                    Folder.NewFromFolder(folder, newFolder);
                }
            });

            MyFileSystem.Instance.AllFiles.Add(newFolder);
            return newFolder;
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

        public void GetFiles(string path)
        {
            FullPath = path; // Можно установить внутри класса
        }
    }
}
