using OnlineCinemaDB.utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace OnlineCinemaDB
{
    public partial class EditFilm : Form
    {
        int id;
        string countryName;
        string[] directors;
        string[] actors;
        string[] genres;
        List<int> originalDirectors;
        List<int> originalActors;
        List<int> originalGenres;

        public EditFilm(int id, string title, string description, DateTime date, int duration, string country, string directors, string actors, string genres)
        {
            InitializeComponent();
            this.id = id;
            this.title.Text = title;
            this.duration.Value = duration;
            this.description.Text = description;
            this.releaseDate.Value = date;
            this.countryName = country;
            this.directors = directors.Split(new string[] { ", " }, StringSplitOptions.None);
            this.actors = actors.Split(new string[] { ", " }, StringSplitOptions.None);
            this.genres = genres.Split(new string[] { ", " }, StringSplitOptions.None);
            originalDirectors = new List<int>();
            originalActors = new List<int>();
            originalGenres = new List<int>();
        }

        private void EditFilm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinema_onlineDataSet1.countries". При необходимости она может быть перемещена или удалена.
            this.countriesTableAdapter.Fill(this.cinema_onlineDataSet.countries);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinema_onlineDataSet1.actors". При необходимости она может быть перемещена или удалена.
            this.actorsTableAdapter.Fill(this.cinema_onlineDataSet.actors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinema_onlineDataSet1.directors". При необходимости она может быть перемещена или удалена.
            this.directorsTableAdapter.Fill(this.cinema_onlineDataSet.directors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinema_onlineDataSet.genres". При необходимости она может быть перемещена или удалена.
            this.genresTableAdapter.Fill(this.cinema_onlineDataSet.genres);

            country.SelectedIndex = countriesBindingSource.Find("country", countryName);

            DataGridViewCheckBoxColumn checkBoxColumnDirectors = new DataGridViewCheckBoxColumn();
            DataGridViewCheckBoxColumn checkBoxColumnActors = new DataGridViewCheckBoxColumn();
            DataGridViewCheckBoxColumn checkBoxColumnGenres = new DataGridViewCheckBoxColumn();

            // Устанавливаем имена столбцов и заголовоки
            checkBoxColumnDirectors.Name = "checkBoxColumnDirectors";
            checkBoxColumnDirectors.HeaderText = "";
            checkBoxColumnDirectors.ReadOnly = false;

            checkBoxColumnActors.Name = "checkBoxColumnActors";
            checkBoxColumnActors.HeaderText = "";
            checkBoxColumnActors.ReadOnly = false;

            checkBoxColumnGenres.Name = "checkBoxColumnGenres";
            checkBoxColumnGenres.HeaderText = "";
            checkBoxColumnGenres.ReadOnly = false;

            // Добавляем столбцы в DataGridView         
            directorsSelection.Columns.Add(checkBoxColumnDirectors);
            actorsSelection.Columns.Add(checkBoxColumnActors);
            genresSelection.Columns.Add(checkBoxColumnGenres);

            foreach (DataGridViewRow row in directorsSelection.Rows)
            {
                if (directors.Contains(row.Cells["directorfullnameDataGridViewTextBoxColumn"].Value.ToString()))
                {
                    row.Cells["checkBoxColumnDirectors"].Value = true;
                    originalDirectors.Add((int)row.Cells["directoridDataGridViewTextBoxColumn"].Value);
                }
            }

            foreach (DataGridViewRow row in actorsSelection.Rows)
            {
                if (actors.Contains(row.Cells["actorfullnameDataGridViewTextBoxColumn"].Value.ToString()))
                {
                    row.Cells["checkBoxColumnActors"].Value = true;
                    originalActors.Add((int)row.Cells["actoridDataGridViewTextBoxColumn"].Value);
                }
            }

            foreach (DataGridViewRow row in genresSelection.Rows)
            {
                if (genres.Contains(row.Cells["genreDataGridViewTextBoxColumn"].Value.ToString()))
                {
                    row.Cells["checkBoxColumnGenres"].Value = true;
                    originalGenres.Add((int)row.Cells["genreidDataGridViewTextBoxColumn"].Value);
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> selectedDirectors = new List<DataGridViewRow>();
            List<DataGridViewRow> selectedActors = new List<DataGridViewRow>();
            List<DataGridViewRow> selectedGenres = new List<DataGridViewRow>();

            foreach (DataGridViewRow row in directorsSelection.Rows)
            {
                // Проверяем значение флажка для текущей строки
                DataGridViewCheckBoxCell checkBox = (DataGridViewCheckBoxCell)row.Cells["checkBoxColumnDirectors"];
                if (Convert.ToBoolean(checkBox.Value) == true)
                {
                    // Если флажок установлен, добавляем строку в выборку
                    selectedDirectors.Add(row);
                }
            }

            foreach (DataGridViewRow row in actorsSelection.Rows)
            {
                // Проверяем значение флажка для текущей строки
                DataGridViewCheckBoxCell checkBox = (DataGridViewCheckBoxCell)row.Cells["checkBoxColumnActors"];
                if (Convert.ToBoolean(checkBox.Value) == true)
                {
                    // Если флажок установлен, добавляем строку в выборку
                    selectedActors.Add(row);
                }
            }

            foreach (DataGridViewRow row in genresSelection.Rows)
            {
                // Проверяем значение флажка для текущей строки
                DataGridViewCheckBoxCell checkBox = (DataGridViewCheckBoxCell)row.Cells["checkBoxColumnGenres"];
                if (Convert.ToBoolean(checkBox.Value) == true)
                {
                    // Если флажок установлен, добавляем строку в выборку
                    selectedGenres.Add(row);
                }
            }

            DataRowView selectedCountry = country.SelectedItem as DataRowView;
            int countryId = int.Parse(selectedCountry["country_id"].ToString());

            using (SqlConnection connection = Database.getConnection())
            {
                connection.Open();

                // Начало транзакции
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        SqlCommand command = connection.CreateCommand();
                        command.Transaction = transaction;
                        command.CommandText = "UPDATE films SET title = @title, description = @description, release_date = @release_date, duration = @duration, country_id = @country_id WHERE film_id = @film_id;";
                        command.Parameters.AddWithValue("@title", title.Text.Trim());
                        command.Parameters.AddWithValue("@description", description.Text.Trim());
                        command.Parameters.AddWithValue("@release_date", releaseDate.Value.Date);
                        command.Parameters.AddWithValue("@duration", duration.Value);
                        command.Parameters.AddWithValue("@country_id", countryId);
                        command.Parameters.AddWithValue("@film_id", id);
                        command.ExecuteNonQuery();

                        foreach (DataGridViewRow row in selectedDirectors)
                        {
                            int dId = (int)row.Cells["directoridDataGridViewTextBoxColumn"].Value;
                            if (!originalDirectors.Contains(dId))
                            {
                                SqlCommand command1 = connection.CreateCommand();
                                command1.Transaction = transaction;
                                command1.CommandText = "INSERT INTO film_director (film_id, director_id) VALUES (@film_id, @director_id);";
                                command1.Parameters.AddWithValue("@film_id", id);
                                command1.Parameters.AddWithValue("@director_id", dId);
                                command1.ExecuteNonQuery();
                            }
                            else originalDirectors.Remove(dId);
                        }

                        foreach (DataGridViewRow row in selectedActors)
                        {
                            int aId = (int)row.Cells["actoridDataGridViewTextBoxColumn"].Value;
                            if (!originalActors.Contains(aId))
                            {
                                SqlCommand command2 = connection.CreateCommand();
                                command2.Transaction = transaction;
                                command2.CommandText = "INSERT INTO film_actor (film_id, actor_id) VALUES (@film_id, @actor_id);";
                                command2.Parameters.AddWithValue("@film_id", id);
                                command2.Parameters.AddWithValue("@actor_id", aId);
                                command2.ExecuteNonQuery();
                            }
                            else originalActors.Remove(aId);
                        }

                        foreach (DataGridViewRow row in selectedGenres)
                        {
                            int gId = (int)row.Cells["genreidDataGridViewTextBoxColumn"].Value;
                            if (!originalGenres.Contains(gId))
                            {
                                SqlCommand command3 = connection.CreateCommand();
                                command3.Transaction = transaction;
                                command3.CommandText = "INSERT INTO film_genre (film_id, genre_id) VALUES (@film_id, @genre_id);";
                                command3.Parameters.AddWithValue("@film_id", id);
                                command3.Parameters.AddWithValue("@genre_id", gId);
                                command3.ExecuteNonQuery();
                            }
                            else originalGenres.Remove(gId);
                        }

                        if (originalDirectors.Count != 0)
                        {
                            foreach (int dId in originalDirectors)
                            {
                                SqlCommand command4 = connection.CreateCommand();
                                command4.Transaction = transaction;
                                command4.CommandText = "DELETE FROM film_director WHERE film_id = @film_id AND director_id = @director_id";
                                command4.Parameters.AddWithValue("@film_id", id);
                                command4.Parameters.AddWithValue("@director_id", dId);
                                command4.ExecuteNonQuery();
                            }
                        }

                        if (originalActors.Count != 0)
                        {
                            foreach (int aId in originalActors)
                            {
                                SqlCommand command5 = connection.CreateCommand();
                                command5.Transaction = transaction;
                                command5.CommandText = "DELETE FROM film_actor WHERE film_id = @film_id AND actor_id = @actor_id";
                                command5.Parameters.AddWithValue("@film_id", id);
                                command5.Parameters.AddWithValue("@actor_id", aId);
                                command5.ExecuteNonQuery();
                            }
                        }

                        if (originalActors.Count != 0)
                        {
                            foreach (int gId in originalGenres)
                            {
                                SqlCommand command6 = connection.CreateCommand();
                                command6.Transaction = transaction;
                                command6.CommandText = "DELETE FROM film_genre WHERE film_id = @film_id AND genre_id = @genre_id";
                                command6.Parameters.AddWithValue("@film_id", id);
                                command6.Parameters.AddWithValue("@genre_id", gId);
                                command6.ExecuteNonQuery();
                            }
                        }

                        // Подтверждение транзакции
                        transaction.Commit();
                        MessageBox.Show("Фильм обновлён");
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        // Откат транзакции в случае возникновения ошибки
                        transaction.Rollback();
                        MessageBox.Show("Произошла ошибка при обновлении фильма");
                    }
                }
            }
        }

        private void text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ' ' && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void field_TextChanged(object sender, EventArgs e)
        {
            if (title.Text != String.Empty && description.Text != String.Empty)
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
