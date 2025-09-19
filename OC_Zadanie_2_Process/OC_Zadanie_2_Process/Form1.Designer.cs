namespace OC_Zadanie_2_Process
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
            this.components = new System.ComponentModel.Container();
            this.but_remove = new System.Windows.Forms.Button();
            this.but_start = new System.Windows.Forms.Button();
            this.but_stop = new System.Windows.Forms.Button();
            this.list_processes = new System.Windows.Forms.ListBox();
            this.panel = new System.Windows.Forms.Panel();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_prior = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_timeResurs = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.tb_green = new System.Windows.Forms.TextBox();
            this.tb_red = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_remove
            // 
            this.but_remove.BackColor = System.Drawing.Color.DarkSlateGray;
            this.but_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.but_remove.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.but_remove.Location = new System.Drawing.Point(309, 394);
            this.but_remove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.but_remove.Name = "but_remove";
            this.but_remove.Size = new System.Drawing.Size(225, 51);
            this.but_remove.TabIndex = 1;
            this.but_remove.Text = "Удалить выделенный процесс";
            this.but_remove.UseVisualStyleBackColor = false;
            this.but_remove.Click += new System.EventHandler(this.but_remove_Click);
            // 
            // but_start
            // 
            this.but_start.BackColor = System.Drawing.Color.DarkSlateGray;
            this.but_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.but_start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.but_start.Location = new System.Drawing.Point(62, 309);
            this.but_start.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.but_start.Name = "but_start";
            this.but_start.Size = new System.Drawing.Size(163, 37);
            this.but_start.TabIndex = 2;
            this.but_start.Text = "Запуск!";
            this.but_start.UseVisualStyleBackColor = false;
            this.but_start.Click += new System.EventHandler(this.but_start_Click);
            // 
            // but_stop
            // 
            this.but_stop.BackColor = System.Drawing.Color.DarkSlateGray;
            this.but_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.but_stop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.but_stop.Location = new System.Drawing.Point(62, 350);
            this.but_stop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.but_stop.Name = "but_stop";
            this.but_stop.Size = new System.Drawing.Size(163, 38);
            this.but_stop.TabIndex = 3;
            this.but_stop.Text = "Стоп.";
            this.but_stop.UseVisualStyleBackColor = false;
            this.but_stop.Click += new System.EventHandler(this.but_stop_Click);
            // 
            // list_processes
            // 
            this.list_processes.BackColor = System.Drawing.Color.DarkSlateGray;
            this.list_processes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.list_processes.FormattingEnabled = true;
            this.list_processes.Location = new System.Drawing.Point(309, 60);
            this.list_processes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.list_processes.Name = "list_processes";
            this.list_processes.Size = new System.Drawing.Size(227, 329);
            this.list_processes.TabIndex = 4;
            this.list_processes.SelectedIndexChanged += new System.EventHandler(this.list_processes_SelectedIndexChanged);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(550, 60);
            this.panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(332, 379);
            this.panel.TabIndex = 5;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // tb_id
            // 
            this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tb_id.Location = new System.Drawing.Point(165, 18);
            this.tb_id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(83, 27);
            this.tb_id.TabIndex = 6;
            this.tb_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID процесса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Название процесса";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tb_name.Location = new System.Drawing.Point(165, 54);
            this.tb_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(83, 27);
            this.tb_name.TabIndex = 8;
            this.tb_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(9, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Начальный приоритет";
            // 
            // tb_prior
            // 
            this.tb_prior.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tb_prior.Location = new System.Drawing.Point(165, 92);
            this.tb_prior.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_prior.Name = "tb_prior";
            this.tb_prior.Size = new System.Drawing.Size(83, 27);
            this.tb_prior.TabIndex = 10;
            this.tb_prior.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(9, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Время исполнения";
            // 
            // tb_timeResurs
            // 
            this.tb_timeResurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tb_timeResurs.Location = new System.Drawing.Point(165, 131);
            this.tb_timeResurs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_timeResurs.Name = "tb_timeResurs";
            this.tb_timeResurs.Size = new System.Drawing.Size(83, 27);
            this.tb_timeResurs.TabIndex = 12;
            this.tb_timeResurs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.tb_timeResurs);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.tb_prior);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.tb_name);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.tb_id);
            this.groupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox.Location = new System.Drawing.Point(27, 53);
            this.groupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox.Size = new System.Drawing.Size(260, 189);
            this.groupBox.TabIndex = 14;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Новый процесс";
            // 
            // tb_green
            // 
            this.tb_green.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tb_green.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tb_green.Location = new System.Drawing.Point(376, 25);
            this.tb_green.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_green.Name = "tb_green";
            this.tb_green.Size = new System.Drawing.Size(29, 27);
            this.tb_green.TabIndex = 14;
            this.tb_green.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_red
            // 
            this.tb_red.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tb_red.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tb_red.Location = new System.Drawing.Point(429, 25);
            this.tb_red.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_red.Name = "tb_red";
            this.tb_red.Size = new System.Drawing.Size(29, 27);
            this.tb_red.TabIndex = 15;
            this.tb_red.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(74, 221);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "Создать новый процесс";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.but_new_proc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(915, 493);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_red);
            this.Controls.Add(this.tb_green);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.list_processes);
            this.Controls.Add(this.but_stop);
            this.Controls.Add(this.but_start);
            this.Controls.Add(this.but_remove);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "S";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button but_remove;
        private System.Windows.Forms.Button but_start;
        private System.Windows.Forms.Button but_stop;
        private System.Windows.Forms.ListBox list_processes;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_prior;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_timeResurs;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox tb_green;
        private System.Windows.Forms.TextBox tb_red;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button button1;
    }
}

