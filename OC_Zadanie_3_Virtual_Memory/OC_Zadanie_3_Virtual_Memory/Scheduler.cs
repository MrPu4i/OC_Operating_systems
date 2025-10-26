using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OC_Zadanie_3_Virtual_Memory.Process;

namespace OC_Zadanie_3_Virtual_Memory
{
    internal class Scheduler
    {
        
        public static Process GetNextActive(List<Process> procs)
        {
            //реализуем динамические приоритеты.
            //последнее вхождение легче всего запомнить
            Process procMax = null;
            if (procs == null)
            {
                MessageBox.Show("ПУСТОЙ СПИСОК");
            }
            foreach (Process proc in procs)
            {
                if (proc.Status == ProcessStatus.Active)
                {
                    MessageBox.Show("Есть Active при заходе в Scheduler");
                }
                if (proc.Status == ProcessStatus.Ready) //смотрим только те, кто Ready
                {
                    //выбрать с максимальным приоритетом и сделать его активным (вернуть)
                    if (procMax == null || proc.CurPrior > procMax.CurPrior)
                    {
                        procMax = proc;
                    }
                    proc.CurPrior++; //в любом случае прибавляем на следующий тик, что бы во время следующего уже было больше
                }
            }
            //Debug.WriteLine(procMax);
            if (procMax != null)
            {
                procMax.CurPrior = procMax.BasePrior; //Тому, кого выбрали, возвращаем базовый
                Debug.WriteLine("Зашли в присваивание Active");
                procMax.Status = ProcessStatus.Active;
            }
            return procMax; //и возвращаем этот как с максимальным приоритетом
            


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
