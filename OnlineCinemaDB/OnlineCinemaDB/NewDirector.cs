using System;
using System.Windows.Forms;

namespace OnlineCinemaDB
{
    public partial class NewDirector : Form
    {
        public NewDirector()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                directorsTableAdapter.Insert(name.Text.Trim());
                MessageBox.Show("Новый режиссёр добавлен");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при добавлении режиссёра.\nВозможно режиссёр с таким ФИО уже существует");
            }
        }

        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void field_TextChanged(object sender, EventArgs e)
        {
            if (name.Text != String.Empty)
            {
                addButton.Enabled = true;
            }
            else
            {
                addButton.Enabled = false;
            }
        }
    }
}
