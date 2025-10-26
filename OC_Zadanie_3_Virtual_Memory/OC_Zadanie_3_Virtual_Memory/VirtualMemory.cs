using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_Zadanie_3_Virtual_Memory
{
    internal class VirtualMemory //Наша виртуальная память
    {
        public int VirtMemory { get; set; }
        public Process[] VirtualMemoryCells { get; set; } //пространство виртуальных адресов для процессов
        public const int PageSize = RAM.PageSize; //размер страницы виртуальной памяти
        public Dictionary<int, int> PageTable { get; set; } // Таблица страниц: key - виртуальный адрес, value - физический адрес в RAM
        public Dictionary<int, int> ReversePageTable { get; set; } //Наоборот

        public VirtualMemory(int totalMemoryKB)
        {
            VirtMemory = totalMemoryKB * 1024;
            int cellCount = VirtMemory / PageSize;
            VirtualMemoryCells = new Process[cellCount];
            PageTable = new Dictionary<int, int>();
            ReversePageTable = new Dictionary<int, int>();

            Debug.WriteLine($"Virtual Memory initialized: {VirtMemory} bytes ({cellCount} pages)");
        }
        public void Init(RAM ram) //Инициализация системы виртуальной памяти
        {
            // В данной реализации инициализация происходит в конструкторе
            Debug.WriteLine("Virtual memory system initialized");
        }
        // Выделение виртуальной памяти процессу
        public int? AllocateVirtualMemory(Process process) //Выделение виртуальной памяти процессу
        {
            int pagesRequired = (int)Math.Ceiling((double)process.ProcMemory / PageSize);

            for (int i = 0; i <= VirtualMemoryCells.Length - pagesRequired; i++)
            {
                bool found = true;
                for (int j = 0; j < pagesRequired; j++)
                {
                    if (VirtualMemoryCells[i + j] != null)
                    {
                        found = false;
                        break;
                    }
                }

                if (found)
                {
                    for (int j = 0; j < pagesRequired; j++)
                    {
                        VirtualMemoryCells[i + j] = process;
                    }

                    process.VirtualMemoryAddress = i;
                    Debug.WriteLine($"Allocated virtual memory to process {process.Name} at address {i}");
                    return i;
                }
            }

            Debug.WriteLine($"Failed to allocate virtual memory for process {process.Name}");
            return null;
        }
        // Освобождение виртуальной памяти
        public void FreeVirtualMemory(Process process)
        {
            if (process.VirtualMemoryAddress == null) return;

            int startAddress = process.VirtualMemoryAddress.Value;
            int pagesOccupied = (int)Math.Ceiling((double)process.ProcMemory / PageSize);

            for (int i = startAddress; i < startAddress + pagesOccupied; i++)
            {
                if (i < VirtualMemoryCells.Length && VirtualMemoryCells[i] == process)
                {
                    VirtualMemoryCells[i] = null;

                    // Удаляем из таблиц страниц
                    if (PageTable.ContainsKey(i))
                    {
                        int physicalAddr = PageTable[i];
                        PageTable.Remove(i);
                        ReversePageTable.Remove(physicalAddr);
                    }
                }
            }
            process.VirtualMemoryAddress = null;
            Debug.WriteLine($"Freed virtual memory for process {process.Name}");
        }
        /*public *//*адрес реальной памяти*//*void VirtAddrToRealAddr(*//*адрес виртуальной памяти*//*)//Метод, преобразующий виртуальный адрес в реальный адрес в оперативной памяти.
        {
            //return address реальной памяти
        }*/
        public int? GetRAMAddr(int virtualAddr)
        {
            if (PageTable.ContainsKey(virtualAddr))
            {
                return PageTable[virtualAddr];
            }
            return null;
        }

        /*public *//*адрес вирт памяти*//*void RealAddrToVirtAddr(*//*адрес реальной памяти*//*)//Наоборот
        {
            //return address вирт памяти
        }*/
        public int? GetVirtualAddr(int ramAddr)
        {
            if (ReversePageTable.ContainsKey(ramAddr))
            {
                return ReversePageTable[ramAddr];
            }
            return null;
        }

        public bool SwapPage(Process processToSwapOut, RAM ram)
        {
            if (processToSwapOut.RAMAddress == null) return false;

            // Освобождаем место в RAM
            ram.FreeMemory(processToSwapOut);

            // Выделяем место в виртуальной памяти
            var virtualAddr = AllocateVirtualMemory(processToSwapOut);
            if (virtualAddr != null)
            {
                Debug.WriteLine($"Swapped out process {processToSwapOut.Name} to virtual memory");
                return true;
            }

            return false;
        }

        // Перемещение процесса из виртуальной памяти в RAM
        public bool SwapIn(Process processToSwapIn, RAM ram)
        {
            if (processToSwapIn.VirtualMemoryAddress == null) return false;

            // Пытаемся выделить память в RAM
            var ramAddr = ram.AllocateMemory(processToSwapIn);
            if (ramAddr != null)
            {
                // Освобождаем виртуальную память
                FreeVirtualMemory(processToSwapIn);
                Debug.WriteLine($"Swapped in process {processToSwapIn.Name} to RAM");
                return true;
            }

            return false;
        }

        // Помечаем страницу как вытесненную
        public void PageOut(int virtualAddr)
        {
            // В данной реализации вытеснение обрабатывается в SwapPage
            Debug.WriteLine($"Page at virtual address {virtualAddr} marked as paged out");
        }
    }
}
