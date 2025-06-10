namespace OnlineCinemaDB
{
    partial class NewDirector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewDirector));
            this.addDirectorLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.directorsTableAdapter = new OnlineCinemaDB.cinema_onlineDataSetTableAdapters.directorsTableAdapter();
            this.addPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.addPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // addDirectorLabel
            // 
            this.addDirectorLabel.BackColor = System.Drawing.Color.Silver;
            this.addDirectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addDirectorLabel.Location = new System.Drawing.Point(0, 0);
            this.addDirectorLabel.Name = "addDirectorLabel";
            this.addDirectorLabel.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.addDirectorLabel.Size = new System.Drawing.Size(417, 93);
            this.addDirectorLabel.TabIndex = 12;
            this.addDirectorLabel.Text = "Добавить режиссёра";
            this.addDirectorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(2, 105);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(57, 24);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "ФИО";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(6, 132);
            this.name.MaxLength = 128;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(314, 29);
            this.name.TabIndex = 14;
            this.name.TextChanged += new System.EventHandler(this.field_TextChanged);
            this.name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_KeyPress);
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
            // directorsTableAdapter
            // 
            this.directorsTableAdapter.ClearBeforeFill = true;
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
            // NewDirector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 233);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.name);
            this.Controls.Add(this.addPicture);
            this.Controls.Add(this.addDirectorLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewDirector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление режиссёра";
            ((System.ComponentModel.ISupportInitialize)(this.addPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox addPicture;
        private System.Windows.Forms.Label addDirectorLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button addButton;
        private cinema_onlineDataSetTableAdapters.directorsTableAdapter directorsTableAdapter;
    }
}