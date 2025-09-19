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

namespace OC_Zadanie_2_Process
{
    public partial class Form1 : Form
    {
        ProcessManager procManager = new ProcessManager(); //создаём один экземпляр 
        public Form1()
        {
            InitializeComponent();
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
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine("tick");
            if (procManager.Processes.Count == 0)
            {
                Stop();
            }
            procManager.NextTime();
            ShowListProcesses();

        }
        private void ShowListProcesses()
        {
            list_processes.Items.Clear();
            foreach (Process proc in procManager.Processes)
            {
                list_processes.Items.Add($"{proc.Name} | {proc.Status} | {proc.TimeResurs} | {proc.TimeUsed}");
            }
        }
    }
}
