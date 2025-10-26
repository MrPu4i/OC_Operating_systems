using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OC_Zadanie_3_Virtual_Memory.Process;

namespace OC_Zadanie_3_Virtual_Memory
{
    public partial class Form1 : Form
    {
        ProcessManager procManager = new ProcessManager(); //создаём один экземпляр 
        private const int pixels_per_tick = 10;

        // Массивы для визуализации памяти
        private TextBox[] ramCells;
        private TextBox[] virtualMemoryCells;

        private List<Process> processesInRAM;
        private List<Process> processesInVirtual;
        private const int MEMORY_CELLS_COUNT = 16; // по 16 ячеек каждой памяти

        public Form1()
        {
            InitializeComponent();
            list_processes.SelectedIndexChanged += list_processes_SelectedIndexChanged;
            InitMemoryCells();
        }

        public void InitMemoryCells()
        {
            ramCells = new TextBox[MEMORY_CELLS_COUNT]; //Пустой
            for (int i = 0; i < MEMORY_CELLS_COUNT; i++)
            {
                string controlName = $"tb_ram_{i+1}";
                var control = this.Controls.Find(controlName, true).FirstOrDefault() as TextBox;
                if (control != null) //Нашли этот textbox по названию
                {
                    ramCells[i] = control;
                    ramCells[i].Text = "FREE";
                    ramCells[i].BackColor = Color.LightGreen;
                }
            }

            virtualMemoryCells = new TextBox[MEMORY_CELLS_COUNT];
            for (int i = 0; i < MEMORY_CELLS_COUNT; i++)
            {
                string controlName = $"tb_vir_{i+1}";
                var control = this.Controls.Find(controlName, true).FirstOrDefault() as TextBox;
                if (control != null)
                {
                    virtualMemoryCells[i] = control;
                    virtualMemoryCells[i].Text = "FREE";
                    virtualMemoryCells[i].BackColor = Color.LightBlue;
                }
            }
        }
        private void UpdateMemoryCellsVisualization()
        {
            // Очищаем все ячейки
            for (int i = 0; i < MEMORY_CELLS_COUNT; i++)
            {
                if (ramCells[i] != null)
                {
                    ramCells[i].Text = "FREE";
                    ramCells[i].BackColor = Color.LightGreen;
                }
                if (virtualMemoryCells[i] != null)
                {
                    virtualMemoryCells[i].Text = "FREE";
                    virtualMemoryCells[i].BackColor = Color.LightBlue;
                }
            }

            // Заполняем ячейки RAM
            for (int i = 0; i < processesInRAM.Count && i < MEMORY_CELLS_COUNT; i++)
            {
                if (ramCells[i] != null)
                {
                    var process = processesInRAM[i];
                    ramCells[i].Text = process.Name;
                    ramCells[i].BackColor = Color.Green;

                    // Цвет в зависимости от статуса
                    switch (process.Status)
                    {
                        case Process.ProcessStatus.Active:
                            ramCells[i].BackColor = Color.Gold;
                            break;
                        case Process.ProcessStatus.Ready:
                            ramCells[i].BackColor = Color.Green;
                            break;
                        case Process.ProcessStatus.Waiting:
                            ramCells[i].BackColor = Color.LightYellow;
                            break;
                    }
                }
            }

            if (processesInVirtual != null)
            {
                // Заполняем ячейки Virt
                for (int i = 0; i < processesInVirtual.Count && i < MEMORY_CELLS_COUNT; i++)
                {
                    if (virtualMemoryCells[i] != null)
                    {
                        var process = processesInVirtual[i];
                        virtualMemoryCells[i].Text = process.Name;
                        virtualMemoryCells[i].BackColor = Color.Blue;

                        // Цвет в зависимости от статуса
                        switch (process.Status)
                        {
                            case Process.ProcessStatus.Ready:
                                virtualMemoryCells[i].BackColor = Color.Blue;
                                break;
                            case Process.ProcessStatus.Waiting:
                                virtualMemoryCells[i].BackColor = Color.LightSteelBlue;
                                break;
                        }
                    }
                }
            }
        }
        private void but_new_proc_Click(object sender, EventArgs e)
        {
            //Новый процесс
            procManager.ProcessAdd(tb_id.Text, tb_name.Text/*, Convert.ToInt32(tb_prior.Text), Convert.ToInt32(tb_timeResurs.Text)*/);
            ShowListProcesses();
        }
        private void but_remove_Click(object sender, EventArgs e)
        {
            procManager.ProcessRemove(list_processes.SelectedIndex);
            ShowListProcesses();
        }
        private void but_start_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void Start()
        {
            tb_green.BackColor = Color.Green;
            tb_red.BackColor = Color.DarkSlateGray;

            but_remove.Enabled = false; //Выключаем кнопку удаления процессов
            but_remove.ForeColor = Color.Gray;

            //включаем таймер
            timer.Enabled = true;

            label_cur_time.Text = "";
        }

