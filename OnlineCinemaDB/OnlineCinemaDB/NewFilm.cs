using OnlineCinemaDB.utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineCinemaDB
{
    public partial class NewFilm : Form
    {
        public NewFilm()
        {
            InitializeComponent();
        }

        private void NewFilm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinema_onlineDataSet1.countries". При необходимости она может быть перемещена или удалена.
            this.countriesTableAdapter.Fill(this.cinema_onlineDataSet.countries);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinema_onlineDataSet1.actors". При необходимости она может быть перемещена или удалена.
            this.actorsTableAdapter.Fill(this.cinema_onlineDataSet.actors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinema_onlineDataSet1.directors". При необходимости она может быть перемещена или удалена.
            this.directorsTableAdapter.Fill(this.cinema_onlineDataSet.directors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinema_onlineDataSet.genres". При необходимости она может быть перемещена или удалена.
            this.genresTableAdapter.Fill(this.cinema_onlineDataSet.genres);

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
        }

        private void addButton_Click(object sender, EventArgs e)
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
                        command.CommandText = "INSERT INTO films (title, description, release_date, duration, country_id) VALUES (@title,@description,@release_date,@duration,@country_id);";
                        command.Parameters.AddWithValue("@title", title.Text);
                        command.Parameters.AddWithValue("@description", description.Text);
                        command.Parameters.AddWithValue("@release_date", releaseDate.Value.Date);
                        command.Parameters.AddWithValue("@duration", duration.Value);
                        command.Parameters.AddWithValue("@country_id", countryId);

                        // Выполнение команды и получение ID
                        int newFilmId = Convert.ToInt32(command.ExecuteScalar());

                        foreach (DataGridViewRow row in selectedDirectors)
                        {
                            SqlCommand command1 = connection.CreateCommand();
                            command1.Transaction = transaction;
                            command1.CommandText = "INSERT INTO film_director (film_id, director_id) VALUES (@film_id, @director_id);";
                            command1.Parameters.AddWithValue("@film_id", newFilmId);
                            command1.Parameters.AddWithValue("@director_id", (int)row.Cells["directoridDataGridViewTextBoxColumn"].Value);
                            command1.ExecuteNonQuery();
                        }

                        foreach (DataGridViewRow row in selectedActors)
                        {
                            SqlCommand command2 = connection.CreateCommand();
                            command2.Transaction = transaction;
                            command2.CommandText = "INSERT INTO film_actor (film_id, actor_id) VALUES (@film_id, @actor_id);";
                            command2.Parameters.AddWithValue("@film_id", newFilmId);
                            command2.Parameters.AddWithValue("@actor_id", (int)row.Cells["actoridDataGridViewTextBoxColumn"].Value);
                            command2.ExecuteNonQuery();
                        }

                        foreach (DataGridViewRow row in selectedGenres)
                        {
                            SqlCommand command3 = connection.CreateCommand();
                            command3.Transaction = transaction;
                            command3.CommandText = "INSERT INTO film_genre (film_id, genre_id) VALUES (@film_id, @genre_id);";
                            command3.Parameters.AddWithValue("@film_id", newFilmId);
                            command3.Parameters.AddWithValue("@genre_id", (int)row.Cells["genreidDataGridViewTextBoxColumn"].Value);
                            command3.ExecuteNonQuery();
                        }

                        // Подтверждение транзакции
                        transaction.Commit();
                        MessageBox.Show("Новый фильм добавлен");
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        // Откат транзакции в случае возникновения ошибки
                        transaction.Rollback();
                        MessageBox.Show("Произошла ошибка при добавлении фильма");
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
                addButton.Enabled = true;
            }
            else
            {
                addButton.Enabled = false;
            }
        }
    }
}