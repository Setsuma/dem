using OnlineCinemaDB.cinema_onlineDataSetTableAdapters;
using OnlineCinemaDB.entity;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OnlineCinemaDB
{
    public partial class Main : Form
    {
        Authorization authorization;
        User user;

        public Main(User user, Authorization authorization)
        {
            InitializeComponent();
            this.authorization = authorization;
            this.user = user;
            int center = pageHome.Width / 2;
            profileName.Text = "Имя: " + user.Name;
            profileRole.Text = "Роль: " + user.Role.ToString();
            profilePicture.Location = new Point(center - profilePicture.Width / 2, 10);
            profileName.Location = new Point(center - profileName.Width / 2, 210);
            profileRole.Location = new Point(center - profileRole.Width / 2, 260);

            if (user.Role == Access.moderator)
            {
                tablePages.TabPages.Remove(customersPage);
                insertFilmButton.Visible = false;
                updateFilmButton.Visible = false;
                deleteFilmButton.Visible = false;
                insertDirectorButton.Visible = false;
                updateDirectorButton.Visible = false;
                deleteDirectorButton.Visible = false;
                insertActorButton.Visible = false;
                updateActorButton.Visible = false;
                deleteActorButton.Visible = false;
                insertGenreButton.Visible = false;
                updateGenreButton.Visible = false;
                deleteGenreButton.Visible = false;
                insertCountryButton.Visible = false;
                updateCountryButton.Visible = false;
                deleteCountryButton.Visible = false;
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            authorization.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            refreshTables();
        }

        private void filmsRefreshButton_Click(object sender, EventArgs e)
        {
            this.film_infoTableAdapter.Fill(this.cinema_onlineDataSet.film_info);
        }

        private void directorsRefreshButton_Click(object sender, EventArgs e)
        {
            this.directorsTableAdapter.Fill(this.cinema_onlineDataSet.directors);
        }

        private void actorsRefreshButton_Click(object sender, EventArgs e)
        {
            this.actorsTableAdapter.Fill(this.cinema_onlineDataSet.actors);
        }

        private void genresRefreshButton_Click(object sender, EventArgs e)
        {
            this.genresTableAdapter.Fill(this.cinema_onlineDataSet.genres);
        }

        private void countriesRefreshButton_Click(object sender, EventArgs e)
        {
            this.countriesTableAdapter.Fill(this.cinema_onlineDataSet.countries);
        }

        private void customersRefreshButton_Click(object sender, EventArgs e)
        {
            this.customersTableAdapter.Fill(this.cinema_onlineDataSet.customers);
        }

        private void commentsRefreshButton_Click(object sender, EventArgs e)
        {
            this.comment_infoTableAdapter.Fill(this.cinema_onlineDataSet.comment_info);
        }

        private void insertFilmButton_Click(object sender, EventArgs e)
        {
            NewFilm newFilm = new NewFilm();
            if (newFilm.ShowDialog() == DialogResult.OK)
            {
                filmsRefreshButton_Click(sender, e);
            }
        }

        private void updateFilmButton_Click(object sender, EventArgs e)
        {
            EditFilm editFilm = new EditFilm(int.Parse(filmId.Text), filmTitle.Text, filmDescription.Text, DateTime.Parse(filmReleaseDate.Text), int.Parse(filmDuration.Text), filmCountry.Text, filmDirectors.Text, filmActors.Text, filmGenres.Text);
            if (editFilm.ShowDialog() == DialogResult.OK)
            {
                filmsRefreshButton_Click(sender, e);
            }
        }

        private void deleteFilmButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить фильм с ID = " + filmId.Text + "?", "Удаление фильма", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                filmsTableAdapter.Delete(int.Parse(filmId.Text));
                filmsRefreshButton_Click(sender, e);
            }
        }

        private void insertDirectorButton_Click(object sender, EventArgs e)
        {
            NewDirector newDirector = new NewDirector();
            if (newDirector.ShowDialog() == DialogResult.OK)
            {
                directorsRefreshButton_Click(sender, e);
            }
        }

        private void updateDirectorButton_Click(object sender, EventArgs e)
        {
            EditDirector editDirector = new EditDirector(int.Parse(directorId.Text), directorName.Text);
            if (editDirector.ShowDialog() == DialogResult.OK)
            {
                directorsRefreshButton_Click(sender, e);
            }
        }

        private void deleteDirectorButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить режиссёра с ID = " + directorId.Text + "?", "Удаление режиссёра", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                directorsTableAdapter.Delete(int.Parse(directorId.Text));
                directorsRefreshButton_Click(sender, e);
            }
        }

        private void insertActorButton_Click(object sender, EventArgs e)
        {
            NewActor newActor = new NewActor();
            if (newActor.ShowDialog() == DialogResult.OK)
            {
                actorsRefreshButton_Click(sender, e);
            }
        }

        private void updateActorButton_Click(object sender, EventArgs e)
        {
            EditActor editActor = new EditActor(int.Parse(actorId.Text), actorName.Text);
            if (editActor.ShowDialog() == DialogResult.OK)
            {
                actorsRefreshButton_Click(sender, e);
            }
        }

        private void deleteActorButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить актёра с ID = " + actorId.Text + "?", "Удаление актёра", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                actorsTableAdapter.Delete(int.Parse(actorId.Text));
                actorsRefreshButton_Click(sender, e);
            }
        }

        private void insertGenreButton_Click(object sender, EventArgs e)
        {
            NewGenre newGenre = new NewGenre();
            if (newGenre.ShowDialog() == DialogResult.OK)
            {
                genresRefreshButton_Click(sender, e);
            }
        }

        private void updateGenreButton_Click(object sender, EventArgs e)
        {
            EditGenre editGenre = new EditGenre(int.Parse(genreId.Text), genre.Text);
            if (editGenre.ShowDialog() == DialogResult.OK)
            {
                genresRefreshButton_Click(sender, e);
            }
        }

        private void deleteGenreButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить жанр с ID = " + genreId.Text + "?", "Удаление жанра", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                genresTableAdapter.Delete(int.Parse(genreId.Text));
                genresRefreshButton_Click(sender, e);
            }
        }

        private void insertCountryButton_Click(object sender, EventArgs e)
        {
            NewCountry newCountry = new NewCountry();
            if (newCountry.ShowDialog() == DialogResult.OK)
            {
                countriesRefreshButton_Click(sender, e);
            }
        }

        private void updateCountryButton_Click(object sender, EventArgs e)
        {
            EditCountry editCountry = new EditCountry(int.Parse(countryId.Text), country.Text);
            if (editCountry.ShowDialog() == DialogResult.OK)
            {
                countriesRefreshButton_Click(sender, e);
            }
        }

        private void deleteCountryButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить страну с ID = " + countryId.Text + "?", "Удаление страны", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                try
                {
                    countriesTableAdapter.Delete(int.Parse(countryId.Text));
                    countriesRefreshButton_Click(sender, e);
                }
                catch
                {
                    MessageBox.Show("Ошибка. Страну нельзя удалить пока существуют фильмы с ней.");
                }
            }
        }

        private void insertCustomerButton_Click(object sender, EventArgs e)
        {
            NewCustomer newCustomer = new NewCustomer();
            if (newCustomer.ShowDialog() == DialogResult.OK)
            {
                customersRefreshButton_Click(sender, e);
            }
        }

        private void updateCustomerButton_Click(object sender, EventArgs e)
        {
            EditCustomer editCustomer = new EditCustomer(int.Parse(customerId.Text), customerEmail.Text, customerName.Text);
            if (editCustomer.ShowDialog() == DialogResult.OK)
            {
                customersRefreshButton_Click(sender, e);
            }
        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить пользователя с ID = " + customerId.Text + "?", "Удаление пользователя", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                customersTableAdapter.Delete(int.Parse(customerId.Text));
                customersRefreshButton_Click(sender, e);
            }
        }

        private void insertCommentButton_Click(object sender, EventArgs e)
        {
            NewComment newComment = new NewComment();
            if (newComment.ShowDialog() == DialogResult.OK)
            {
                commentsRefreshButton_Click(sender, e);
            }
        }

        private void updateCommentButton_Click(object sender, EventArgs e)
        {
            EditComment editComment = new EditComment(int.Parse(commentId.Text), commentText.Text, int.Parse(commentFilmId.Text), int.Parse(authorId.Text));
            if (editComment.ShowDialog() == DialogResult.OK)
            {
                commentsRefreshButton_Click(sender, e);
            }
        }

        private void deleteCommentButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить комментарий с ID = " + commentId.Text + "?", "Удаление комментария", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                commentsTableAdapter.Delete(int.Parse(commentId.Text));
                commentsRefreshButton_Click(sender, e);
            }
        }

        private void tablePages_Selecting(object sender, TabControlCancelEventArgs e)
        {
            refreshTables();
            findFilm.Clear();
            findDirector.Clear();
            findActor.Clear();
            findGenre.Clear();
            findCountry.Clear();
            findCustomer.Clear();
            findComment.Clear();
        }

        private void refreshTables()
        {
            this.comment_infoTableAdapter.Fill(this.cinema_onlineDataSet.comment_info);
            this.customersTableAdapter.Fill(this.cinema_onlineDataSet.customers);
            this.countriesTableAdapter.Fill(this.cinema_onlineDataSet.countries);
            this.genresTableAdapter.Fill(this.cinema_onlineDataSet.genres);
            this.actorsTableAdapter.Fill(this.cinema_onlineDataSet.actors);
            this.directorsTableAdapter.Fill(this.cinema_onlineDataSet.directors);
            this.film_infoTableAdapter.Fill(this.cinema_onlineDataSet.film_info);
        }

        private void numberField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void findFilm_TextChanged(object sender, EventArgs e)
        {
            if (findFilm.Text != String.Empty)
                filminfoBindingSource.Filter = string.Format("[{0}] = '{1}'", "film_id", findFilm.Text);
            else
                filminfoBindingSource.Filter = String.Empty;
        }

        private void findDirector_TextChanged(object sender, EventArgs e)
        {
            if (findDirector.Text != String.Empty)
                directorsBindingSource.Filter = string.Format("[{0}] = '{1}'", "director_id", findDirector.Text);
            else
                directorsBindingSource.Filter = String.Empty;
        }

        private void findActor_TextChanged(object sender, EventArgs e)
        {
            if (findActor.Text != String.Empty)
                actorsBindingSource.Filter = string.Format("[{0}] = '{1}'", "actor_id", findActor.Text);
            else
                actorsBindingSource.Filter = String.Empty;
        }

        private void findGenre_TextChanged(object sender, EventArgs e)
        {
            if (findGenre.Text != String.Empty)
                genresBindingSource.Filter = string.Format("[{0}] = '{1}'", "genre_id", findGenre.Text);
            else
                genresBindingSource.Filter = String.Empty;
        }

        private void findCountry_TextChanged(object sender, EventArgs e)
        {
            if (findCountry.Text != String.Empty)
                countriesBindingSource.Filter = string.Format("[{0}] = '{1}'", "country_id", findCountry.Text);
            else
                countriesBindingSource.Filter = String.Empty;
        }

        private void findCustomer_TextChanged(object sender, EventArgs e)
        {
            if (findCustomer.Text != String.Empty)
                customersBindingSource.Filter = string.Format("[{0}] = '{1}'", "customer_id", findCustomer.Text);
            else
                customersBindingSource.Filter = String.Empty;
        }

        private void findComment_TextChanged(object sender, EventArgs e)
        {
            if (findComment.Text != String.Empty)
                commentinfoBindingSource.Filter = string.Format("[{0}] = '{1}'", "comment_id", findComment.Text);
            else
                commentinfoBindingSource.Filter = String.Empty;
        }
    }
}
