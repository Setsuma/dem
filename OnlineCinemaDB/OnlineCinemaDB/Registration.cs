using OnlineCinemaDB.dao;
using OnlineCinemaDB.entity;
using OnlineCinemaDB.utility;
using System;
using System.Windows.Forms;

namespace OnlineCinemaDB
{
    public partial class Registration : Form
    {
        Authorization authorization;
        UserDao userDao;

        public Registration(Authorization authorization)
        {
            InitializeComponent();
            this.authorization = authorization;
            this.userDao = new UserDao();
        }

        private void registration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void hideRegButton_Click(object sender, EventArgs e)
        {
            passwordRegInput.UseSystemPasswordChar = true;
            passwordRepeatRegInput.UseSystemPasswordChar = true;
            showRegButton.Visible = true;
            hideRegButton.Visible = false;
        }

        private void showRegButton_Click(object sender, EventArgs e)
        {
            passwordRegInput.UseSystemPasswordChar = false;
            passwordRepeatRegInput.UseSystemPasswordChar = false;
            showRegButton.Visible = false;
            hideRegButton.Visible = true;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            authorization.Show();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            if (passwordRegInput.Text.Equals(passwordRepeatRegInput.Text))
            {
                User newUser = new User(
                    loginRegInput.Text,
                    nameRegInput.Text,
                    CryptoService.HashPasword(passwordRegInput.Text, out string salt),
                    salt,
                    Access.moderator
                    );
                try
                {
                    userDao.addUser(newUser);

                    MessageBox.Show("Пользователь успешно создан");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Ошибка. Возможно пользователь с таким логином уже существует");
                }
            }
            else
            {
                MessageBox.Show("Пароли не совпадают");
            }
        }
        private void registration_TextChanged(object sender, EventArgs e)
        {
            if (loginRegInput.Text != String.Empty && nameRegInput.Text != String.Empty && passwordRegInput.Text != String.Empty && passwordRepeatRegInput.Text != String.Empty)
            {
                registrationButton.Enabled = true;
            }
            else
            {
                registrationButton.Enabled = false;
            }
        }

        private void clearRegButton_Click(object sender, EventArgs e)
        {
            loginRegInput.Clear();
            nameRegInput.Clear();
            passwordRegInput.Clear();
            passwordRepeatRegInput.Clear();
        }
    }
}
