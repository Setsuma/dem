namespace OnlineCinemaDB
{
    partial class EditFilm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditFilm));
            this.genresSelection = new System.Windows.Forms.DataGridView();
            this.genreidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinema_onlineDataSet = new OnlineCinemaDB.cinema_onlineDataSet();
            this.genresTableAdapter = new OnlineCinemaDB.cinema_onlineDataSetTableAdapters.genresTableAdapter();
            this.updateButton = new System.Windows.Forms.Button();
            this.filmsTableAdapter = new OnlineCinemaDB.cinema_onlineDataSetTableAdapters.filmsTableAdapter();
            this.directorsSelection = new System.Windows.Forms.DataGridView();
            this.directoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorfullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actorsSelection = new System.Windows.Forms.DataGridView();
            this.actoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorfullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.title = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.releaseDate = new System.Windows.Forms.DateTimePicker();
            this.duration = new System.Windows.Forms.NumericUpDown();
            this.country = new System.Windows.Forms.ComboBox();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countriesTableAdapter = new OnlineCinemaDB.cinema_onlineDataSetTableAdapters.countriesTableAdapter();
            this.directorsTableAdapter = new OnlineCinemaDB.cinema_onlineDataSetTableAdapters.directorsTableAdapter();
            this.actorsTableAdapter = new OnlineCinemaDB.cinema_onlineDataSetTableAdapters.actorsTableAdapter();
            this.titleLabel = new System.Windows.Forms.Label();
            this.addFilmLabel = new System.Windows.Forms.Label();
            this.addPicture = new System.Windows.Forms.PictureBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.releaseDateLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.genresLabel = new System.Windows.Forms.Label();
            this.directorsLabel = new System.Windows.Forms.Label();
            this.actorsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.genresSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinema_onlineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorsSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // genresSelection
            // 
            this.genresSelection.AllowUserToAddRows = false;
            this.genresSelection.AllowUserToDeleteRows = false;
            this.genresSelection.AutoGenerateColumns = false;
            this.genresSelection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.genresSelection.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.genresSelection.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.genresSelection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genresSelection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.genreidDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn});
            this.genresSelection.DataSource = this.genresBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.genresSelection.DefaultCellStyle = dataGridViewCellStyle2;
            this.genresSelection.Location = new System.Drawing.Point(410, 417);
            this.genresSelection.Name = "genresSelection";
            this.genresSelection.Size = new System.Drawing.Size(358, 138);
            this.genresSelection.TabIndex = 0;
            // 
            // genreidDataGridViewTextBoxColumn
            // 
            this.genreidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.genreidDataGridViewTextBoxColumn.DataPropertyName = "genre_id";
            this.genreidDataGridViewTextBoxColumn.HeaderText = "genre_id";
            this.genreidDataGridViewTextBoxColumn.Name = "genreidDataGridViewTextBoxColumn";
            this.genreidDataGridViewTextBoxColumn.ReadOnly = true;
            this.genreidDataGridViewTextBoxColumn.Width = 81;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genresBindingSource
            // 
            this.genresBindingSource.DataMember = "genres";
            this.genresBindingSource.DataSource = this.cinema_onlineDataSet;
            // 
            // cinema_onlineDataSet
            // 
            this.cinema_onlineDataSet.DataSetName = "cinema_onlineDataSet";
            this.cinema_onlineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genresTableAdapter
            // 
            this.genresTableAdapter.ClearBeforeFill = true;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.updateButton.Enabled = false;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.Location = new System.Drawing.Point(12, 511);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(110, 38);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Обновить";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // filmsTableAdapter
            // 
            this.filmsTableAdapter.ClearBeforeFill = true;
            // 
            // directorsSelection
            // 
            this.directorsSelection.AllowUserToAddRows = false;
            this.directorsSelection.AllowUserToDeleteRows = false;
            this.directorsSelection.AutoGenerateColumns = false;
            this.directorsSelection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.directorsSelection.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.directorsSelection.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.directorsSelection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.directorsSelection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.directoridDataGridViewTextBoxColumn,
            this.directorfullnameDataGridViewTextBoxColumn});
            this.directorsSelection.DataSource = this.directorsBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.directorsSelection.DefaultCellStyle = dataGridViewCellStyle4;
            this.directorsSelection.Location = new System.Drawing.Point(410, 99);
            this.directorsSelection.Name = "directorsSelection";
            this.directorsSelection.Size = new System.Drawing.Size(358, 138);
            this.directorsSelection.TabIndex = 2;
            // 
            // directoridDataGridViewTextBoxColumn
            // 
            this.directoridDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.directoridDataGridViewTextBoxColumn.DataPropertyName = "director_id";
            this.directoridDataGridViewTextBoxColumn.HeaderText = "director_id";
            this.directoridDataGridViewTextBoxColumn.Name = "directoridDataGridViewTextBoxColumn";
            this.directoridDataGridViewTextBoxColumn.ReadOnly = true;
            this.directoridDataGridViewTextBoxColumn.Width = 92;
            // 
            // directorfullnameDataGridViewTextBoxColumn
            // 
            this.directorfullnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.directorfullnameDataGridViewTextBoxColumn.DataPropertyName = "director_full_name";
            this.directorfullnameDataGridViewTextBoxColumn.HeaderText = "director_full_name";
            this.directorfullnameDataGridViewTextBoxColumn.Name = "directorfullnameDataGridViewTextBoxColumn";
            this.directorfullnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // directorsBindingSource
            // 
            this.directorsBindingSource.DataMember = "directors";
            this.directorsBindingSource.DataSource = this.cinema_onlineDataSet;
            // 
            // actorsSelection
            // 
            this.actorsSelection.AllowUserToAddRows = false;
            this.actorsSelection.AllowUserToDeleteRows = false;
            this.actorsSelection.AutoGenerateColumns = false;
            this.actorsSelection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.actorsSelection.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.actorsSelection.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.actorsSelection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actorsSelection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.actoridDataGridViewTextBoxColumn,
            this.actorfullnameDataGridViewTextBoxColumn});
            this.actorsSelection.DataSource = this.actorsBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.actorsSelection.DefaultCellStyle = dataGridViewCellStyle6;
            this.actorsSelection.Location = new System.Drawing.Point(410, 256);
            this.actorsSelection.Name = "actorsSelection";
            this.actorsSelection.Size = new System.Drawing.Size(358, 138);
            this.actorsSelection.TabIndex = 3;
            // 
            // actoridDataGridViewTextBoxColumn
            // 
            this.actoridDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.actoridDataGridViewTextBoxColumn.DataPropertyName = "actor_id";
            this.actoridDataGridViewTextBoxColumn.HeaderText = "actor_id";
            this.actoridDataGridViewTextBoxColumn.Name = "actoridDataGridViewTextBoxColumn";
            this.actoridDataGridViewTextBoxColumn.ReadOnly = true;
            this.actoridDataGridViewTextBoxColumn.Width = 78;
            // 
            // actorfullnameDataGridViewTextBoxColumn
            // 
            this.actorfullnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.actorfullnameDataGridViewTextBoxColumn.DataPropertyName = "actor_full_name";
            this.actorfullnameDataGridViewTextBoxColumn.HeaderText = "actor_full_name";
            this.actorfullnameDataGridViewTextBoxColumn.Name = "actorfullnameDataGridViewTextBoxColumn";
            this.actorfullnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actorsBindingSource
            // 
            this.actorsBindingSource.DataMember = "actors";
            this.actorsBindingSource.DataSource = this.cinema_onlineDataSet;
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(12, 126);
            this.title.MaxLength = 64;
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(241, 29);
            this.title.TabIndex = 4;
            this.title.TextChanged += new System.EventHandler(this.field_TextChanged);
            this.title.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_KeyPress);
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.description.Location = new System.Drawing.Point(12, 199);
            this.description.MaxLength = 128;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(241, 29);
            this.description.TabIndex = 5;
            this.description.TextChanged += new System.EventHandler(this.field_TextChanged);
            this.description.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_KeyPress);
            // 
            // releaseDate
            // 
            this.releaseDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.releaseDate.CustomFormat = "dd/MM/yyyy";
            this.releaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.releaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.releaseDate.Location = new System.Drawing.Point(12, 275);
            this.releaseDate.MaxDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.releaseDate.MinDate = new System.DateTime(1895, 11, 1, 0, 0, 0, 0);
            this.releaseDate.Name = "releaseDate";
            this.releaseDate.Size = new System.Drawing.Size(241, 29);
            this.releaseDate.TabIndex = 6;
            this.releaseDate.Value = new System.DateTime(2024, 6, 13, 0, 0, 0, 0);
            // 
            // duration
            // 
            this.duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.duration.Location = new System.Drawing.Point(12, 353);
            this.duration.Maximum = new decimal(new int[] {
            320,
            0,
            0,
            0});
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(241, 29);
            this.duration.TabIndex = 0;
            // 
            // country
            // 
            this.country.DataSource = this.countriesBindingSource;
            this.country.DisplayMember = "country";
            this.country.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.country.FormattingEnabled = true;
            this.country.Location = new System.Drawing.Point(12, 426);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(241, 32);
            this.country.TabIndex = 8;
            // 
            // countriesBindingSource
            // 
            this.countriesBindingSource.DataMember = "countries";
            this.countriesBindingSource.DataSource = this.cinema_onlineDataSet;
            // 
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
            // 
            // directorsTableAdapter
            // 
            this.directorsTableAdapter.ClearBeforeFill = true;
            // 
            // actorsTableAdapter
            // 
            this.actorsTableAdapter.ClearBeforeFill = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(8, 99);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(105, 24);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "Название";
            // 
            // addFilmLabel
            // 
            this.addFilmLabel.BackColor = System.Drawing.Color.Silver;
            this.addFilmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addFilmLabel.Location = new System.Drawing.Point(0, -1);
            this.addFilmLabel.Name = "addFilmLabel";
            this.addFilmLabel.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.addFilmLabel.Size = new System.Drawing.Size(788, 93);
            this.addFilmLabel.TabIndex = 10;
            this.addFilmLabel.Text = "Обновить фильм";
            this.addFilmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addPicture
            // 
            this.addPicture.BackColor = System.Drawing.Color.Silver;
            this.addPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addPicture.Image = global::OnlineCinemaDB.Properties.Resources.edit;
            this.addPicture.Location = new System.Drawing.Point(6, 12);
            this.addPicture.Name = "addPicture";
            this.addPicture.Size = new System.Drawing.Size(70, 70);
            this.addPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.addPicture.TabIndex = 11;
            this.addPicture.TabStop = false;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.Location = new System.Drawing.Point(8, 172);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(108, 24);
            this.descriptionLabel.TabIndex = 12;
            this.descriptionLabel.Text = "Описание";
            // 
            // releaseDateLabel
            // 
            this.releaseDateLabel.AutoSize = true;
            this.releaseDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.releaseDateLabel.Location = new System.Drawing.Point(8, 248);
            this.releaseDateLabel.Name = "releaseDateLabel";
            this.releaseDateLabel.Size = new System.Drawing.Size(137, 24);
            this.releaseDateLabel.TabIndex = 13;
            this.releaseDateLabel.Text = "Дата выхода";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.durationLabel.Location = new System.Drawing.Point(8, 326);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(245, 24);
            this.durationLabel.TabIndex = 14;
            this.durationLabel.Text = "Длительность (минуты)";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryLabel.Location = new System.Drawing.Point(8, 399);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(81, 24);
            this.countryLabel.TabIndex = 15;
            this.countryLabel.Text = "Страна";
            // 
            // genresLabel
            // 
            this.genresLabel.AutoSize = true;
            this.genresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genresLabel.Location = new System.Drawing.Point(328, 415);
            this.genresLabel.Name = "genresLabel";
            this.genresLabel.Size = new System.Drawing.Size(76, 24);
            this.genresLabel.TabIndex = 16;
            this.genresLabel.Text = "Жанры";
            // 
            // directorsLabel
            // 
            this.directorsLabel.AutoSize = true;
            this.directorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorsLabel.Location = new System.Drawing.Point(282, 99);
            this.directorsLabel.Name = "directorsLabel";
            this.directorsLabel.Size = new System.Drawing.Size(122, 24);
            this.directorsLabel.TabIndex = 17;
            this.directorsLabel.Text = "Режиссёры";
            // 
            // actorsLabel
            // 
            this.actorsLabel.AutoSize = true;
            this.actorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.actorsLabel.Location = new System.Drawing.Point(321, 256);
            this.actorsLabel.Name = "actorsLabel";
            this.actorsLabel.Size = new System.Drawing.Size(83, 24);
            this.actorsLabel.TabIndex = 18;
            this.actorsLabel.Text = "Актёры";
            // 
            // EditFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 561);
            this.Controls.Add(this.actorsLabel);
            this.Controls.Add(this.directorsLabel);
            this.Controls.Add(this.genresLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.releaseDateLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.addPicture);
            this.Controls.Add(this.addFilmLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.country);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.releaseDate);
            this.Controls.Add(this.description);
            this.Controls.Add(this.title);
            this.Controls.Add(this.actorsSelection);
            this.Controls.Add(this.directorsSelection);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.genresSelection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditFilm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обновление фильма";
            this.Load += new System.EventHandler(this.EditFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genresSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinema_onlineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorsSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView genresSelection;
        private cinema_onlineDataSet cinema_onlineDataSet;
        private System.Windows.Forms.BindingSource genresBindingSource;
        private cinema_onlineDataSetTableAdapters.genresTableAdapter genresTableAdapter;
        private System.Windows.Forms.Button updateButton;
        private cinema_onlineDataSetTableAdapters.filmsTableAdapter filmsTableAdapter;
        private System.Windows.Forms.DataGridView directorsSelection;
        private System.Windows.Forms.DataGridView actorsSelection;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.DateTimePicker releaseDate;
        private System.Windows.Forms.NumericUpDown duration;
        private System.Windows.Forms.ComboBox country;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private cinema_onlineDataSetTableAdapters.countriesTableAdapter countriesTableAdapter;
        private System.Windows.Forms.BindingSource directorsBindingSource;
        private cinema_onlineDataSetTableAdapters.directorsTableAdapter directorsTableAdapter;
        private System.Windows.Forms.BindingSource actorsBindingSource;
        private cinema_onlineDataSetTableAdapters.actorsTableAdapter actorsTableAdapter;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label addFilmLabel;
        private System.Windows.Forms.PictureBox addPicture;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label releaseDateLabel;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label genresLabel;
        private System.Windows.Forms.Label directorsLabel;
        private System.Windows.Forms.Label actorsLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directorfullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actorfullnameDataGridViewTextBoxColumn;
    }
}