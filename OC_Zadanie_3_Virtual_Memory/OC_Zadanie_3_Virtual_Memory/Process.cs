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

        Random rnd = new Random();
        int whenTimeToWait;
        int howLongToWait;


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
            ProcMemory = rnd.Next(100, 300); //сколько памяти требуется процессу
        }

        public void Go()
        {
            //Check();
            TimeUsed++;
            Debug.WriteLine("TimeUsed++");
        }
        /* Убираем Check, что бы управлять Process в ProcessManager. Он не должен сам с собой что-то делать
        public void Check()
        {
            //На рандом делаем Waiting
            if (TimeUsed == TimeResurs)
            {
                Status = ProcessStatus.Zombie; //Закончил работать
            }
        }*/
    }
}
