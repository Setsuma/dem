using System;
using System.Data;
using System.Windows.Forms;

namespace OnlineCinemaDB
{
    public partial class EditComment : Form
    {
        int cId;
        int originalFilmId;
        int originalAuthorId;

        public EditComment(int cId, string text, int filmId, int authorId)
        {
            InitializeComponent();
            this.cId = cId;
            this.text.Text = text;
            originalFilmId = filmId;
            originalAuthorId = authorId;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            DataRowView selectedAuthor = author.SelectedItem as DataRowView;
            int aId = int.Parse(selectedAuthor["customer_id"].ToString());
            DataRowView selectedFilm = film.SelectedItem as DataRowView;
            int fId = int.Parse(selectedFilm["film_id"].ToString());

            try
            {
                commentsTableAdapter.Update(cId, text.Text.Trim(), fId, aId);
                MessageBox.Show("Комментарий обновлён");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при обновлении комментария");
            }
        }

        private void NewComment_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinema_onlineDataSet.films". При необходимости она может быть перемещена или удалена.
            this.filmsTableAdapter.Fill(this.cinema_onlineDataSet.films);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinema_onlineDataSet.customers". При необходимости она может быть перемещена или удалена.
            this.customersTableAdapter.Fill(this.cinema_onlineDataSet.customers);

            film.SelectedIndex = filmsBindingSource.Find("film_id", originalFilmId);
            author.SelectedIndex = customersBindingSource.Find("customer_id", originalAuthorId);

            film_SelectionChangeCommitted(sender, e);
        }

        private void film_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataRowView selectedFilm = film.SelectedItem as DataRowView;
            filmIDLabel.Text = "(id = " + selectedFilm["film_id"].ToString() + ")";
        }

        private void field_TextChanged(object sender, EventArgs e)
        {
            if (text.Text != String.Empty)
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