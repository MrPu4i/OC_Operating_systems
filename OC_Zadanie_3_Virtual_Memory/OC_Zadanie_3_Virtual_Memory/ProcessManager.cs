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

        // Управление памятью
        public RAM RAM { get; set; }
        public VirtualMemory VirtualMemory { get; set; }
        public bool VirtualMemoryInit { get; set; } = false;

        int id_next = 0;
        int i = 0;

        Random rnd = new Random();
        public ProcessManager()
        {
            Processes = new List<Process>();

            RAM = new RAM(3);
            VirtualMemory = null; //Пока она нам не нужна
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
            if (TryAllocateMemoryForProcess(proc))
            {
                Processes.Add(proc); //Добавляем процесс в список
            }
        }

        public void ProcessRemove(int index)
        {
            if (index >= 0 && index < Processes.Count)
            {
                var process = Processes[index];

                // Освобождаем память процесса
                if (process.IsInRAM())
                {
                    RAM.FreeMemory(process);
                }
                if (process.IsInVirtualMemory())
                {
                    VirtualMemory?.FreeVirtualMemory(process);
                }

                Processes.RemoveAt(index);
            }
        }
        public void VerifyForTerminated() //Удаляем зомби
        {
            for (int i = Processes.Count - 1; i >= 0; i--)
            {
                if (Processes[i].Status == ProcessStatus.Zombie)
                {
                    // Освобождаем память перед удалением
                    if (Processes[i].IsInRAM())
                    {
                        RAM.FreeMemory(Processes[i]);
                    }
                    if (Processes[i].IsInVirtualMemory())
                    {
                        VirtualMemory?.FreeVirtualMemory(Processes[i]);
                    }

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
                // проверить и удалить завершенные процессы;
                VerifyForTerminated();
                Debug.WriteLine("NextTime");
                ChangeWaiting();
                i = 0;
            }
            if (ActiveProcess != null)
            {
                ChangeActive();
            }

            // с помощью планировщика определить следующий активный процесс;
            ActiveProcess = Scheduler.GetNextActive(Processes); //Присваиваем новый Ready
            if (ActiveProcess != null) //null возвращает, когда нет Ready
            {
                EnsureProcessInRAM(ActiveProcess); // Убеждаемся, что активный процесс находится в оперативной памяти
                ActiveProcess.Go();
            }
        }

        private bool TryAllocateMemoryForProcess(Process process)   // Попытка выделить память для процесса
        {
            // Пытаемся выделить память в RAM
            var ramAddr = RAM.AllocateMemory(process);

            if (ramAddr == null) //Нет места в RAM
            {
                // Не удалось выделить в RAM - инициализируем виртуальную память если еще не сделали
                if (!VirtualMemoryInit)
                {
                    InitializeVirtualMemory();
                }
                // Если не удалось освободить место, выделяем в виртуальной памяти
                var virtualAddr = VirtualMemory.AllocateVirtualMemory(process);
                if (virtualAddr == null) //Нет места в Virt
                {
                    Debug.WriteLine($"CRITICAL: Cannot allocate memory for process {process.Name}");
                    return false;
                }
                else //Есть место в Virt
                {
                    Debug.WriteLine($"Process {process.Name} placed in virtual memory");
                    return true;
                }
            }
            else //Есть место в RAM
            {
                Debug.WriteLine($"Process {process.Name} placed in RAM");
                return true;
            }
        }

        private void InitializeVirtualMemory()  // Инициализация виртуальной памяти
        {
            VirtualMemory = new VirtualMemory(3); // 3 KB виртуальной памяти
            VirtualMemory.Init(RAM);
            VirtualMemoryInit = true;
            Debug.WriteLine("Virtual memory initialized");
        }

        // Попытка освободить место в RAM
        private bool TryFreeRAMSpace(int requiredMemory)
        {
            if (RAM.CanAllocate(requiredMemory)) return true;

            // Ищем неактивный процесс в RAM для вытеснения
            var candidate = Processes.FirstOrDefault(p =>
                p.Status != ProcessStatus.Active &&
                p.IsInRAM() &&
                !p.IsInVirtualMemory());

            if (candidate != null && VirtualMemory != null)
            {
                return VirtualMemory.SwapPage(candidate, RAM);
            }

            return false;
        }

        // Гарантирует, что процесс находится в оперативной памяти
        private void EnsureProcessInRAM(Process process)
        {
            if (!process.IsInRAM() && process.IsInVirtualMemory())
            {
                // Процесс в виртуальной памяти - нужно переместить в RAM
                if (RAM.CanAllocate(process.ProcMemory))
                {
                    // Есть место в RAM - просто перемещаем
                    VirtualMemory.SwapIn(process, RAM);
                }
                else
                {
                    // Нет места - вытесняем другой процесс
                    var candidate = Processes.FirstOrDefault(p =>
                        p != process &&
                        p.Status != ProcessStatus.Active &&
                        p.IsInRAM() &&
                        !p.IsInVirtualMemory());

                    if (candidate != null && VirtualMemory.SwapPage(candidate, RAM))
                    {
                        VirtualMemory.SwapIn(process, RAM);
                    }
                }
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
