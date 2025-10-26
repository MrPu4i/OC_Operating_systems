namespace OC_Zadanie_3_Virtual_Memory
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
            this.panel_time = new System.Windows.Forms.Panel();
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
            this.panel_prior = new System.Windows.Forms.Panel();
            this.label_cur_time = new System.Windows.Forms.Label();
            this.Ram_memory = new System.Windows.Forms.Label();
            this.Virt_memory = new System.Windows.Forms.Label();
            this.tb_ram = new System.Windows.Forms.TextBox();
            this.tb_virtual = new System.Windows.Forms.TextBox();
            this.lb_memory_cellz = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_ram_1 = new System.Windows.Forms.TextBox();
            this.tb_ram_2 = new System.Windows.Forms.TextBox();
            this.tb_ram_3 = new System.Windows.Forms.TextBox();
            this.tb_ram_4 = new System.Windows.Forms.TextBox();
            this.tb_ram_12 = new System.Windows.Forms.TextBox();
            this.tb_ram_11 = new System.Windows.Forms.TextBox();
            this.tb_ram_10 = new System.Windows.Forms.TextBox();
            this.tb_ram_9 = new System.Windows.Forms.TextBox();
            this.tb_ram_16 = new System.Windows.Forms.TextBox();
            this.tb_ram_15 = new System.Windows.Forms.TextBox();
            this.tb_ram_14 = new System.Windows.Forms.TextBox();
            this.tb_ram_13 = new System.Windows.Forms.TextBox();
            this.tb_vir_4 = new System.Windows.Forms.TextBox();
            this.tb_vir_3 = new System.Windows.Forms.TextBox();
            this.tb_vir_2 = new System.Windows.Forms.TextBox();
            this.tb_vir_1 = new System.Windows.Forms.TextBox();
            this.tb_vir_8 = new System.Windows.Forms.TextBox();
            this.tb_vir_7 = new System.Windows.Forms.TextBox();
            this.tb_vir_6 = new System.Windows.Forms.TextBox();
            this.tb_vir_5 = new System.Windows.Forms.TextBox();
            this.tb_vir_12 = new System.Windows.Forms.TextBox();
            this.tb_vir_11 = new System.Windows.Forms.TextBox();
            this.tb_vir_10 = new System.Windows.Forms.TextBox();
            this.tb_vir_9 = new System.Windows.Forms.TextBox();
            this.tb_vir_16 = new System.Windows.Forms.TextBox();
            this.tb_vir_15 = new System.Windows.Forms.TextBox();
            this.tb_vir_14 = new System.Windows.Forms.TextBox();
            this.tb_vir_13 = new System.Windows.Forms.TextBox();
            this.tb_ram_5 = new System.Windows.Forms.TextBox();
            this.tb_ram_6 = new System.Windows.Forms.TextBox();
            this.tb_ram_7 = new System.Windows.Forms.TextBox();
            this.tb_ram_8 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_remove
            // 
            this.but_remove.BackColor = System.Drawing.Color.DarkSlateGray;
            this.but_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.but_remove.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.but_remove.Location = new System.Drawing.Point(340, 394);
            this.but_remove.Margin = new System.Windows.Forms.Padding(2);
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
            this.but_start.Margin = new System.Windows.Forms.Padding(2);
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
            this.but_stop.Margin = new System.Windows.Forms.Padding(2);
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
            this.list_processes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.list_processes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.list_processes.FormattingEnabled = true;
            this.list_processes.Location = new System.Drawing.Point(309, 60);
            this.list_processes.Margin = new System.Windows.Forms.Padding(2);
            this.list_processes.Name = "list_processes";
            this.list_processes.Size = new System.Drawing.Size(306, 316);
            this.list_processes.TabIndex = 4;
            this.list_processes.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.list_processes_DrawItem);
            this.list_processes.SelectedIndexChanged += new System.EventHandler(this.list_processes_SelectedIndexChanged);
            // 
            // panel_time
            // 
            this.panel_time.Location = new System.Drawing.Point(628, 60);
            this.panel_time.Margin = new System.Windows.Forms.Padding(2);
            this.panel_time.Name = "panel_time";
            this.panel_time.Size = new System.Drawing.Size(140, 379);
            this.panel_time.TabIndex = 5;
            this.panel_time.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // tb_id
            // 
            this.tb_id.BackColor = System.Drawing.Color.White;
            this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tb_id.Location = new System.Drawing.Point(165, 18);
            this.tb_id.Margin = new System.Windows.Forms.Padding(2);
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
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Название процесса";
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.Color.White;
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tb_name.Location = new System.Drawing.Point(165, 54);
            this.tb_name.Margin = new System.Windows.Forms.Padding(2);
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
            this.tb_prior.Margin = new System.Windows.Forms.Padding(2);
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
            this.tb_timeResurs.Margin = new System.Windows.Forms.Padding(2);
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
            this.groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox.Size = new System.Drawing.Size(260, 189);
            this.groupBox.TabIndex = 14;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Новый процесс";
            // 
            // tb_green
            // 
            this.tb_green.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tb_green.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tb_green.Location = new System.Drawing.Point(418, 25);
            this.tb_green.Margin = new System.Windows.Forms.Padding(2);
            this.tb_green.Name = "tb_green";
            this.tb_green.Size = new System.Drawing.Size(29, 27);
            this.tb_green.TabIndex = 14;
            this.tb_green.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_red
            // 
            this.tb_red.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tb_red.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tb_red.Location = new System.Drawing.Point(471, 25);
            this.tb_red.Margin = new System.Windows.Forms.Padding(2);
            this.tb_red.Name = "tb_red";
            this.tb_red.Size = new System.Drawing.Size(29, 27);
            this.tb_red.TabIndex = 15;
            this.tb_red.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(74, 221);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "Создать новый процесс";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.but_new_proc_Click);
            // 
            // panel_prior
            // 
            this.panel_prior.Location = new System.Drawing.Point(787, 60);
            this.panel_prior.Margin = new System.Windows.Forms.Padding(2);
            this.panel_prior.Name = "panel_prior";
            this.panel_prior.Size = new System.Drawing.Size(213, 379);
            this.panel_prior.TabIndex = 6;
            this.panel_prior.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_prior_Paint);
            // 
            // label_cur_time
            // 
            this.label_cur_time.AutoSize = true;
            this.label_cur_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_cur_time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_cur_time.Location = new System.Drawing.Point(36, 394);
            this.label_cur_time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_cur_time.Name = "label_cur_time";
            this.label_cur_time.Size = new System.Drawing.Size(0, 20);
            this.label_cur_time.TabIndex = 17;
            // 
            // Ram_memory
            // 
            this.Ram_memory.AutoSize = true;
            this.Ram_memory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Ram_memory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ram_memory.Location = new System.Drawing.Point(75, 511);
            this.Ram_memory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Ram_memory.Name = "Ram_memory";
            this.Ram_memory.Size = new System.Drawing.Size(168, 40);
            this.Ram_memory.TabIndex = 14;
            this.Ram_memory.Text = "Информация\r\nоперативной памяти";
            this.Ram_memory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Virt_memory
            // 
            this.Virt_memory.AutoSize = true;
            this.Virt_memory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Virt_memory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Virt_memory.Location = new System.Drawing.Point(368, 511);
            this.Virt_memory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Virt_memory.Name = "Virt_memory";
            this.Virt_memory.Size = new System.Drawing.Size(167, 40);
            this.Virt_memory.TabIndex = 18;
            this.Virt_memory.Text = "Информация\r\nвиртуальной памяти\r\n";
            this.Virt_memory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_ram
            // 
            this.tb_ram.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tb_ram.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_ram.Location = new System.Drawing.Point(39, 567);
            this.tb_ram.Multiline = true;
            this.tb_ram.Name = "tb_ram";
            this.tb_ram.ReadOnly = true;
            this.tb_ram.Size = new System.Drawing.Size(241, 154);
            this.tb_ram.TabIndex = 19;
            // 
            // tb_virtual
            // 
            this.tb_virtual.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tb_virtual.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_virtual.Location = new System.Drawing.Point(340, 567);
            this.tb_virtual.Multiline = true;
            this.tb_virtual.Name = "tb_virtual";
            this.tb_virtual.ReadOnly = true;
            this.tb_virtual.Size = new System.Drawing.Size(241, 154);
            this.tb_virtual.TabIndex = 20;
            // 
            // lb_memory_cellz
            // 
            this.lb_memory_cellz.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lb_memory_cellz.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_memory_cellz.FormattingEnabled = true;
            this.lb_memory_cellz.Location = new System.Drawing.Point(658, 520);
            this.lb_memory_cellz.Name = "lb_memory_cellz";
            this.lb_memory_cellz.Size = new System.Drawing.Size(264, 277);
            this.lb_memory_cellz.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(1109, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Оперативная память";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(1111, 257);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Виртуальная память";
            // 
            // tb_ram_1
            // 
            this.tb_ram_1.Location = new System.Drawing.Point(1025, 68);
            this.tb_ram_1.Name = "tb_ram_1";
            this.tb_ram_1.Size = new System.Drawing.Size(72, 20);
            this.tb_ram_1.TabIndex = 25;
            this.tb_ram_1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_ram_2
            // 
            this.tb_ram_2.Location = new System.Drawing.Point(1113, 68);
            this.tb_ram_2.Name = "tb_ram_2";
            this.tb_ram_2.Size = new System.Drawing.Size(72, 20);
            this.tb_ram_2.TabIndex = 26;
            this.tb_ram_2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tb_ram_3
            // 
            this.tb_ram_3.Location = new System.Drawing.Point(1206, 68);
            this.tb_ram_3.Name = "tb_ram_3";
            this.tb_ram_3.Size = new System.Drawing.Size(72, 20);
            this.tb_ram_3.TabIndex = 27;
            this.tb_ram_3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tb_ram_4
            // 
            this.tb_ram_4.Location = new System.Drawing.Point(1296, 68);
            this.tb_ram_4.Name = "tb_ram_4";
            this.tb_ram_4.Size = new System.Drawing.Size(72, 20);
            this.tb_ram_4.TabIndex = 28;
            this.tb_ram_4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // tb_ram_12
            // 
            this.tb_ram_12.Location = new System.Drawing.Point(1298, 152);
            this.tb_ram_12.Name = "tb_ram_12";
            this.tb_ram_12.Size = new System.Drawing.Size(72, 20);
            this.tb_ram_12.TabIndex = 36;
            // 
            // tb_ram_11
            // 
            this.tb_ram_11.Location = new System.Drawing.Point(1208, 152);
            this.tb_ram_11.Name = "tb_ram_11";
            this.tb_ram_11.Size = new System.Drawing.Size(72, 20);
            this.tb_ram_11.TabIndex = 35;
            // 
            // tb_ram_10
            // 
            this.tb_ram_10.Location = new System.Drawing.Point(1115, 152);
            this.tb_ram_10.Name = "tb_ram_10";
            this.tb_ram_10.Size = new System.Drawing.Size(72, 20);
            this.tb_ram_10.TabIndex = 34;
            // 
            // tb_ram_9
            // 
            this.tb_ram_9.Location = new System.Drawing.Point(1027, 152);
            this.tb_ram_9.Name = "tb_ram_9";
            this.tb_ram_9.Size = new System.Drawing.Size(72, 20);
            this.tb_ram_9.TabIndex = 33;
            // 
            // tb_ram_16
            // 
            this.tb_ram_16.Location = new System.Drawing.Point(1298, 190);
            this.tb_ram_16.Name = "tb_ram_16";
            this.tb_ram_16.Size = new System.Drawing.Size(72, 20);
            this.tb_ram_16.TabIndex = 40;
            // 
            // tb_ram_15
            // 
            this.tb_ram_15.Location = new System.Drawing.Point(1208, 190);
            this.tb_ram_15.Name = "tb_ram_15";
            this.tb_ram_15.Size = new System.Drawing.Size(72, 20);
            this.tb_ram_15.TabIndex = 39;
            // 
            // tb_ram_14
            // 
            this.tb_ram_14.Location = new System.Drawing.Point(1115, 190);
            this.tb_ram_14.Name = "tb_ram_14";
            this.tb_ram_14.Size = new System.Drawing.Size(72, 20);
            this.tb_ram_14.TabIndex = 38;
            // 
            // tb_ram_13
            // 
            this.tb_ram_13.Location = new System.Drawing.Point(1027, 190);
            this.tb_ram_13.Name = "tb_ram_13";
            this.tb_ram_13.Size = new System.Drawing.Size(72, 20);
            this.tb_ram_13.TabIndex = 37;
            // 
            // tb_vir_4
            // 
            this.tb_vir_4.Location = new System.Drawing.Point(1296, 288);
            this.tb_vir_4.Name = "tb_vir_4";
            this.tb_vir_4.Size = new System.Drawing.Size(72, 20);
            this.tb_vir_4.TabIndex = 44;
            // 
            // tb_vir_3
            // 
            this.tb_vir_3.Location = new System.Drawing.Point(1206, 288);
            this.tb_vir_3.Name = "tb_vir_3";
            this.tb_vir_3.Size = new System.Drawing.Size(72, 20);
            this.tb_vir_3.TabIndex = 43;
            // 
            // tb_vir_2
            // 
            this.tb_vir_2.Location = new System.Drawing.Point(1113, 288);
            this.tb_vir_2.Name = "tb_vir_2";
            this.tb_vir_2.Size = new System.Drawing.Size(72, 20);
            this.tb_vir_2.TabIndex = 42;
            // 
            // tb_vir_1
            // 
            this.tb_vir_1.Location = new System.Drawing.Point(1025, 288);
            this.tb_vir_1.Name = "tb_vir_1";
            this.tb_vir_1.Size = new System.Drawing.Size(72, 20);
            this.tb_vir_1.TabIndex = 41;
            // 
            // tb_vir_8
            // 
            this.tb_vir_8.Location = new System.Drawing.Point(1296, 332);
            this.tb_vir_8.Name = "tb_vir_8";
            this.tb_vir_8.Size = new System.Drawing.Size(72, 20);
            this.tb_vir_8.TabIndex = 48;
            // 
            // tb_vir_7
            // 
            this.tb_vir_7.Location = new System.Drawing.Point(1206, 332);
            this.tb_vir_7.Name = "tb_vir_7";
            this.tb_vir_7.Size = new System.Drawing.Size(72, 20);
            this.tb_vir_7.TabIndex = 47;
            // 
            // tb_vir_6
            // 
            this.tb_vir_6.Location = new System.Drawing.Point(1113, 332);
            this.tb_vir_6.Name = "tb_vir_6";
            this.tb_vir_6.Size = new System.Drawing.Size(72, 20);
            this.tb_vir_6.TabIndex = 46;
            // 
            // tb_vir_5
            // 
            this.tb_vir_5.Location = new System.Drawing.Point(1025, 332);
            this.tb_vir_5.Name = "tb_vir_5";
            this.tb_vir_5.Size = new System.Drawing.Size(72, 20);
            this.tb_vir_5.TabIndex = 45;
            // 
            // tb_vir_12
            // 
            this.tb_vir_12.Location = new System.Drawing.Point(1296, 375);
            this.tb_vir_12.Name = "tb_vir_12";
            this.tb_vir_12.Size = new System.Drawing.Size(72, 20);
            this.tb_vir_12.TabIndex = 52;
            // 
            // tb_vir_11
            // 
            this.tb_vir_11.Location = new System.Drawing.Point(1206, 375);
            this.tb_vir_11.Name = "tb_vir_11";
            this.tb_vir_11.Size = new System.Drawing.Size(72, 20);
            this.tb_vir_11.TabIndex = 51;
            // 
            // tb_vir_10
            // 
            this.tb_vir_10.Location = new System.Drawing.Point(1113, 375);
            this.tb_vir_10.Name = "tb_vir_10";
            this.tb_vir_10.Size = new System.Drawing.Size(72, 20);
            this.tb_vir_10.TabIndex = 50;
            // 
            // tb_vir_9
            // 
            this.tb_vir_9.Location = new System.Drawing.Point(1025, 375);
            this.tb_vir_9.Name = "tb_vir_9";
            this.tb_vir_9.Size = new System.Drawing.Size(72, 20);
            this.tb_vir_9.TabIndex = 49;
            // 
            // tb_vir_16
            // 
            this.tb_vir_16.Location = new System.Drawing.Point(1296, 416);
            this.tb_vir_16.Name = "tb_vir_16";
            this.tb_vir_16.Size = new System.Drawing.Size(72, 20);
            this.tb_vir_16.TabIndex = 56;
            // 
            // tb_vir_15
            // 
            this.tb_vir_15.Location = new System.Drawing.Point(1206, 416);
            this.tb_vir_15.Name = "tb_vir_15";
            this.tb_vir_15.Size = new System.Drawing.Size(72, 20);
            this.tb_vir_15.TabIndex = 55;
            // 
            // tb_vir_14
            // 
            this.tb_vir_14.Location = new System.Drawing.Point(1113, 416);
            this.tb_vir_14.Name = "tb_vir_14";
            this.tb_vir_14.Size = new System.Drawing.Size(72, 20);
            this.tb_vir_14.TabIndex = 54;
            // 
            // tb_vir_13
            // 
            this.tb_vir_13.Location = new System.Drawing.Point(1025, 416);
            this.tb_vir_13.Name = "tb_vir_13";
            this.tb_vir_13.Size = new System.Drawing.Size(72, 20);
            this.tb_vir_13.TabIndex = 53;
            // 
            // tb_ram_5
            // 
            this.tb_ram_5.Location = new System.Drawing.Point(1025, 107);
            this.tb_ram_5.Name = "tb_ram_5";
            this.tb_ram_5.Size = new System.Drawing.Size(72, 20);
            this.tb_ram_5.TabIndex = 57;
            // 
            // tb_ram_6
            // 
            this.tb_ram_6.Location = new System.Drawing.Point(1113, 107);
            this.tb_ram_6.Name = "tb_ram_6";
            this.tb_ram_6.Size = new System.Drawing.Size(72, 20);
            this.tb_ram_6.TabIndex = 58;
            // 
            // tb_ram_7
            // 
            this.tb_ram_7.Location = new System.Drawing.Point(1206, 107);
            this.tb_ram_7.Name = "tb_ram_7";
            this.tb_ram_7.Size = new System.Drawing.Size(72, 20);
            this.tb_ram_7.TabIndex = 59;
            // 
            // tb_ram_8
            // 
            this.tb_ram_8.Location = new System.Drawing.Point(1296, 107);
            this.tb_ram_8.Name = "tb_ram_8";
            this.tb_ram_8.Size = new System.Drawing.Size(72, 20);
            this.tb_ram_8.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(721, 464);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 40);
            this.label7.TabIndex = 61;
            this.label7.Text = "Информация\r\nо ячейках памяти\r\n";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(625, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 16);
            this.label8.TabIndex = 62;
            this.label8.Text = "Процесс выполнения\r\n";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(801, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 16);
            this.label9.TabIndex = 63;
            this.label9.Text = "Динамические приоритеты\r\n";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1382, 830);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_ram_8);
            this.Controls.Add(this.tb_ram_7);
            this.Controls.Add(this.tb_ram_6);
            this.Controls.Add(this.tb_ram_5);
            this.Controls.Add(this.tb_vir_16);
            this.Controls.Add(this.tb_vir_15);
            this.Controls.Add(this.tb_vir_14);
            this.Controls.Add(this.tb_vir_13);
            this.Controls.Add(this.tb_vir_12);
            this.Controls.Add(this.tb_vir_11);
            this.Controls.Add(this.tb_vir_10);
            this.Controls.Add(this.tb_vir_9);
            this.Controls.Add(this.tb_vir_8);
            this.Controls.Add(this.tb_vir_7);
            this.Controls.Add(this.tb_vir_6);
            this.Controls.Add(this.tb_vir_5);
            this.Controls.Add(this.tb_vir_4);
            this.Controls.Add(this.tb_vir_3);
            this.Controls.Add(this.tb_vir_2);
            this.Controls.Add(this.tb_vir_1);
            this.Controls.Add(this.tb_ram_16);
            this.Controls.Add(this.tb_ram_15);
            this.Controls.Add(this.tb_ram_14);
            this.Controls.Add(this.tb_ram_13);
            this.Controls.Add(this.tb_ram_12);
            this.Controls.Add(this.tb_ram_11);
            this.Controls.Add(this.tb_ram_10);
            this.Controls.Add(this.tb_ram_9);
            this.Controls.Add(this.tb_ram_4);
            this.Controls.Add(this.tb_ram_3);
            this.Controls.Add(this.tb_ram_2);
            this.Controls.Add(this.tb_ram_1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_memory_cellz);
            this.Controls.Add(this.tb_virtual);
            this.Controls.Add(this.tb_ram);
            this.Controls.Add(this.Virt_memory);
            this.Controls.Add(this.Ram_memory);
            this.Controls.Add(this.label_cur_time);
            this.Controls.Add(this.panel_prior);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_red);
            this.Controls.Add(this.tb_green);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.panel_time);
            this.Controls.Add(this.list_processes);
            this.Controls.Add(this.but_stop);
            this.Controls.Add(this.but_start);
            this.Controls.Add(this.but_remove);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "S";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Panel panel_time;
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
        private System.Windows.Forms.Panel panel_prior;
        private System.Windows.Forms.Label label_cur_time;
        private System.Windows.Forms.Label Ram_memory;
        private System.Windows.Forms.Label Virt_memory;
        private System.Windows.Forms.TextBox tb_ram;
        private System.Windows.Forms.TextBox tb_virtual;
        private System.Windows.Forms.ListBox lb_memory_cellz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_ram_1;
        private System.Windows.Forms.TextBox tb_ram_2;
        private System.Windows.Forms.TextBox tb_ram_3;
        private System.Windows.Forms.TextBox tb_ram_4;
        private System.Windows.Forms.TextBox tb_ram_12;
        private System.Windows.Forms.TextBox tb_ram_11;
        private System.Windows.Forms.TextBox tb_ram_10;
        private System.Windows.Forms.TextBox tb_ram_9;
        private System.Windows.Forms.TextBox tb_ram_16;
        private System.Windows.Forms.TextBox tb_ram_15;
        private System.Windows.Forms.TextBox tb_ram_14;
        private System.Windows.Forms.TextBox tb_ram_13;
        private System.Windows.Forms.TextBox tb_vir_4;
        private System.Windows.Forms.TextBox tb_vir_3;
        private System.Windows.Forms.TextBox tb_vir_2;
        private System.Windows.Forms.TextBox tb_vir_1;
        private System.Windows.Forms.TextBox tb_vir_8;
        private System.Windows.Forms.TextBox tb_vir_7;
        private System.Windows.Forms.TextBox tb_vir_6;
        private System.Windows.Forms.TextBox tb_vir_5;
        private System.Windows.Forms.TextBox tb_vir_12;
        private System.Windows.Forms.TextBox tb_vir_11;
        private System.Windows.Forms.TextBox tb_vir_10;
        private System.Windows.Forms.TextBox tb_vir_9;
        private System.Windows.Forms.TextBox tb_vir_16;
        private System.Windows.Forms.TextBox tb_vir_15;
        private System.Windows.Forms.TextBox tb_vir_14;
        private System.Windows.Forms.TextBox tb_vir_13;
        private System.Windows.Forms.TextBox tb_ram_5;
        private System.Windows.Forms.TextBox tb_ram_6;
        private System.Windows.Forms.TextBox tb_ram_7;
        private System.Windows.Forms.TextBox tb_ram_8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

