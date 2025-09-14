namespace OC_Zadanie_1_List
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.listBox = new System.Windows.Forms.ListBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Список = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.but_Add = new System.Windows.Forms.Button();
            this.but_DeleteFirst = new System.Windows.Forms.Button();
            this.but_DeleteAt = new System.Windows.Forms.Button();
            this.but_Clear = new System.Windows.Forms.Button();
            this.but_Sort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.LightYellow;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(292, 111);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(247, 342);
            this.listBox.TabIndex = 0;
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.LightYellow;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(576, 111);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(354, 342);
            this.chart.TabIndex = 1;
            this.chart.Text = "chart1";
            // 
            // Список
            // 
            this.Список.AutoSize = true;
            this.Список.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Список.Location = new System.Drawing.Point(375, 72);
            this.Список.Name = "Список";
            this.Список.Size = new System.Drawing.Size(78, 25);
            this.Список.TabIndex = 2;
            this.Список.Text = "Список";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(685, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Графа";
            // 
            // but_Add
            // 
            this.but_Add.BackColor = System.Drawing.Color.LightYellow;
            this.but_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.but_Add.Location = new System.Drawing.Point(58, 111);
            this.but_Add.Name = "but_Add";
            this.but_Add.Size = new System.Drawing.Size(137, 54);
            this.but_Add.TabIndex = 4;
            this.but_Add.Text = "Добавить элемент";
            this.but_Add.UseVisualStyleBackColor = false;
            this.but_Add.Click += new System.EventHandler(this.but_Add_Click);
            // 
            // but_DeleteFirst
            // 
            this.but_DeleteFirst.BackColor = System.Drawing.Color.LightYellow;
            this.but_DeleteFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.but_DeleteFirst.Location = new System.Drawing.Point(58, 171);
            this.but_DeleteFirst.Name = "but_DeleteFirst";
            this.but_DeleteFirst.Size = new System.Drawing.Size(137, 72);
            this.but_DeleteFirst.TabIndex = 5;
            this.but_DeleteFirst.Text = "Удалить первый элемент";
            this.but_DeleteFirst.UseVisualStyleBackColor = false;
            this.but_DeleteFirst.Click += new System.EventHandler(this.but_DeleteFirst_Click);
            // 
            // but_DeleteAt
            // 
            this.but_DeleteAt.BackColor = System.Drawing.Color.LightYellow;
            this.but_DeleteAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.but_DeleteAt.Location = new System.Drawing.Point(58, 249);
            this.but_DeleteAt.Name = "but_DeleteAt";
            this.but_DeleteAt.Size = new System.Drawing.Size(137, 66);
            this.but_DeleteAt.TabIndex = 6;
            this.but_DeleteAt.Text = "Удалить выбранный элемент";
            this.but_DeleteAt.UseVisualStyleBackColor = false;
            this.but_DeleteAt.Click += new System.EventHandler(this.but_DeleteAt_Click);
            // 
            // but_Clear
            // 
            this.but_Clear.BackColor = System.Drawing.Color.LightYellow;
            this.but_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.but_Clear.Location = new System.Drawing.Point(58, 321);
            this.but_Clear.Name = "but_Clear";
            this.but_Clear.Size = new System.Drawing.Size(137, 72);
            this.but_Clear.TabIndex = 7;
            this.but_Clear.Text = "Очистить список";
            this.but_Clear.UseVisualStyleBackColor = false;
            this.but_Clear.Click += new System.EventHandler(this.but_Clear_Click);
            // 
            // but_Sort
            // 
            this.but_Sort.BackColor = System.Drawing.Color.LightYellow;
            this.but_Sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.but_Sort.Location = new System.Drawing.Point(58, 399);
            this.but_Sort.Name = "but_Sort";
            this.but_Sort.Size = new System.Drawing.Size(137, 54);
            this.but_Sort.TabIndex = 8;
            this.but_Sort.Text = "Отсортировать";
            this.but_Sort.UseVisualStyleBackColor = false;
            this.but_Sort.Click += new System.EventHandler(this.but_Sort_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(84, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Кнопки";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1007, 586);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.but_Sort);
            this.Controls.Add(this.but_Clear);
            this.Controls.Add(this.but_DeleteAt);
            this.Controls.Add(this.but_DeleteFirst);
            this.Controls.Add(this.but_Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Список);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label Список;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_Add;
        private System.Windows.Forms.Button but_DeleteFirst;
        private System.Windows.Forms.Button but_DeleteAt;
        private System.Windows.Forms.Button but_Clear;
        private System.Windows.Forms.Button but_Sort;
        private System.Windows.Forms.Label label2;
    }
}

