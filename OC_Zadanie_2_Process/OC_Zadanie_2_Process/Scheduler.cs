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
            //Следующий активный процесс вызывает
            foreach (Process proc in procs) //Если есть несколько активных, то он просто выбирает первый по списку
            {
                if (proc.Status == ProcessStatus.Ready) //Если находим готовый
                {
                    proc.Status = ProcessStatus.Active; //Делаем его активным
                    return proc;
                }
            }
            //Console.WriteLine("Нет готовых процессов");
            return null;
        }
    }
}
