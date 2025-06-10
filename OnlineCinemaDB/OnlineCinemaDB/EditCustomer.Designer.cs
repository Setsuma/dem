namespace OnlineCinemaDB
{
    partial class EditCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCustomer));
            this.updateCustomerLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.directorsTableAdapter = new OnlineCinemaDB.cinema_onlineDataSetTableAdapters.directorsTableAdapter();
            this.emailLabel = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.customersTableAdapter = new OnlineCinemaDB.cinema_onlineDataSetTableAdapters.customersTableAdapter();
            this.updatePicture = new System.Windows.Forms.PictureBox();
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.updatePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // updateCustomerLabel
            // 
            this.updateCustomerLabel.BackColor = System.Drawing.Color.Silver;
            this.updateCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateCustomerLabel.Location = new System.Drawing.Point(0, 0);
            this.updateCustomerLabel.Name = "updateCustomerLabel";
            this.updateCustomerLabel.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.updateCustomerLabel.Size = new System.Drawing.Size(428, 93);
            this.updateCustomerLabel.TabIndex = 12;
            this.updateCustomerLabel.Text = "Обновить пользователя";
            this.updateCustomerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(2, 170);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 24);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "Имя";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(6, 197);
            this.name.MaxLength = 32;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(314, 29);
            this.name.TabIndex = 14;
            this.name.TextChanged += new System.EventHandler(this.field_TextChanged);
            this.name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_KeyPress);
            // 
            // directorsTableAdapter
            // 
            this.directorsTableAdapter.ClearBeforeFill = true;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.Location = new System.Drawing.Point(2, 108);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(104, 24);
            this.emailLabel.TabIndex = 18;
            this.emailLabel.Text = "Эл. почта";
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email.Location = new System.Drawing.Point(6, 135);
            this.email.MaxLength = 64;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(314, 29);
            this.email.TabIndex = 17;
            this.email.TextChanged += new System.EventHandler(this.field_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(2, 232);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(150, 24);
            this.passwordLabel.TabIndex = 20;
            this.passwordLabel.Text = "Новый пароль";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(6, 259);
            this.password.MaxLength = 32;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(314, 29);
            this.password.TabIndex = 19;
            this.password.TextChanged += new System.EventHandler(this.field_TextChanged);
            this.password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_KeyPress);
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
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
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.updateButton.Enabled = false;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.Location = new System.Drawing.Point(12, 309);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(110, 38);
            this.updateButton.TabIndex = 21;
            this.updateButton.Text = "Обновить";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 359);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.password);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.email);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.name);
            this.Controls.Add(this.updatePicture);
            this.Controls.Add(this.updateCustomerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обновление пользователя";
            ((System.ComponentModel.ISupportInitialize)(this.updatePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox updatePicture;
        private System.Windows.Forms.Label updateCustomerLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox name;
        private cinema_onlineDataSetTableAdapters.directorsTableAdapter directorsTableAdapter;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox password;
        private cinema_onlineDataSetTableAdapters.customersTableAdapter customersTableAdapter;
        private System.Windows.Forms.Button updateButton;
    }
}