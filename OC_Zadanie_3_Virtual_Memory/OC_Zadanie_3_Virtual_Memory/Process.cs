using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OC_Zadanie_3_Virtual_Memory
{
    internal class Process
    {

        //на момент рождения cur priority равен base
        public int IDProc { get; set; }
        public string Name { get; set; } //Proc1
        public ProcessStatus Status { get; set; }//enum
        public enum ProcessStatus
        {
            Ready,    // Готов
            Active,   // Активный
            Waiting,  // Ожидание
            Zombie    // Зомби
        }
        public int TimeUsed { get; set; } = 0; //Считаем каждый тик. Сразу задаём 0
        public int TimeResurs { get; set; } //Сколько он выполняется
        public int BasePrior { get; set; } //Задаём рандомно от 0 до 5
        public int CurPrior { get; set; } //= BasePrior

        public int ProcMemory { get; set; }

        public int? RAMAddress { get; set; } // Адрес в оперативной памяти
        public int? VirtualMemoryAddress { get; set; } // Адрес в виртуальной памяти

        Random rnd = new Random();


        public Process(int id, string name)
        { 
            Status = ProcessStatus.Ready;
            Random rnd = new Random();
            IDProc = id;
            Name = name;
            BasePrior = rnd.Next(1, 10);
            CurPrior = BasePrior;
            TimeResurs = rnd.Next(5, 10);
            //Debug.WriteLine($"{IDProc}, {Name}, {BasePrior}, {CurPrior}, {TimeResurs}");
            ProcMemory = rnd.Next(100, 500); //сколько памяти требуется процессу
            RAMAddress = null;
            VirtualMemoryAddress = null;
        }

        public void Go()
        {
            //Check();
            TimeUsed++;
            Debug.WriteLine("TimeUsed++");
        }

        public bool IsInRAM()
        {
            return RAMAddress != null;
        }

        public bool IsInVirtualMemory()
        {
            return VirtualMemoryAddress != null;
        }
    }
}
