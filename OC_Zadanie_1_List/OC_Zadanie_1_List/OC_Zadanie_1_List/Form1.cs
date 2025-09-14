using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace OC_Zadanie_1_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShowChart();
        }

        MyList myList = new MyList();

        private void but_Add_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            myList.AddNum(random.Next(-100, 100));
            ShowList();
            ShowChart();
        }

        private void but_DeleteFirst_Click(object sender, EventArgs e)
        {
            //Проверить не пустой ли список
            myList.DeleteFirst();
            ShowList();
            ShowChart();
        }

        private void but_DeleteAt_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                myList.DeleteAt(listBox.SelectedIndex);
                ShowList();
                ShowChart();
            }
            else { MessageBox.Show("Выберите элемент из списка!"); }
        }

        private void but_Clear_Click(object sender, EventArgs e)
        {
            myList.ClearList();
            ShowList();
            ShowChart();
        }

        private void but_Sort_Click(object sender, EventArgs e)
        {
            myList.SortList();
            ShowList();
            ShowChart();
        }
        private void ShowList()
        {
            listBox.Items.Clear(); //очищяем всё
            foreach (var item in myList.GetList())
            {
                listBox.Items.Add(item);
            }
        }

        private void ShowChart()
        {
            //очищаем всё на нём
            chart.Series.Clear();
            chart.ChartAreas.Clear();

            //добавляем область отрисовки
            ChartArea chartArea = new ChartArea();
            chartArea.BackColor = Color.LightYellow;
            chart.ChartAreas.Add(chartArea);

            //создаём серию данных
            Series series = new Series();
            series.ChartType = SeriesChartType.Bar; // Тип графика
            series.Color = Color.Olive; // Все столбцы красные
            series.BorderColor = Color.DarkOliveGreen; // Цвет границы
            series.BorderWidth = 2;
            series.Name = "Элементы списка";

            //добавляем элементы списка в серию
            for (int i = 0; i < myList.GetList().Count; i++)
            {
                series.Points.AddXY(i + 1, myList.GetList()[i]);
            }

            //добавляем серию на график
            chart.Series.Add(series);

            //форматирование
            chart.Titles.Clear();
            chart.Titles.Add("Графа");
        }
    }
}
