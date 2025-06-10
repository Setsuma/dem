namespace OnlineCinemaDB
{
    partial class EditGenre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditGenre));
            this.genreLabel = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.TextBox();
            this.updateGenreLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.updatePicture = new System.Windows.Forms.PictureBox();
            this.genresTableAdapter = new OnlineCinemaDB.cinema_onlineDataSetTableAdapters.genresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.updatePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genreLabel.Location = new System.Drawing.Point(2, 105);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(105, 24);
            this.genreLabel.TabIndex = 19;
            this.genreLabel.Text = "Название";
            // 
            // genre
            // 
            this.genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genre.Location = new System.Drawing.Point(6, 132);
            this.genre.MaxLength = 32;
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(314, 29);
            this.genre.TabIndex = 18;
            this.genre.TextChanged += new System.EventHandler(this.field_TextChanged);
            this.genre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.genre_KeyPress);
            // 
            // updateGenreLabel
            // 
            this.updateGenreLabel.BackColor = System.Drawing.Color.Silver;
            this.updateGenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateGenreLabel.Location = new System.Drawing.Point(0, 0);
            this.updateGenreLabel.Name = "updateGenreLabel";
            this.updateGenreLabel.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.updateGenreLabel.Size = new System.Drawing.Size(417, 93);
            this.updateGenreLabel.TabIndex = 16;
            this.updateGenreLabel.Text = "Обновить жанр";
            this.updateGenreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.updateButton.Enabled = false;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.Location = new System.Drawing.Point(6, 183);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(110, 38);
            this.updateButton.TabIndex = 20;
            this.updateButton.Text = "Обновить";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
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
            this.updatePicture.TabIndex = 17;
            this.updatePicture.TabStop = false;
            // 
            // genresTableAdapter
            // 
            this.genresTableAdapter.ClearBeforeFill = true;
            // 
            // EditGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 233);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.updatePicture);
            this.Controls.Add(this.updateGenreLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditGenre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обновление жанра";
            ((System.ComponentModel.ISupportInitialize)(this.updatePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.TextBox genre;
        private System.Windows.Forms.PictureBox updatePicture;
        private System.Windows.Forms.Label updateGenreLabel;
        private System.Windows.Forms.Button updateButton;
        private cinema_onlineDataSetTableAdapters.genresTableAdapter genresTableAdapter;
    }
}