        private void but_stop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void Stop()
        {
            tb_red.BackColor = Color.Red;
            tb_green.BackColor = Color.DarkSlateGray;
            
            but_remove.Enabled = true; //Включаем кнопку удаления процессов
            but_remove.ForeColor = Color.White;

            //останавливаем таймер
            timer.Enabled = false;

            label_cur_time.Text = $"Затраченное время: {procManager.CurrentTime} тиков";
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            /*Debug.WriteLine("tick");*/
            if (procManager.Processes.Count == 0)
            {
                Stop();
            }
            procManager.NextTime();
            /*Debug.WriteLine(procManager.Processes.Count);*/
            ShowListProcesses();

        }
        private void ShowListProcesses()
        {
            list_processes.Items.Clear();
            foreach (Process proc in procManager.Processes)
            {
                list_processes.Items.Add(proc);
            }

            UpdateMemoryInfo();
            UpdateMemoryCellsDisplay();
            UpdateMemoryCellsVisualization();
            panel_time.Invalidate();
            panel_prior.Invalidate();
        }
        private void UpdateMemoryInfo()
        {
            UpdateRAMInfo();
            UpdateVirtualMemoryInfo();
            UpdateSelectedProcessMemoryInfo();
        }
        private void UpdateRAMInfo()
        {
            if (procManager.RAM != null)
            {
                int freePages = procManager.RAM.GetFreePages();
                int totalPages = procManager.RAM.RAMMemoryCells.Length;
                int usedPages = totalPages - freePages;
                double usagePercent = (double)usedPages / totalPages * 100;

                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Всего: {totalPages} страниц");
                sb.AppendLine($"Занято: {usedPages} страниц | {usagePercent:F1}%");
                sb.AppendLine($"Свободно: {freePages} страниц");
                sb.AppendLine($"Размер страницы: {RAM.PageSize} байт");

                // Информация о процессах в RAM
                processesInRAM = procManager.Processes.Where(p => p.IsInRAM()).ToList();
                sb.AppendLine($"Процессы в оперативной памяти: {processesInRAM.Count}");

                tb_ram.Text = sb.ToString();
            }
        }
        private void UpdateVirtualMemoryInfo()
        {
            if (procManager.VirtualMemory != null)
            {
                int usedPages = procManager.VirtualMemory.VirtualMemoryCells.Count(cell => cell != null);
                int totalPages = procManager.VirtualMemory.VirtualMemoryCells.Length;
                double usagePercent = totalPages > 0 ? (double)usedPages / totalPages * 100 : 0;

                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Всего: {totalPages} страниц");
                sb.AppendLine($"Занято: {usedPages} страниц | {usagePercent:F1}%");
                sb.AppendLine($"Свободно: {totalPages - usedPages} страниц");
                sb.AppendLine($"Инициализирован: ДА");

                // Информация о процессах в виртуальной памяти
                processesInVirtual = procManager.Processes.Where(p => p.IsInVirtualMemory()).ToList();
                sb.AppendLine($"Процессы в виртуальной памяти: {processesInVirtual.Count}");

                tb_virtual.Text = sb.ToString();
            }
            else
            {
                tb_virtual.Text = "Виртуальная память: Не инициализирована\n(Появится, когда оперативная память переполнится)";
            }
        }
        private string GetMemoryStatus(Process proc) // Получить статус памяти процесса
        {
            if (proc.Status == Process.ProcessStatus.Zombie) return "[ZOMBIE]";
            if (proc.IsInRAM()) return $"[RAM:0x{proc.RAMAddress:X}]";
            if (proc.IsInVirtualMemory()) return $"[VIRT:0x{proc.VirtualMemoryAddress:X}]";
            return "[NO MEM]";
        }
        private void UpdateSelectedProcessMemoryInfo()
        {
            if (list_processes.SelectedIndex >= 0 && list_processes.SelectedIndex < procManager.Processes.Count)
            {
                var proc = procManager.Processes[list_processes.SelectedIndex];

                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Процесс: {proc.Name}");
                sb.AppendLine($"Память: {proc.ProcMemory} байт");
                sb.AppendLine($"Страниц надо: {(int)Math.Ceiling((double)proc.ProcMemory / RAM.PageSize)}");

                if (proc.IsInRAM())
                {
                    sb.AppendLine($"Нахождение: RAM");
                    sb.AppendLine($"Адресс: 0x{proc.RAMAddress:X}");
                }
                else if (proc.IsInVirtualMemory())
                {
                    sb.AppendLine($"Нахождение: Virtual Memory");
                    sb.AppendLine($"Вдресс: 0x{proc.VirtualMemoryAddress:X}");
                }
                else
                {
                    sb.AppendLine($"Нахождение: No Memory");
                }

                sb.AppendLine($"Статус: {proc.Status}");

                //tb_process_memory.Text = sb.ToString();
            }
            else
            {
                //tb_process_memory.Text = "Выберите процесс, для отображение информации памяти";
            }
        }
        private void UpdateMemoryCellsDisplay()
        {
            lb_memory_cellz.Items.Clear();

            // Показываем первые 100 ячеек RAM для наглядности
            if (procManager.RAM != null)
            {
                lb_memory_cellz.Items.Add("=== Оперативная память ===");
                int displayCount = Math.Min(100, procManager.RAM.RAMMemoryCells.Length);

                for (int i = 0; i < displayCount; i++)
                {
                    string processName = procManager.RAM.RAMMemoryCells[i]?.Name ?? "FREE";
                    string cellInfo = $"Addr 0x{i:X}: {processName}";
                    lb_memory_cellz.Items.Add(cellInfo);
                }

                // Если есть виртуальная память, показываем и её
                if (procManager.VirtualMemory != null)
                {
                    lb_memory_cellz.Items.Add("");
                    lb_memory_cellz.Items.Add("=== Виртуальная память ===");

                    int virtualDisplayCount = Math.Min(50, procManager.VirtualMemory.VirtualMemoryCells.Length);
                    int virtualUsedCount = 0;

                    for (int i = 0; i < virtualDisplayCount && virtualUsedCount < 20; i++)
                    {
                        if (procManager.VirtualMemory.VirtualMemoryCells[i] != null)
                        {
                            string processName = procManager.VirtualMemory.VirtualMemoryCells[i].Name;
                            string cellInfo = $"Addr 0x{i:X}: {processName}";
                            lb_memory_cellz.Items.Add(cellInfo);
                            virtualUsedCount++;
                        }
                    }
                }
            }
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            /*Debug.WriteLine("Зашли в panel Paint");*/
            var g = e.Graphics;
            g.Clear(panel_time.BackColor); //очищаем панель

            int itemHeight = list_processes.ItemHeight; //высота итема в listbox
            int visibleItems = list_processes.Height / itemHeight;

            for (int i = 0; i < Math.Min(procManager.Processes.Count, visibleItems); i++)
            {
                var process = procManager.Processes[i];

                if (process.Status != ProcessStatus.Zombie)
                {
                    int y = i * itemHeight + 2;
                    DrawProcessBar(g, process, y);
                }
            }
        }

