using OnlineCinemaDB.cinema_onlineDataSetTableAdapters;
using OnlineCinemaDB.utility;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OnlineCinemaDB
{
    public partial class EditCustomer : Form
    {
        int cId;

        public EditCustomer(int cId, string email, string name)
        {
            InitializeComponent();
            this.cId = cId;
            this.email.Text = email;
            this.name.Text = name;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (!isValidEmail(email.Text))
            {
                MessageBox.Show("Некорректный email");
                return;
            }

            try
            {
                string pas = CryptoService.HashPasword(password.Text, out string salt);

                customersTableAdapter.Update(cId, email.Text.Trim(), name.Text.Trim(), pas, salt);
                MessageBox.Show("Пользователь обновлён");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при обновлении пользователя.\nВозможно пользователь с таким email или именем уже существует, или email введён некорректно");
            }
        }

        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        static bool isValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        private void field_TextChanged(object sender, EventArgs e)
        {
            if (email.Text != String.Empty && name.Text != String.Empty && password.Text != String.Empty)
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
