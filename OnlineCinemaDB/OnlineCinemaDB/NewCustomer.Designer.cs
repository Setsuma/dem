namespace OnlineCinemaDB
{
    partial class NewCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCustomer));
            this.addCustomerLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.directorsTableAdapter = new OnlineCinemaDB.cinema_onlineDataSetTableAdapters.directorsTableAdapter();
            this.emailLabel = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.customersTableAdapter = new OnlineCinemaDB.cinema_onlineDataSetTableAdapters.customersTableAdapter();
            this.addPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.addPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // addCustomerLabel
            // 
            this.addCustomerLabel.BackColor = System.Drawing.Color.Silver;
            this.addCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCustomerLabel.Location = new System.Drawing.Point(0, 0);
            this.addCustomerLabel.Name = "addCustomerLabel";
            this.addCustomerLabel.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.addCustomerLabel.Size = new System.Drawing.Size(428, 93);
            this.addCustomerLabel.TabIndex = 12;
            this.addCustomerLabel.Text = "Добавить пользователя";
            this.addCustomerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.addButton.Enabled = false;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(12, 309);
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
            this.passwordLabel.Size = new System.Drawing.Size(82, 24);
            this.passwordLabel.TabIndex = 20;
            this.passwordLabel.Text = "Пароль";
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
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 359);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.password);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.email);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.name);
            this.Controls.Add(this.addPicture);
            this.Controls.Add(this.addCustomerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление пользователя";
            ((System.ComponentModel.ISupportInitialize)(this.addPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox addPicture;
        private System.Windows.Forms.Label addCustomerLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button addButton;
        private cinema_onlineDataSetTableAdapters.directorsTableAdapter directorsTableAdapter;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox password;
        private cinema_onlineDataSetTableAdapters.customersTableAdapter customersTableAdapter;
    }
}