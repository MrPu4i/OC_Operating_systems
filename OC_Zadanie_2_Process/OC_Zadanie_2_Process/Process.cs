using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OC_Zadanie_2_Process
{
    internal class Process
    {

        //на момент рождения cur priority равен base
        int IDProc { get; set; }
        string Name { get; set; } //Proc1
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
        int BasePrior { get; set; } //Задаём рандомно от 0 до 5
        int CurPrior { get; set; } //= BasePrior

        Random rnd = new Random();
        int whenTimeToWait;
        int howLongToWait;


        public Process(int id, string name/*, int base_prior, int time_res*/)
        {
            Status = ProcessStatus.Ready;
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
            TimeResurs = rnd.Next(50, 100);
            //Debug.WriteLine($"{IDProc}, {Name}, {BasePrior}, {CurPrior}, {TimeResurs}");

            whenTimeToWait = rnd.Next(30, 170); //Может ваще не дождёмся
            if (whenTimeToWait <= 100) //Значит нам придёться ждать
            {
                howLongToWait = rnd.Next(0, 70);
            }

            /*_ = StartRandomStatusChanges(); // Запускаем фоновую задачу*/
        }
        //Создать ProcAdd ProcRemoves
        public void Go()
        {
            //Придёться делать через карутины
            Check();
            TimeUsed++;
            //Может рандомно перейти в режим Waiting
        }

        public void Check()
        {
            //Debug.WriteLine("Check");
            if (TimeUsed == TimeResurs)
            {
                Status = ProcessStatus.Zombie; //Закончил работать
            }
        }

        //Понять как работает enum

        public override string ToString()
        {
            return $"{Name}: {Status}";
        }

        /*private async Task StartRandomStatusChanges()
        {
            while (true)
            {
                // Случайная задержка до следующего изменения (1-10 секунд)
                int delayUntilChange = _rnd.Next(1000, 10000);
                await Task.Delay(delayUntilChange);

                // Меняем статус на Waiting на случайное время (0.5-3 секунды)
                if (Status != ProcessStatus.Waiting)
                {
                    var originalStatus = Status;
                    Status = ProcessStatus.Waiting;

                    int waitingDuration = _rnd.Next(500, 3000);
                    await Task.Delay(waitingDuration);

                    // Возвращаем оригинальный статус
                    Status = originalStatus;
                }
            }
        }*/
    }
}