        private void DrawProcessBar(Graphics g, Process process, int y)
        {
            int maxWidth = panel_time.Width - 20;
            int totalWidth = process.TimeResurs * pixels_per_tick;
            int currentWidth = process.TimeUsed * pixels_per_tick;

            // Рисуем фон (полную длину процесса)
            Rectangle totalRect = new Rectangle(10, y + 5, totalWidth, 8);
            using (var brush = new SolidBrush(Color.LightGray))
            {
                g.FillRectangle(brush, totalRect);
                g.DrawRectangle(Pens.DarkGray, totalRect);
            }

            // Рисуем текущий прогресс
            if (currentWidth > 0)
            {
                Rectangle currentRect = new Rectangle(10, y + 5, currentWidth, 8);
                Color progressColor = process.Status == ProcessStatus.Active ?
                    Color.Green : Color.Blue;

                using (var brush = new SolidBrush(progressColor))
                {
                    g.FillRectangle(brush, currentRect);
                    //Debug.WriteLine("Draw rectangle");
                }
            }
        }

        private void panel_prior_Paint(object sender, PaintEventArgs e)
        {
            /*Debug.WriteLine("Зашли в prior Paint");*/
            var g = e.Graphics;
            g.Clear(panel_prior.BackColor); //очищаем панель

            int itemHeight = list_processes.ItemHeight; //высота итема в listbox
            int visibleItems = list_processes.Height / itemHeight;

            for (int i = 0; i < Math.Min(procManager.Processes.Count, visibleItems); i++) //идём по всем кого видим
            {
                var process = procManager.Processes[i];

                if (process.Status != ProcessStatus.Zombie) //что б те, которые зомби не было видно
                {
                    int y = i * itemHeight + 5;
                    DrawPriorBar(g, process, y);
                }
            }
        }

