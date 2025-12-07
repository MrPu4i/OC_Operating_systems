using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSystem
{
    internal class FATFileSystem
    {
        internal class FATindex
        {
            //Состояния: ничего нет, значение следующего индекса, -1
        }
            public double ClusterSize { get; set; } = 6; //Размер кластера (страницы) 6 байт
        public int numClusters { get; set; } = 40; //Количество кластеров (страниц) 40

        public double Space //В байтах
        {
            get
            {
                return ClusterSize * numClusters;
            }
        }

        public int empty = -2;
        public double FreeSpace { get; set; }
        public List<int> FAT {  get; set; } //Сами ячейки (новый элемент) ИНДЕКСЫ КЛАСТЕРОВ

        public FATFileSystem()
        {
            FreeSpace = Space; //В начале у нас всё место свободное
            FAT = Enumerable.Repeat(empty, numClusters).ToList(); //Пустой лист на 40 ячеек, где -2 это пусто
        }
        public List<int> GetFreeIndex(int howMuchClusters, List<int> table)
        {
            List<int> freeClusters = new List<int>();
            //Находим сколько-то свободных кластеров
            for (int i = 0; i < table.Count; i++) //Идём по всему листу
            {
                if(freeClusters.Count == howMuchClusters) //Если уже нашли сколько нужно ячеек
                {
                    return freeClusters;
                }
                if (table[i] == empty)
                {
                    freeClusters.Add(i); //Добавляем индексы свободных кластеров
                }
            }
            return freeClusters;
        }
        public bool IsThereFreeSpace(File file)
        {
            if (FreeSpace >= file.Size) //Есть место для файла
            {
                Debug.WriteLine($"{FreeSpace}  {file.Size}");
                return true; //Можем создать файл
            }
            else { return false; }
        }

        public bool Create(File file)
        {
            if (IsThereFreeSpace(file))
            {
                //Есть свободное место
                //Добавляем файл в таблицу
                //Сколько страниц займёт файл
                int howMuchClusters = (int)Math.Ceiling((double)file.Size / ClusterSize);
                List<int> freeClusters = GetFreeIndex(howMuchClusters, FAT); //Получили список свободных индексов
                file.Adress = freeClusters[0]; //Первый индекс
                if (freeClusters.Count != 1)
                {
                    for (int i = 0; i < howMuchClusters - 1; i++)
                    {
                        FAT[freeClusters[i]] = freeClusters[i + 1];

                    }
                }
                FAT[freeClusters[freeClusters.Count - 1]] = -1; //Последняя ячейка
                FreeSpace -= howMuchClusters * ClusterSize; //Убираем свободное место
                return true;
            }
            else
            {
                MessageBox.Show("Не хватает места (удалите файлы)");
                return false;
            }
        }

        public void DeleteFile(File file)
        {
            //Просто удаляем файл из таблицы
            //Начинаем с адреса файла и идём по всем остальным
            DeleteIndex(file.Adress); //Нам главное очистить FAT таблицу
            
            FreeSpace = FreeSpace + (int)Math.Ceiling((double)file.Size / ClusterSize) * ClusterSize; //Добавляем свободное место
        }
        public void DeleteFolder(Folder folder)
        {
            for (int i = 0; i < folder.Files.Count; i++)
            {
                if (folder.Files[i] is File file)
                {
                    DeleteFile(file);
                }
                else if (folder.Files[i] is Folder foldr)
                {
                    DeleteFolder(foldr);
                }
            }
        }

        public void DeleteIndex(int i)
        {
            int a = FAT[i];
            FAT[i] = empty; //Очищаем ячейку в любом случае
            if (a == -1) //Последний элемент
            {
                return;
            }
            DeleteIndex(a);
        }

        public void Defragment() //Сортируем FAT-таблицу
        {
            //Все файлы
            List<File> allFiles = MyFileSystem.Instance.AllFiles
            .Where(f => f is File)
            .Cast<File>()
            .OrderBy(f => f.Size)
            .ToList();

            List<int> newFAT = Enumerable.Repeat(empty, numClusters).ToList(); //Новая временная FAT

            //Берём файл и распологаем его в новой таблице
            foreach (File file in allFiles)
            {
                int howMuchClusters = (int)Math.Ceiling((double)file.Size / ClusterSize);
                List<int> freeClusters = GetFreeIndex(howMuchClusters, newFAT); //Получили список свободных индексов
                file.Adress = freeClusters[0]; //Первый индекс
                if (freeClusters.Count != 1)
                {
                    for (int i = 0; i < howMuchClusters - 1; i++)
                    {
                        newFAT[freeClusters[i]] = freeClusters[i + 1];

                    }
                    newFAT[freeClusters[freeClusters.Count - 1]] = -1; //Последняя ячейка
                }
            }
            FAT = newFAT; //Заменяем FAT
        }
    }
}
