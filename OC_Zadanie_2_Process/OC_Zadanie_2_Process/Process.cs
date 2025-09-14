using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_Zadanie_2_Process
{
    internal class Process
    {

        //на момент рождения cur priority равен base
        int IDProc { get; set; }
        string Name { get; set; } //Proc1
        string Status { get; set; } //enum
        int TimeUsed { get; set; } = 0; //Считаем каждый тик. Сразу задаём 0
        int TimeResurs { get; set; } //Сколько он выполняется
        int BasePrior { get; set; } //Задаём рандомно от 0 до 5
        int CurPrior { get; set; } //= BasePrior

        public Process(int id, string name/*, int base_prior, int time_res*/)
        {
            Random rnd = new Random();
            //Задать ID
            IDProc = id;
            //Задать имя
            Name = name;
            //Задать приоритет
            //BasePrior = base_prior;
            BasePrior = rnd.Next(0, 5);
            CurPrior = BasePrior;
            //Задать время исполнения
            //TimeResurs = time_res;
            TimeResurs = rnd.Next(5, 15);
        }
        //Создать ProcAdd ProcRemove
        public void Go()
        {
            TimeUsed++;
        }

    }
}