        private void DrawPriorBar(Graphics g, Process process, int y)
        {
            int maxWidth = panel_prior.Width - 20;
            int totalWidth = process.BasePrior * pixels_per_tick;
            int currentWidth = process.CurPrior * pixels_per_tick;

            // Рисуем фон (полную величину приоритета)
            Rectangle totalRect = new Rectangle(10, y + 5, totalWidth, 8);
            using (var brush = new SolidBrush(Color.PaleGoldenrod)) //его базовый (не меняется)
            {
                g.FillRectangle(brush, totalRect);
            }

            if (currentWidth > 0)
            {
                Rectangle currentRect = new Rectangle(10, y + 5, currentWidth, 4);

                using (var brush = new SolidBrush(Color.LightSeaGreen)) //Цвет текущего приоритета //HotPink
                {
                    g.FillRectangle(brush, currentRect);
                    //Debug.WriteLine("Draw rectangle");
                }
            }
        }

        private void list_processes_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel_time.Invalidate();
            panel_prior.Invalidate();
            UpdateSelectedProcessMemoryInfo(); // ОБНОВЛЯЕМ ИНФОРМАЦИЮ О ВЫБРАННОМ ПРОЦЕССЕ
        }

        private void list_processes_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= list_processes.Items.Count)
                return;

            // Получаем процесс из ListBox
            var proc = list_processes.Items[e.Index] as Process;
            if (proc == null)
                return;

            // Определяем цвет в зависимости от статуса
            Color textColor;
            switch (proc.Status)
            {
                case ProcessStatus.Active:
                    textColor = Color.LightGreen;
                    break;
                case ProcessStatus.Zombie:
                    textColor = Color.LightCoral;
                    break;
                case ProcessStatus.Ready:
                    textColor = Color.NavajoWhite;
                    break;
                case ProcessStatus.Waiting:
                    textColor = Color.DarkTurquoise;
                    break;
                default:
                    textColor = Color.Transparent;
                    break;
            }
            // Рисуем фон
            e.DrawBackground();

            // Рисуем текст выбранным цветом
            using (Brush textBrush = new SolidBrush(textColor))
            {
                string displayText = $"{proc.Name}: {proc.Status} [ {proc.TimeResurs} | {proc.TimeUsed} ]" +
                    $" Приоритеты: {proc.BasePrior} | {proc.CurPrior} Память: {proc.ProcMemory} байт";
                e.Graphics.DrawString(displayText, e.Font, textBrush, e.Bounds, StringFormat.GenericDefault);
            }

            // Рисуем рамку фокуса
            e.DrawFocusRectangle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
