using OnlineCinemaDB.cinema_onlineDataSetTableAdapters;
using System;
using System.Windows.Forms;

namespace OnlineCinemaDB
{
    public partial class EditCountry : Form
    {
        int cId;

        public EditCountry(int cId, string country)
        {
            InitializeComponent();
            this.cId = cId;
            this.country.Text = country;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                countriesTableAdapter.Update(cId, country.Text.Trim());
                MessageBox.Show("Страна обновлена");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при обновлении страны.\nВозможно такая страна уже существует");
            }
        }

        private void country_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void field_TextChanged(object sender, EventArgs e)
        {
            if (country.Text != String.Empty)
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