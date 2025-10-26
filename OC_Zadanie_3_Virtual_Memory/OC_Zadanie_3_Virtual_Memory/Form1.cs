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
        public Form1()
        {
            InitializeComponent();
            list_processes.SelectedIndexChanged += list_processes_SelectedIndexChanged;
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
            Debug.WriteLine("tick");
            if (procManager.Processes.Count == 0)
            {
                Stop();
            }
            procManager.NextTime();
            Debug.WriteLine(procManager.Processes.Count);
            ShowListProcesses();

        }
        private void ShowListProcesses()
        {
            list_processes.Items.Clear();
            foreach (Process proc in procManager.Processes)
            {
                list_processes.Items.Add(proc);
            }
            panel_time.Invalidate();
            panel_prior.Invalidate();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Debug.WriteLine("Зашли в panel Paint");
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
            Debug.WriteLine("Зашли в prior Paint");
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
                    $" Приоритеты: {proc.BasePrior} | {proc.CurPrior}";
                e.Graphics.DrawString(displayText, e.Font, textBrush, e.Bounds, StringFormat.GenericDefault);
            }

            // Рисуем рамку фокуса
            e.DrawFocusRectangle();
        }
    }
}
