using OnlineCinemaDB.dao;
using OnlineCinemaDB.entity;
using OnlineCinemaDB.utility;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OnlineCinemaDB
{
    public partial class Authorization : Form
    {
        UserDao userDao;
        public Authorization()
        {
            InitializeComponent();
            userDao = new UserDao();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            passwordInput.UseSystemPasswordChar = false;
            showButton.Visible = false;
            hideButton.Visible = true;
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            passwordInput.UseSystemPasswordChar = true;
            showButton.Visible = true;
            hideButton.Visible = false;
        }

        private void signUpButton_MouseEnter(object sender, EventArgs e)
        {
            signUpButton.ForeColor = Color.Blue;
        }

        private void signUpButton_MouseLeave(object sender, EventArgs e)
        {
            signUpButton.ForeColor = Color.DimGray;

        }

        private void authorization_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            string login = loginInput.Text;
            string password = passwordInput.Text;

            try
            {
                User user = userDao.findByLogin(login);

                if (CryptoService.VerifyPassword(password, user.Password, user.Salt))
                {
                    MessageBox.Show("Авторизация прошла успешно\nДобро пожаловать " + user.Name);
                    this.Hide();
                    Main main = new Main(user, this);
                    main.Show();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration reg = new Registration(this);
            reg.Show();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            loginInput.Clear();
            passwordInput.Clear();
            hideButton_Click(sender, e);
        }

        private void authorization_TextChanged(object sender, EventArgs e)
        {
            if (loginInput.Text != String.Empty && passwordInput.Text != String.Empty)
            {
                signInButton.Enabled = true;
            }
            else
            {
                signInButton.Enabled = false;
            }
        }

        private void Authorization_VisibleChanged(object sender, EventArgs e)
        {
            clearButton_Click(sender, e);
        }
    }
}