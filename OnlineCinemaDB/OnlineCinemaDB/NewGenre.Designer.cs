namespace OnlineCinemaDB
{
    partial class NewGenre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewGenre));
            this.addGenreLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.addPicture = new System.Windows.Forms.PictureBox();
            this.genresTableAdapter = new OnlineCinemaDB.cinema_onlineDataSetTableAdapters.genresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.addPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // addGenreLabel
            // 
            this.addGenreLabel.BackColor = System.Drawing.Color.Silver;
            this.addGenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addGenreLabel.Location = new System.Drawing.Point(0, 0);
            this.addGenreLabel.Name = "addGenreLabel";
            this.addGenreLabel.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.addGenreLabel.Size = new System.Drawing.Size(417, 93);
            this.addGenreLabel.TabIndex = 12;
            this.addGenreLabel.Text = "Добавить жанр";
            this.addGenreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(2, 105);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(105, 24);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "Название";
            // 
            // genre
            // 
            this.genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genre.Location = new System.Drawing.Point(6, 132);
            this.genre.MaxLength = 32;
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(314, 29);
            this.genre.TabIndex = 14;
            this.genre.TextChanged += new System.EventHandler(this.field_TextChanged);
            this.genre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.genre_KeyPress);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.addButton.Enabled = false;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(6, 183);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(110, 38);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addPicture
            // 
            this.addPicture.BackColor = System.Drawing.Color.Silver;
            this.addPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addPicture.Image = global::OnlineCinemaDB.Properties.Resources.add;
            this.addPicture.Location = new System.Drawing.Point(4, 13);
            this.addPicture.Name = "addPicture";
            this.addPicture.Size = new System.Drawing.Size(70, 70);
            this.addPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.addPicture.TabIndex = 13;
            this.addPicture.TabStop = false;
            // 
            // genresTableAdapter
            // 
            this.genresTableAdapter.ClearBeforeFill = true;
            // 
            // NewGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 233);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.addPicture);
            this.Controls.Add(this.addGenreLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewGenre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление жанра";
            ((System.ComponentModel.ISupportInitialize)(this.addPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox addPicture;
        private System.Windows.Forms.Label addGenreLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox genre;
        private System.Windows.Forms.Button addButton;
        private cinema_onlineDataSetTableAdapters.genresTableAdapter genresTableAdapter;
    }
}