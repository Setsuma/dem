namespace OnlineCinemaDB
{
    partial class EditComment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditComment));
            this.updateCommentLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.TextBox();
            this.filmLabel = new System.Windows.Forms.Label();
            this.updatePicture = new System.Windows.Forms.PictureBox();
            this.author = new System.Windows.Forms.ComboBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinema_onlineDataSet = new OnlineCinemaDB.cinema_onlineDataSet();
            this.film = new System.Windows.Forms.ComboBox();
            this.filmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new OnlineCinemaDB.cinema_onlineDataSetTableAdapters.customersTableAdapter();
            this.filmsTableAdapter = new OnlineCinemaDB.cinema_onlineDataSetTableAdapters.filmsTableAdapter();
            this.filmIDLabel = new System.Windows.Forms.Label();
            this.commentsTableAdapter = new OnlineCinemaDB.cinema_onlineDataSetTableAdapters.commentsTableAdapter();
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.updatePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinema_onlineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // updateCommentLabel
            // 
            this.updateCommentLabel.BackColor = System.Drawing.Color.Silver;
            this.updateCommentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateCommentLabel.Location = new System.Drawing.Point(0, 0);
            this.updateCommentLabel.Name = "updateCommentLabel";
            this.updateCommentLabel.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.updateCommentLabel.Size = new System.Drawing.Size(428, 93);
            this.updateCommentLabel.TabIndex = 12;
            this.updateCommentLabel.Text = "Обновить комментарий";
            this.updateCommentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorLabel.Location = new System.Drawing.Point(2, 245);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(71, 24);
            this.authorLabel.TabIndex = 15;
            this.authorLabel.Text = "Автор";
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLabel.Location = new System.Drawing.Point(2, 108);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(67, 24);
            this.textLabel.TabIndex = 18;
            this.textLabel.Text = "Текст";
            // 
            // text
            // 
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text.Location = new System.Drawing.Point(6, 135);
            this.text.MaxLength = 128;
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text.Size = new System.Drawing.Size(314, 101);
            this.text.TabIndex = 17;
            this.text.TextChanged += new System.EventHandler(this.field_TextChanged);
            // 
            // filmLabel
            // 
            this.filmLabel.AutoSize = true;
            this.filmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filmLabel.Location = new System.Drawing.Point(2, 314);
            this.filmLabel.Name = "filmLabel";
            this.filmLabel.Size = new System.Drawing.Size(76, 24);
            this.filmLabel.TabIndex = 20;
            this.filmLabel.Text = "Фильм";
            // 
            // updatePicture
            // 
            this.updatePicture.BackColor = System.Drawing.Color.Silver;
            this.updatePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.updatePicture.Image = global::OnlineCinemaDB.Properties.Resources.edit;
            this.updatePicture.Location = new System.Drawing.Point(4, 13);
            this.updatePicture.Name = "updatePicture";
            this.updatePicture.Size = new System.Drawing.Size(70, 70);
            this.updatePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.updatePicture.TabIndex = 13;
            this.updatePicture.TabStop = false;
            // 
            // author
            // 
            this.author.DataSource = this.customersBindingSource;
            this.author.DisplayMember = "customer_name";
            this.author.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.author.FormattingEnabled = true;
            this.author.Location = new System.Drawing.Point(6, 272);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(314, 32);
            this.author.TabIndex = 21;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "customers";
            this.customersBindingSource.DataSource = this.cinema_onlineDataSet;
            // 
            // cinema_onlineDataSet
            // 
            this.cinema_onlineDataSet.DataSetName = "cinema_onlineDataSet";
            this.cinema_onlineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // film
            // 
            this.film.DataSource = this.filmsBindingSource;
            this.film.DisplayMember = "title";
            this.film.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.film.FormattingEnabled = true;
            this.film.Location = new System.Drawing.Point(6, 341);
            this.film.Name = "film";
            this.film.Size = new System.Drawing.Size(314, 32);
            this.film.TabIndex = 22;
            this.film.SelectionChangeCommitted += new System.EventHandler(this.film_SelectionChangeCommitted);
            // 
            // filmsBindingSource
            // 
            this.filmsBindingSource.DataMember = "films";
            this.filmsBindingSource.DataSource = this.cinema_onlineDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // filmsTableAdapter
            // 
            this.filmsTableAdapter.ClearBeforeFill = true;
            // 
            // filmIDLabel
            // 
            this.filmIDLabel.AutoSize = true;
            this.filmIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filmIDLabel.Location = new System.Drawing.Point(326, 344);
            this.filmIDLabel.Name = "filmIDLabel";
            this.filmIDLabel.Size = new System.Drawing.Size(0, 24);
            this.filmIDLabel.TabIndex = 23;
            // 
            // commentsTableAdapter
            // 
            this.commentsTableAdapter.ClearBeforeFill = true;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.updateButton.Enabled = false;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.Location = new System.Drawing.Point(12, 395);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(110, 38);
            this.updateButton.TabIndex = 24;
            this.updateButton.Text = "Обновить";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // EditComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 445);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.filmIDLabel);
            this.Controls.Add(this.film);
            this.Controls.Add(this.author);
            this.Controls.Add(this.filmLabel);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.text);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.updatePicture);
            this.Controls.Add(this.updateCommentLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditComment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обновление комментария";
            this.Load += new System.EventHandler(this.NewComment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updatePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinema_onlineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox updatePicture;
        private System.Windows.Forms.Label updateCommentLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Label filmLabel;
        private System.Windows.Forms.ComboBox author;
        private System.Windows.Forms.ComboBox film;
        private cinema_onlineDataSet cinema_onlineDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private cinema_onlineDataSetTableAdapters.customersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource filmsBindingSource;
        private cinema_onlineDataSetTableAdapters.filmsTableAdapter filmsTableAdapter;
        private System.Windows.Forms.Label filmIDLabel;
        private cinema_onlineDataSetTableAdapters.commentsTableAdapter commentsTableAdapter;
        private System.Windows.Forms.Button updateButton;
    }
}