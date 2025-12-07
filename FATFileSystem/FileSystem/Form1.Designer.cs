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
            this.FATgrid = new System.Windows.Forms.DataGridView();
            this.btn_Defragment = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FATgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(952, 158);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(153, 65);
            this.btnCreateFile.TabIndex = 2;
            this.btnCreateFile.Text = "Создать файл";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.Location = new System.Drawing.Point(952, 240);
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(153, 65);
            this.btnCreateFolder.TabIndex = 3;
            this.btnCreateFolder.Text = "Создать папку";
            this.btnCreateFolder.UseVisualStyleBackColor = true;
            this.btnCreateFolder.Click += new System.EventHandler(this.btnCreateFolder_Click);
            // 
            // lbl_fullPath
            // 
            this.lbl_fullPath.AutoSize = true;
            this.lbl_fullPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_fullPath.Location = new System.Drawing.Point(8, 15);
            this.lbl_fullPath.Name = "lbl_fullPath";
            this.lbl_fullPath.Size = new System.Drawing.Size(21, 29);
            this.lbl_fullPath.TabIndex = 4;
            this.lbl_fullPath.Text = "-";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_fullPath);
            this.panel1.Location = new System.Drawing.Point(26, 25);
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
            this.listView.Location = new System.Drawing.Point(26, 157);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(922, 477);
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
            this.btnReturn.Location = new System.Drawing.Point(26, 88);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(140, 65);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "<- Вернуться";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.Return_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(952, 326);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(153, 65);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(952, 412);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(153, 65);
            this.btnRename.TabIndex = 9;
            this.btnRename.Text = "Поменять имя";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(954, 498);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(153, 65);
            this.btnSort.TabIndex = 10;
            this.btnSort.Text = "Сортировать по имени";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(1124, 158);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(153, 65);
            this.btnCopy.TabIndex = 11;
            this.btnCopy.Text = "Скопировать";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(1124, 240);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(153, 65);
            this.btnPaste.TabIndex = 12;
            this.btnPaste.Text = "Вставить";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnMoveStart
            // 
            this.btnMoveStart.Location = new System.Drawing.Point(1124, 326);
            this.btnMoveStart.Name = "btnMoveStart";
            this.btnMoveStart.Size = new System.Drawing.Size(153, 65);
            this.btnMoveStart.TabIndex = 13;
            this.btnMoveStart.Text = "Начать перемещение";
            this.btnMoveStart.UseVisualStyleBackColor = true;
            this.btnMoveStart.Click += new System.EventHandler(this.btnMoveStart_Click);
            // 
            // btnUnSort
            // 
            this.btnUnSort.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnUnSort.Enabled = false;
            this.btnUnSort.Location = new System.Drawing.Point(952, 569);
            this.btnUnSort.Name = "btnUnSort";
            this.btnUnSort.Size = new System.Drawing.Size(153, 65);
            this.btnUnSort.TabIndex = 14;
            this.btnUnSort.Text = "Убрать сортировку";
            this.btnUnSort.UseVisualStyleBackColor = false;
            this.btnUnSort.Click += new System.EventHandler(this.btnUnSort_Click);
            // 
            // btnMoveEnd
            // 
            this.btnMoveEnd.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMoveEnd.Enabled = false;
            this.btnMoveEnd.Location = new System.Drawing.Point(1124, 414);
            this.btnMoveEnd.Name = "btnMoveEnd";
            this.btnMoveEnd.Size = new System.Drawing.Size(153, 92);
            this.btnMoveEnd.TabIndex = 15;
            this.btnMoveEnd.Text = "Переместить в выбранную папку";
            this.btnMoveEnd.UseVisualStyleBackColor = false;
            this.btnMoveEnd.Click += new System.EventHandler(this.btnMoveEnd_Click);
            // 
            // FATgrid
            // 
            this.FATgrid.AllowUserToAddRows = false;
            this.FATgrid.AllowUserToDeleteRows = false;
            this.FATgrid.AllowUserToResizeColumns = false;
            this.FATgrid.AllowUserToResizeRows = false;
            this.FATgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FATgrid.Location = new System.Drawing.Point(26, 648);
            this.FATgrid.MultiSelect = false;
            this.FATgrid.Name = "FATgrid";
            this.FATgrid.ReadOnly = true;
            this.FATgrid.RowHeadersVisible = false;
            this.FATgrid.RowHeadersWidth = 62;
            this.FATgrid.RowTemplate.Height = 28;
            this.FATgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.FATgrid.Size = new System.Drawing.Size(1251, 100);
            this.FATgrid.TabIndex = 16;
            // 
            // btn_Defragment
            // 
            this.btn_Defragment.Location = new System.Drawing.Point(1128, 569);
            this.btn_Defragment.Name = "btn_Defragment";
            this.btn_Defragment.Size = new System.Drawing.Size(153, 65);
            this.btn_Defragment.TabIndex = 17;
            this.btn_Defragment.Text = "Дефрагментация";
            this.btn_Defragment.UseVisualStyleBackColor = true;
            this.btn_Defragment.Click += new System.EventHandler(this.btn_Defragment_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 760);
            this.Controls.Add(this.btn_Defragment);
            this.Controls.Add(this.FATgrid);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FATgrid)).EndInit();
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
        private System.Windows.Forms.DataGridView FATgrid;
        private System.Windows.Forms.Button btn_Defragment;
    }
}

