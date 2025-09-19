using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OC_Zadanie_2_Process.Process;

namespace OC_Zadanie_2_Process
{
    internal class Scheduler
    {
        
        public static Process GetNextActive(List<Process> procs)
        {
            Random rnd = new Random();
            while(1 > 0)
            {
                int i = rnd.Next(0, procs.Count - 1); //находим рандомное значение
                if (procs[i].Status == ProcessStatus.Ready)
                {
                    procs[i].Status = ProcessStatus.Active; //Делаем его активным
                    return procs[i];
                }
            }

            //на рандом щас поставить
            //Следующий активный процесс вызывает
            /*foreach (Process proc in procs) //Если есть несколько активных, то он просто выбирает первый по списку
            {
                if (proc.Status == ProcessStatus.Ready) //Если находим готовый
                {
                    proc.Status = ProcessStatus.Active; //Делаем его активным
                    return proc;
                }
            }
            return null;*/


            //случайно выбирает, или по кругу.
            //Когда будет динамический приоритет, выбирает самый приоритетный
            //Он каждый тик переходит в каоке-то состояние. Из Active обратно в Ready или в Waiting. И здесь рандомный выбор.
        }
    }
}
