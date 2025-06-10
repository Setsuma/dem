using OnlineCinemaDB.cinema_onlineDataSetTableAdapters;
using System;
using System.Windows.Forms;

namespace OnlineCinemaDB
{
    public partial class NewGenre : Form
    {
        public NewGenre()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                genresTableAdapter.Insert(genre.Text.Trim());
                MessageBox.Show("Новый жанр добавлен");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при добавлении жанра.\nВозможно такой жанр уже существует");
            }
        }

        private void genre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void field_TextChanged(object sender, EventArgs e)
        {
            if (genre.Text != String.Empty)
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
