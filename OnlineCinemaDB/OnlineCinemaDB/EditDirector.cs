using OnlineCinemaDB.cinema_onlineDataSetTableAdapters;
using System;
using System.Windows.Forms;

namespace OnlineCinemaDB
{
    public partial class EditDirector : Form
    {
        int dId;

        public EditDirector(int dId, string name)
        {
            InitializeComponent();
            this.dId = dId;
            this.name.Text = name;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                directorsTableAdapter.Update(dId, name.Text.Trim());
                MessageBox.Show("Режиссёр обновлён");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при обновлении режиссёра.\nВозможно режиссёр с таким ФИО уже существует");
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
                updateButton.Enabled = true;
            }
            else
            {
                updateButton.Enabled = false;
            }
        }
    }
}
