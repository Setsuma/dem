using OnlineCinemaDB.cinema_onlineDataSetTableAdapters;
using System;
using System.Windows.Forms;

namespace OnlineCinemaDB
{
    public partial class EditActor : Form
    {
        int aId;

        public EditActor(int aId, string name)
        {
            InitializeComponent();
            this.aId = aId;
            this.name.Text = name;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                actorsTableAdapter.Update(aId, name.Text.Trim());
                MessageBox.Show("Актёр обновлён");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при обновлении актёра.\nВозможно актёр с таким ФИО уже существует");
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
