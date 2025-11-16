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
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.btnCreateFolder = new System.Windows.Forms.Button();
            this.lbl_fullPath = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnMoveStart = new System.Windows.Forms.Button();
            this.btnUnSort = new System.Windows.Forms.Button();
            this.btnMoveEnd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(635, 103);
            this.btnCreateFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(102, 42);
            this.btnCreateFile.TabIndex = 2;
            this.btnCreateFile.Text = "Создать файл";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.Location = new System.Drawing.Point(635, 156);
            this.btnCreateFolder.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(102, 42);
            this.btnCreateFolder.TabIndex = 3;
            this.btnCreateFolder.Text = "Создать папку";
            this.btnCreateFolder.UseVisualStyleBackColor = true;
            this.btnCreateFolder.Click += new System.EventHandler(this.btnCreateFolder_Click);
            // 
            // lbl_fullPath
            // 
            this.lbl_fullPath.AutoSize = true;
            this.lbl_fullPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_fullPath.Location = new System.Drawing.Point(5, 10);
            this.lbl_fullPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_fullPath.Name = "lbl_fullPath";
            this.lbl_fullPath.Size = new System.Drawing.Size(14, 20);
            this.lbl_fullPath.TabIndex = 4;
            this.lbl_fullPath.Text = "-";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_fullPath);
            this.panel1.Location = new System.Drawing.Point(17, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 37);
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
            this.listView.Location = new System.Drawing.Point(17, 102);
            this.listView.Margin = new System.Windows.Forms.Padding(2);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(616, 321);
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
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(17, 57);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(93, 42);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "<- Вернуться";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.Return_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(635, 212);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 42);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(635, 268);
            this.btnRename.Margin = new System.Windows.Forms.Padding(2);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(102, 42);
            this.btnRename.TabIndex = 9;
            this.btnRename.Text = "Поменять имя";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(635, 324);
            this.btnSort.Margin = new System.Windows.Forms.Padding(2);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(102, 42);
            this.btnSort.TabIndex = 10;
            this.btnSort.Text = "Сортировать по имени";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(749, 103);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(2);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(102, 42);
            this.btnCopy.TabIndex = 11;
            this.btnCopy.Text = "Скопировать";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(749, 156);
            this.btnPaste.Margin = new System.Windows.Forms.Padding(2);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(102, 42);
            this.btnPaste.TabIndex = 12;
            this.btnPaste.Text = "Вставить";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnMoveStart
            // 
            this.btnMoveStart.Location = new System.Drawing.Point(749, 268);
            this.btnMoveStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoveStart.Name = "btnMoveStart";
            this.btnMoveStart.Size = new System.Drawing.Size(102, 42);
            this.btnMoveStart.TabIndex = 13;
            this.btnMoveStart.Text = "Начать перемещение";
            this.btnMoveStart.UseVisualStyleBackColor = true;
            this.btnMoveStart.Click += new System.EventHandler(this.btnMoveStart_Click);
            // 
            // btnUnSort
            // 
            this.btnUnSort.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnUnSort.Enabled = false;
            this.btnUnSort.Location = new System.Drawing.Point(635, 370);
            this.btnUnSort.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnSort.Name = "btnUnSort";
            this.btnUnSort.Size = new System.Drawing.Size(102, 42);
            this.btnUnSort.TabIndex = 14;
            this.btnUnSort.Text = "Убрать сортировку";
            this.btnUnSort.UseVisualStyleBackColor = false;
            this.btnUnSort.Click += new System.EventHandler(this.btnUnSort_Click);
            // 
            // btnMoveEnd
            // 
            this.btnMoveEnd.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMoveEnd.Enabled = false;
            this.btnMoveEnd.Location = new System.Drawing.Point(749, 325);
            this.btnMoveEnd.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoveEnd.Name = "btnMoveEnd";
            this.btnMoveEnd.Size = new System.Drawing.Size(102, 60);
            this.btnMoveEnd.TabIndex = 15;
            this.btnMoveEnd.Text = "Переместить в выбранную папку";
            this.btnMoveEnd.UseVisualStyleBackColor = false;
            this.btnMoveEnd.Click += new System.EventHandler(this.btnMoveEnd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 438);
            this.Controls.Add(this.btnMoveEnd);
            this.Controls.Add(this.btnUnSort);
            this.Controls.Add(this.btnMoveStart);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnCreateFolder);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Button btnCreateFolder;
        private System.Windows.Forms.Label lbl_fullPath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnMoveStart;
        private System.Windows.Forms.Button btnUnSort;
        private System.Windows.Forms.Button btnMoveEnd;
    }
}

