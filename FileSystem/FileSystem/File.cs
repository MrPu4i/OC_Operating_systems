using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    internal class File : FileObject
    {
        public string Type { get; set; } //Тип файла
        public double Size { get; set; } // Размер файла
        public Random rnd = new Random();
        public File(string name, Folder parent, string type) : base(name, parent) //это конструтор FileObject
        {
            Size = Math.Round((rnd.NextDouble() * 29.9) + 0.1, 1); //В байтах от 0.1 до 30 (рандом)
            Type = type; //Задаёт пользователь из списка предложенных
            Name = name + Type; //Задаёт пользователь (но можно рандомно)
            Parent = parent; //Автоматически
            base.isItFile = true; //Автоматически

            Console.WriteLine($"File создан {Name}");
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
