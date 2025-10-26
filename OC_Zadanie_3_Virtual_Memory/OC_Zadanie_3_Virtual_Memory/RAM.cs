using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_Zadanie_3_Virtual_Memory
{
    internal class RAM //Наша оперативная память ОЗУ
    {
        public int RAMMemory { get; set; } //в байтах
        public Process[] RAMMemoryCells { get; set; } // Индекс - адрес, значение - процесс, занимающий эту ячейку (null - свободно)
        public const int PageSize = 64; //байта
        public RAM(int totalMemoryKB)
        {
            // Переводим КБ в байты
            RAMMemory = totalMemoryKB * 1024;

            // Инициализируем память как массив пустых ячеек
            int cellCount = RAMMemory / PageSize;
            RAMMemoryCells = new Process[cellCount];

            Debug.WriteLine($"RAM initialized: {RAMMemory} bytes ({cellCount} pages)");
        }

        public int? AllocateMemory(Process process) // Метод для выделения памяти процессу
        {
            int pagesRequired = (int)Math.Ceiling((double)process.ProcMemory / PageSize);

            // Ищем последовательность свободных страниц
            for (int i = 0; i <= RAMMemoryCells.Length - pagesRequired; i++)
            {
                bool found = true;
                for (int j = 0; j < pagesRequired; j++)
                {
                    if (RAMMemoryCells[i + j] != null)
                    {
                        found = false;
                        break;
                    }
                }

                if (found)
                {
                    // Занимаем найденные страницы
                    for (int j = 0; j < pagesRequired; j++)
                    {
                        RAMMemoryCells[i + j] = process;
                    }

                    process.RAMAddress = i; // Сохраняем начальный адрес
                    Debug.WriteLine($"Allocated {pagesRequired} pages to process {process.Name} at address {i}");
                    return i;
                }
            }

            // Не удалось выделить память
            Debug.WriteLine($"Failed to allocate {pagesRequired} pages for process {process.Name}");
            return null; //что бы можно было вернуть int?
        }

        public void FreeMemory(Process process) // Метод для освобождения памяти процесса
        {
            if (process.RAMAddress == null) return;

            int startAddress = process.RAMAddress.Value;
            int pagesOccupied = (int)Math.Ceiling((double)process.ProcMemory / PageSize);

            for (int i = startAddress; i < startAddress + pagesOccupied; i++)
            {
                if (i < RAMMemoryCells.Length && RAMMemoryCells[i] == process)
                {
                    RAMMemoryCells[i] = null;
                }
            }

            process.RAMAddress = null;
            Debug.WriteLine($"Freed memory for process {process.Name}");
        }
        public bool CanAllocate(int memoryRequired) //Есть ли свободное место для процесса
        {
            int pagesRequired = (int)Math.Ceiling((double)memoryRequired / PageSize);

            // Простой поиск последовательности свободных страниц
            int freeSequence = 0;
            for (int i = 0; i < RAMMemoryCells.Length; i++)
            {
                if (RAMMemoryCells[i] == null)
                {
                    freeSequence++;
                    if (freeSequence >= pagesRequired) return true;
                }
                else
                {
                    freeSequence = 0;
                }
            }

            return false;
        }
        public int GetFreePages() //Свободная память - в страницах
        {
            return RAMMemoryCells.Count(cell => cell == null);
        }
    }
}
