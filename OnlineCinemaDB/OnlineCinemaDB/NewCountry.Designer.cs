namespace OnlineCinemaDB
{
    partial class NewCountry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCountry));
            this.addCountryLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.addPicture = new System.Windows.Forms.PictureBox();
            this.countriesTableAdapter = new OnlineCinemaDB.cinema_onlineDataSetTableAdapters.countriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.addPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // addCountryLabel
            // 
            this.addCountryLabel.BackColor = System.Drawing.Color.Silver;
            this.addCountryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCountryLabel.Location = new System.Drawing.Point(0, 0);
            this.addCountryLabel.Name = "addCountryLabel";
            this.addCountryLabel.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.addCountryLabel.Size = new System.Drawing.Size(417, 93);
            this.addCountryLabel.TabIndex = 12;
            this.addCountryLabel.Text = "Добавить страну";
            this.addCountryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // country
            // 
            this.country.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.country.Location = new System.Drawing.Point(6, 132);
            this.country.MaxLength = 32;
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(314, 29);
            this.country.TabIndex = 14;
            this.country.TextChanged += new System.EventHandler(this.field_TextChanged);
            this.country.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.country_KeyPress);
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
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
            // 
            // NewCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 233);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.country);
            this.Controls.Add(this.addPicture);
            this.Controls.Add(this.addCountryLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewCountry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление страны";
            ((System.ComponentModel.ISupportInitialize)(this.addPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox addPicture;
        private System.Windows.Forms.Label addCountryLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.Button addButton;
        private cinema_onlineDataSetTableAdapters.countriesTableAdapter countriesTableAdapter;
    }
}