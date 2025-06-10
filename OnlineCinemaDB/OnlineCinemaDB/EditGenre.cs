using OnlineCinemaDB.cinema_onlineDataSetTableAdapters;
using System;
using System.Windows.Forms;

namespace OnlineCinemaDB
{
    public partial class EditGenre : Form
    {
        int gId;

        public EditGenre(int gId, string genre)
        {
            InitializeComponent();
            this.gId = gId;
            this.genre.Text = genre;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                genresTableAdapter.Update(gId, genre.Text.Trim());
                MessageBox.Show("Жанр обновлён");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при обновлении жанра.\nВозможно такой жанр уже существует");
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
                updateButton.Enabled = true;
            }
            else
            {
                updateButton.Enabled = false;
            }
        }
    }
}
