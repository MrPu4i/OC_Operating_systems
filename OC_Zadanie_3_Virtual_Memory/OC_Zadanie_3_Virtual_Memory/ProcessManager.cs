using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static OC_Zadanie_3_Virtual_Memory.Process;

namespace OC_Zadanie_3_Virtual_Memory
{
    internal class ProcessManager
    {
        public List<Process> Processes { get; set; }
        Process ActiveProcess { get; set; } //Процесс, который в данный момент активен
        public int CurrentTime { get; set; } //Текущее время работы системы (Просто всё время работы всех процессов?? + пока есть активные процессы)

        int id_next = 0;
        int i = 0;

        Random rnd = new Random();
        public ProcessManager()
        {
            Processes = new List<Process>();
        }
        public void ProcessAdd(string id, string name)
        {
            id_next++;
            if (id == "")
            {
                id = Convert.ToString(id_next);
            }
            //id тоже можем создавать не сами ну лан
            if (name == "") //Значит у нас процесс без названия
            {
                name = "Proc" + id;
                Debug.WriteLine(name); //Проверить имя
            }
            
            //Создаём и добавляем процесс в список
            Process proc = new Process(Convert.ToInt32(id), name);
            Processes.Add(proc); //Добавляем процесс в список
        }

        public void ProcessRemove(int index)
        {
            Processes.RemoveAt(index);
        }
        public void VerifyForTerminated() //Удаляем зомби
        {
            for (int i = Processes.Count - 1; i >= 0; i--)
            {
                if (Processes[i].Status == ProcessStatus.Zombie)
                {
                    Processes.RemoveAt(i);
                }
            }
        }
        public void NextTime() //Каждый квант времени
        {
            CurrentTime++;

            i++;
            if (i == 5)
            {
                // 1. проверить и удалить завершенные процессы;
                VerifyForTerminated();
                Debug.WriteLine("NextTime");
                ChangeWaiting();
                i = 0;
            }
            if (ActiveProcess != null)
            {
                ChangeActive();
            }


            // 3. с помощью планировщика определить следующий активный процесс;
            ActiveProcess = Scheduler.GetNextActive(Processes); //Присваиваем новый Ready
            if (ActiveProcess != null) //null возвращает, когда нет Ready
            {
                //ActiveProcess.Status = ProcessStatus.Active; //Делаем текущий процесс Active
                ActiveProcess.Go();
                // 2. из актива переводит куда-то

            }
        }

        //Метод, который переводит активный элемент куда подальше
        public void ChangeActive()
        {
            //Debug.WriteLine($"{ActiveProcess.Status}, {ActiveProcess.TimeResurs}, {ActiveProcess.TimeUsed}");
            //может в Zombie если закончил
            if (ActiveProcess.TimeUsed >= ActiveProcess.TimeResurs)
            {
                Debug.WriteLine("Вошли в Zombie");
                ActiveProcess.Status = ProcessStatus.Zombie; //Делаем зомби
                return;
            }
            //может в Ready вернуть
            //может в Waiting по приколу
            //Сделать шанс 10%, что перейдёт в Waiting
            int chance = rnd.Next(0, 100);
            if (chance <= 10)
            {
                ActiveProcess.Status = ProcessStatus.Waiting;
                return;
            }
            else
            {
                Debug.WriteLine("Зашли в присваивание Ready");
                ActiveProcess.Status = ProcessStatus.Ready;
                return;
            }

        }

        //метод, который пройдётся по всем Waiting раз в сколько-то тиков, и какие-то переведёт в Ready
        public void ChangeWaiting()
        {
            foreach (Process proc in Processes)
            {
                if (proc.Status == ProcessStatus.Waiting)
                {
                    //С каким-то шансом 60% вернуть в Ready
                    int chance = rnd.Next(0, 100);
                    if (chance <= 60)
                    {
                        proc.Status = ProcessStatus.Ready; //Возращаем ему статус Ready
                    }
                }
            }
        }
    }
}
