using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSystem
{
    public partial class RenameDialog : Form
    {
        public string NewName => txtBoxNewName.Text;

        public RenameDialog(string currentName)
        {
            InitializeComponent();
            lblCurName.Text = currentName; //Ставим текущее имя
            txtBoxNewName.Text = currentName; //Тоже ставим текущее имя, если в нём чучуть поменять надо
            txtBoxNewName.SelectAll(); // Выделяем весь текст (Чтоб удалить полностью, если надо)
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBoxNewName.Text)) //не пустой текстбокс
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Имя не может быть пустым");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        // Обработка нажатия Enter/Escape
        private void txtNewName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnCancel_Click(sender, e);
            }
        }
    }
}
