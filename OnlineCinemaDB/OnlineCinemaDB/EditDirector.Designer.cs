namespace OnlineCinemaDB
{
    partial class EditDirector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDirector));
            this.nameLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.updateDirectorLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.updatePicture = new System.Windows.Forms.PictureBox();
            this.directorsTableAdapter = new OnlineCinemaDB.cinema_onlineDataSetTableAdapters.directorsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.updatePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(2, 105);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(57, 24);
            this.nameLabel.TabIndex = 19;
            this.nameLabel.Text = "ФИО";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(6, 132);
            this.name.MaxLength = 128;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(314, 29);
            this.name.TabIndex = 18;
            this.name.TextChanged += new System.EventHandler(this.field_TextChanged);
            this.name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_KeyPress);
            // 
            // updateDirectorLabel
            // 
            this.updateDirectorLabel.BackColor = System.Drawing.Color.Silver;
            this.updateDirectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateDirectorLabel.Location = new System.Drawing.Point(0, 0);
            this.updateDirectorLabel.Name = "updateDirectorLabel";
            this.updateDirectorLabel.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.updateDirectorLabel.Size = new System.Drawing.Size(417, 93);
            this.updateDirectorLabel.TabIndex = 16;
            this.updateDirectorLabel.Text = "Обновить режиссёра";
            this.updateDirectorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // directorsTableAdapter
            // 
            this.directorsTableAdapter.ClearBeforeFill = true;
            // 
            // EditDirector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 233);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.name);
            this.Controls.Add(this.updatePicture);
            this.Controls.Add(this.updateDirectorLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditDirector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обновление режиссёра";
            ((System.ComponentModel.ISupportInitialize)(this.updatePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.PictureBox updatePicture;
        private System.Windows.Forms.Label updateDirectorLabel;
        private System.Windows.Forms.Button updateButton;
        private cinema_onlineDataSetTableAdapters.directorsTableAdapter directorsTableAdapter;
    }
}