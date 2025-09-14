using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static OC_Zadanie_2_Process.Process;

namespace OC_Zadanie_2_Process
{
    internal class ProcessManager
    {
        public List<Process> Processes { get; set; }
        Process ActiveProcess { get; set; } //Процесс, который в данный момент активен
        int CurrentTime { get; set; } //Текущее время работы системы (Просто всё время работы всех процессов?? + пока есть активные процессы)

        int id_next = 0;
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
            foreach (Process proc in Processes)
            {
                if (proc.Status == ProcessStatus.Zombie)
                {
                    Processes.Remove(proc);
                    ActiveProcess = null;
                    return;
                }
            }
        }
        public void NextTime() //Каждый квант времени
        {
            // a) проверить и удалить завершенные процессы;
            VerifyForTerminated();

            // b) с помощью планировщика определить следующий активный процесс;
            if (ActiveProcess == null)
            {
                ActiveProcess = Scheduler.GetNextActive(Processes); //Присваиваем новый Ready
            }
            else
            {
                ActiveProcess.Go();
            }
        }
    }
}
