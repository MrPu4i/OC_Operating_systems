using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    internal class FileObject
    {
        public string Name { get; set; } //Название
        public Folder Parent { get; set; } //ParentFolder - родитель папки
        public bool isItFile { get; set; } //Булевая - false - папка, true - файл
        public FileObject(string name, Folder parent)
        {
            Name = name;
            Parent = parent;
        }

        public virtual double GetSize() //Как по другому достать size?? Без метода в этом классе
        {
            return 1000;
        }

        public virtual string GetType() //Как по другому достать size?? Без метода в этом классе
        {
            return "wrong";
        }
    }
}
