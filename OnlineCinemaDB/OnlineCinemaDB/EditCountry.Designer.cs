namespace OnlineCinemaDB
{
    partial class EditCountry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCountry));
            this.countryLabel = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.TextBox();
            this.updateCountryLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.updatePicture = new System.Windows.Forms.PictureBox();
            this.countriesTableAdapter = new OnlineCinemaDB.cinema_onlineDataSetTableAdapters.countriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.updatePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryLabel.Location = new System.Drawing.Point(2, 105);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(105, 24);
            this.countryLabel.TabIndex = 19;
            this.countryLabel.Text = "Название";
            // 
            // country
            // 
            this.country.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.country.Location = new System.Drawing.Point(6, 132);
            this.country.MaxLength = 32;
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(314, 29);
            this.country.TabIndex = 18;
            this.country.TextChanged += new System.EventHandler(this.field_TextChanged);
            this.country.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.country_KeyPress);
            // 
            // updateCountryLabel
            // 
            this.updateCountryLabel.BackColor = System.Drawing.Color.Silver;
            this.updateCountryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateCountryLabel.Location = new System.Drawing.Point(0, 0);
            this.updateCountryLabel.Name = "updateCountryLabel";
            this.updateCountryLabel.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.updateCountryLabel.Size = new System.Drawing.Size(417, 93);
            this.updateCountryLabel.TabIndex = 16;
            this.updateCountryLabel.Text = "Обновить страну";
            this.updateCountryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
            // 
            // EditCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 233);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.country);
            this.Controls.Add(this.updatePicture);
            this.Controls.Add(this.updateCountryLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditCountry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обновление страны";
            ((System.ComponentModel.ISupportInitialize)(this.updatePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.PictureBox updatePicture;
        private System.Windows.Forms.Label updateCountryLabel;
        private System.Windows.Forms.Button updateButton;
        private cinema_onlineDataSetTableAdapters.countriesTableAdapter countriesTableAdapter;
    }
}