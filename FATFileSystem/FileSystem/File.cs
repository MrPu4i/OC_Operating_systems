using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FileSystem
{
    internal class File : FileObject
    {
        public int Adress {  get; set; } //Номер кластера, с которого начинается заполнени
        public string Type { get; set; } //Тип файла
        public double Size { get; set; } // Размер файла
        public Random rnd = new Random();
        public File(string name, Folder parent, string type) : base(name, parent) //это конструтор FileObject
        {
            Size = Math.Round((rnd.NextDouble() * 29.9) + 0.1, 1); //В байтах от 0.1 до 30 (рандом)
            Type = type; //Задаёт пользователь из списка предложенных
            Name = name; //Задаёт пользователь (но можно рандомно)
            Parent = parent; //Автоматически
            base.isItFile = true; //Автоматически

            Console.WriteLine($"File создан {Name}");
        }

        public static File NewFromFile(File file, Folder newParent, double size, int adress)
        {
            MyFileSystem.Instance.FATfs.Create(file);
            File newFile = new File(file.Name + "_copy", newParent, file.Type);
            newFile.Size = size; //Запоминаем размер памяти
            newFile.Adress = adress;
            MyFileSystem.Instance.AllFiles.Add(newFile);
            return newFile;
        }

        public override double GetSize()
        {
            return Size;
        }

        public override string GetType()
        {
            return Type;
        }
    }
}
