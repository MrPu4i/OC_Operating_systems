namespace FileSystem
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
            this.CreateFile = new System.Windows.Forms.Button();
            this.CreateFolder = new System.Windows.Forms.Button();
            this.lbl_fullPath = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Return = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateFile
            // 
            this.CreateFile.Location = new System.Drawing.Point(953, 159);
            this.CreateFile.Name = "CreateFile";
            this.CreateFile.Size = new System.Drawing.Size(153, 64);
            this.CreateFile.TabIndex = 2;
            this.CreateFile.Text = "Создать файл";
            this.CreateFile.UseVisualStyleBackColor = true;
            this.CreateFile.Click += new System.EventHandler(this.CreateFile_Click);
            // 
            // CreateFolder
            // 
            this.CreateFolder.Location = new System.Drawing.Point(953, 240);
            this.CreateFolder.Name = "CreateFolder";
            this.CreateFolder.Size = new System.Drawing.Size(153, 64);
            this.CreateFolder.TabIndex = 3;
            this.CreateFolder.Text = "Создать папку";
            this.CreateFolder.UseVisualStyleBackColor = true;
            this.CreateFolder.Click += new System.EventHandler(this.CreateFolder_Click);
            // 
            // lbl_fullPath
            // 
            this.lbl_fullPath.AutoSize = true;
            this.lbl_fullPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_fullPath.Location = new System.Drawing.Point(7, 15);
            this.lbl_fullPath.Name = "lbl_fullPath";
            this.lbl_fullPath.Size = new System.Drawing.Size(21, 29);
            this.lbl_fullPath.TabIndex = 4;
            this.lbl_fullPath.Text = "-";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_fullPath);
            this.panel1.Location = new System.Drawing.Point(25, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1242, 57);
            this.panel1.TabIndex = 5;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(25, 157);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(922, 492);
            this.listView.TabIndex = 6;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Имя";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Дата создания";
            this.columnHeader2.Width = 181;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 3;
            this.columnHeader3.Text = "Размер";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 2;
            this.columnHeader4.Text = "Тип";
            this.columnHeader4.Width = 126;
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(25, 87);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(153, 64);
            this.Return.TabIndex = 7;
            this.Return.Text = "Вернуться";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 674);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.CreateFolder);
            this.Controls.Add(this.CreateFile);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CreateFile;
        private System.Windows.Forms.Button CreateFolder;
        private System.Windows.Forms.Label lbl_fullPath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button Return;
    }
}

