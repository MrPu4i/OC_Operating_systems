using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFileSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Start();
        }

        static void Start()
        {
            // Получаем текущую директорию
            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine($"Текущая директория: {currentDirectory}\n");

            // Выводим папки
            Console.WriteLine("ПАПКИ:");
            string[] directories = Directory.GetDirectories(currentDirectory);
            foreach (string dir in directories)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(dir);
                Console.WriteLine($"  [DIR]  {dirInfo.CreationTime:dd.MM.yyyy HH:mm}  {Path.GetFileName(dir)}");
            }

            // Выводим файлы
            Console.WriteLine("\nФАЙЛЫ:");
            string[] files = Directory.GetFiles(currentDirectory);

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                string size = FormatFileSize(fileInfo.Length);
                Console.WriteLine($"  [FILE] {fileInfo.CreationTime:dd.MM.yyyy HH:mm}  {size,10}  {Path.GetFileName(file)}");
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

        // Метод для форматирования размера файла в читабельном виде
        static string FormatFileSize(long bytes)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            int order = 0;
            double size = bytes;

            while (size >= 1024 && order < sizes.Length - 1)
            {
                order++;
                size = size / 1024;
            }

            return $"{size:0.##} {sizes[order]}";
        }
    }
}
