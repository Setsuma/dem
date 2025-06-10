namespace OnlineCinemaDB
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.registrationLabel = new System.Windows.Forms.Label();
            this.registrationButton = new System.Windows.Forms.Button();
            this.passwordRegLabel = new System.Windows.Forms.Label();
            this.loginRegLabel = new System.Windows.Forms.Label();
            this.passwordRegInput = new System.Windows.Forms.TextBox();
            this.loginRegInput = new System.Windows.Forms.TextBox();
            this.repeatPasswordRegLabel = new System.Windows.Forms.Label();
            this.passwordRepeatRegInput = new System.Windows.Forms.TextBox();
            this.nameRegLabel = new System.Windows.Forms.Label();
            this.nameRegInput = new System.Windows.Forms.TextBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.showRegButton = new System.Windows.Forms.Button();
            this.hideRegButton = new System.Windows.Forms.Button();
            this.registrationPicture = new System.Windows.Forms.PictureBox();
            this.clearRegButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.registrationPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // registrationLabel
            // 
            this.registrationLabel.BackColor = System.Drawing.Color.Silver;
            this.registrationLabel.Font = new System.Drawing.Font("Segoe UI", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationLabel.Location = new System.Drawing.Point(167, 0);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(514, 146);
            this.registrationLabel.TabIndex = 2;
            this.registrationLabel.Text = "Регистрация";
            this.registrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // registrationButton
            // 
            this.registrationButton.Enabled = false;
            this.registrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationButton.Location = new System.Drawing.Point(253, 512);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(258, 61);
            this.registrationButton.TabIndex = 14;
            this.registrationButton.Text = "Зарегистрироваться";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // passwordRegLabel
            // 
            this.passwordRegLabel.AutoSize = true;
            this.passwordRegLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordRegLabel.Location = new System.Drawing.Point(89, 333);
            this.passwordRegLabel.Name = "passwordRegLabel";
            this.passwordRegLabel.Size = new System.Drawing.Size(158, 50);
            this.passwordRegLabel.TabIndex = 13;
            this.passwordRegLabel.Text = "Пароль:";
            this.passwordRegLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // loginRegLabel
            // 
            this.loginRegLabel.AutoSize = true;
            this.loginRegLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginRegLabel.Location = new System.Drawing.Point(113, 175);
            this.loginRegLabel.Name = "loginRegLabel";
            this.loginRegLabel.Size = new System.Drawing.Size(134, 50);
            this.loginRegLabel.TabIndex = 12;
            this.loginRegLabel.Text = "Логин:";
            this.loginRegLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passwordRegInput
            // 
            this.passwordRegInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordRegInput.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordRegInput.Location = new System.Drawing.Point(253, 331);
            this.passwordRegInput.MaxLength = 32;
            this.passwordRegInput.Name = "passwordRegInput";
            this.passwordRegInput.Size = new System.Drawing.Size(258, 57);
            this.passwordRegInput.TabIndex = 11;
            this.passwordRegInput.UseSystemPasswordChar = true;
            this.passwordRegInput.TextChanged += new System.EventHandler(this.registration_TextChanged);
            this.passwordRegInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.registration_KeyPress);
            // 
            // loginRegInput
            // 
            this.loginRegInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginRegInput.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginRegInput.Location = new System.Drawing.Point(253, 173);
            this.loginRegInput.MaxLength = 32;
            this.loginRegInput.Name = "loginRegInput";
            this.loginRegInput.Size = new System.Drawing.Size(258, 57);
            this.loginRegInput.TabIndex = 10;
            this.loginRegInput.TextChanged += new System.EventHandler(this.registration_TextChanged);
            this.loginRegInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.registration_KeyPress);
            // 
            // repeatPasswordRegLabel
            // 
            this.repeatPasswordRegLabel.AutoSize = true;
            this.repeatPasswordRegLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repeatPasswordRegLabel.Location = new System.Drawing.Point(42, 397);
            this.repeatPasswordRegLabel.Name = "repeatPasswordRegLabel";
            this.repeatPasswordRegLabel.Size = new System.Drawing.Size(205, 100);
            this.repeatPasswordRegLabel.TabIndex = 18;
            this.repeatPasswordRegLabel.Text = "Повторите\r\nПароль:";
            this.repeatPasswordRegLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passwordRepeatRegInput
            // 
            this.passwordRepeatRegInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordRepeatRegInput.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordRepeatRegInput.Location = new System.Drawing.Point(253, 420);
            this.passwordRepeatRegInput.MaxLength = 32;
            this.passwordRepeatRegInput.Name = "passwordRepeatRegInput";
            this.passwordRepeatRegInput.Size = new System.Drawing.Size(258, 57);
            this.passwordRepeatRegInput.TabIndex = 17;
            this.passwordRepeatRegInput.UseSystemPasswordChar = true;
            this.passwordRepeatRegInput.TextChanged += new System.EventHandler(this.registration_TextChanged);
            this.passwordRepeatRegInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.registration_KeyPress);
            // 
            // nameRegLabel
            // 
            this.nameRegLabel.AutoSize = true;
            this.nameRegLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameRegLabel.Location = new System.Drawing.Point(144, 253);
            this.nameRegLabel.Name = "nameRegLabel";
            this.nameRegLabel.Size = new System.Drawing.Size(103, 50);
            this.nameRegLabel.TabIndex = 21;
            this.nameRegLabel.Text = "Имя:";
            this.nameRegLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameRegInput
            // 
            this.nameRegInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameRegInput.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameRegInput.Location = new System.Drawing.Point(253, 251);
            this.nameRegInput.MaxLength = 32;
            this.nameRegInput.Name = "nameRegInput";
            this.nameRegInput.Size = new System.Drawing.Size(258, 57);
            this.nameRegInput.TabIndex = 20;
            this.nameRegInput.TextChanged += new System.EventHandler(this.registration_TextChanged);
            // 
            // returnButton
            // 
            this.returnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.returnButton.FlatAppearance.BorderSize = 0;
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Image = global::OnlineCinemaDB.Properties.Resources._return;
            this.returnButton.Location = new System.Drawing.Point(12, 534);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(50, 50);
            this.returnButton.TabIndex = 19;
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // showRegButton
            // 
            this.showRegButton.BackColor = System.Drawing.Color.Transparent;
            this.showRegButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.showRegButton.FlatAppearance.BorderSize = 0;
            this.showRegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showRegButton.ForeColor = System.Drawing.Color.Transparent;
            this.showRegButton.Image = global::OnlineCinemaDB.Properties.Resources.show;
            this.showRegButton.Location = new System.Drawing.Point(517, 333);
            this.showRegButton.Name = "showRegButton";
            this.showRegButton.Size = new System.Drawing.Size(55, 55);
            this.showRegButton.TabIndex = 16;
            this.showRegButton.UseVisualStyleBackColor = false;
            this.showRegButton.Click += new System.EventHandler(this.showRegButton_Click);
            // 
            // hideRegButton
            // 
            this.hideRegButton.BackColor = System.Drawing.Color.Transparent;
            this.hideRegButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hideRegButton.FlatAppearance.BorderSize = 0;
            this.hideRegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideRegButton.ForeColor = System.Drawing.Color.Transparent;
            this.hideRegButton.Image = global::OnlineCinemaDB.Properties.Resources.hide;
            this.hideRegButton.Location = new System.Drawing.Point(517, 333);
            this.hideRegButton.Name = "hideRegButton";
            this.hideRegButton.Size = new System.Drawing.Size(55, 55);
            this.hideRegButton.TabIndex = 15;
            this.hideRegButton.UseVisualStyleBackColor = false;
            this.hideRegButton.Visible = false;
            this.hideRegButton.Click += new System.EventHandler(this.hideRegButton_Click);
            // 
            // registrationPicture
            // 
            this.registrationPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.registrationPicture.Image = global::OnlineCinemaDB.Properties.Resources.registration;
            this.registrationPicture.Location = new System.Drawing.Point(12, 0);
            this.registrationPicture.Name = "registrationPicture";
            this.registrationPicture.Size = new System.Drawing.Size(149, 146);
            this.registrationPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.registrationPicture.TabIndex = 3;
            this.registrationPicture.TabStop = false;
            // 
            // clearRegButton
            // 
            this.clearRegButton.BackColor = System.Drawing.Color.Silver;
            this.clearRegButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clearRegButton.FlatAppearance.BorderSize = 0;
            this.clearRegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearRegButton.Image = global::OnlineCinemaDB.Properties.Resources.clear;
            this.clearRegButton.Location = new System.Drawing.Point(558, 35);
            this.clearRegButton.Name = "clearRegButton";
            this.clearRegButton.Size = new System.Drawing.Size(80, 80);
            this.clearRegButton.TabIndex = 22;
            this.clearRegButton.UseVisualStyleBackColor = false;
            this.clearRegButton.Click += new System.EventHandler(this.clearRegButton_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 596);
            this.Controls.Add(this.clearRegButton);
            this.Controls.Add(this.nameRegLabel);
            this.Controls.Add(this.nameRegInput);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.repeatPasswordRegLabel);
            this.Controls.Add(this.passwordRepeatRegInput);
            this.Controls.Add(this.showRegButton);
            this.Controls.Add(this.hideRegButton);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.passwordRegLabel);
            this.Controls.Add(this.loginRegLabel);
            this.Controls.Add(this.passwordRegInput);
            this.Controls.Add(this.loginRegInput);
            this.Controls.Add(this.registrationPicture);
            this.Controls.Add(this.registrationLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registration_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.registrationPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.PictureBox registrationPicture;
        private System.Windows.Forms.Button showRegButton;
        private System.Windows.Forms.Button hideRegButton;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Label passwordRegLabel;
        private System.Windows.Forms.Label loginRegLabel;
        private System.Windows.Forms.TextBox passwordRegInput;
        private System.Windows.Forms.TextBox loginRegInput;
        private System.Windows.Forms.Label repeatPasswordRegLabel;
        private System.Windows.Forms.TextBox passwordRepeatRegInput;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label nameRegLabel;
        private System.Windows.Forms.TextBox nameRegInput;
        private System.Windows.Forms.Button clearRegButton;
    }
}