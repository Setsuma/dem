using System.Drawing;
using System.Windows.Forms;

namespace OnlineCinemaDB
{
    partial class Authorization
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.authorizationLabel = new System.Windows.Forms.Label();
            this.loginInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.signInButton = new System.Windows.Forms.Button();
            this.signUpButton = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.hideButton = new System.Windows.Forms.Button();
            this.authorizationPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.authorizationPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // authorizationLabel
            // 
            this.authorizationLabel.BackColor = System.Drawing.Color.Silver;
            this.authorizationLabel.Font = new System.Drawing.Font("Segoe UI", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorizationLabel.Location = new System.Drawing.Point(167, 0);
            this.authorizationLabel.Name = "authorizationLabel";
            this.authorizationLabel.Size = new System.Drawing.Size(514, 146);
            this.authorizationLabel.TabIndex = 1;
            this.authorizationLabel.Text = "Авторизация";
            this.authorizationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loginInput
            // 
            this.loginInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginInput.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginInput.Location = new System.Drawing.Point(222, 204);
            this.loginInput.MaxLength = 32;
            this.loginInput.Name = "loginInput";
            this.loginInput.Size = new System.Drawing.Size(258, 57);
            this.loginInput.TabIndex = 2;
            this.loginInput.TextChanged += new System.EventHandler(this.authorization_TextChanged);
            this.loginInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.authorization_KeyPress);
            // 
            // passwordInput
            // 
            this.passwordInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordInput.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordInput.Location = new System.Drawing.Point(222, 277);
            this.passwordInput.MaxLength = 32;
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(258, 57);
            this.passwordInput.TabIndex = 3;
            this.passwordInput.UseSystemPasswordChar = true;
            this.passwordInput.TextChanged += new System.EventHandler(this.authorization_TextChanged);
            this.passwordInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.authorization_KeyPress);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(82, 206);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(134, 50);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "Логин:";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(58, 279);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(158, 50);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Пароль:";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // signInButton
            // 
            this.signInButton.Enabled = false;
            this.signInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInButton.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signInButton.Location = new System.Drawing.Point(255, 358);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(181, 61);
            this.signInButton.TabIndex = 6;
            this.signInButton.Text = "Войти";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.AutoSize = true;
            this.signUpButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signUpButton.ForeColor = System.Drawing.Color.DimGray;
            this.signUpButton.Location = new System.Drawing.Point(260, 429);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(172, 25);
            this.signUpButton.TabIndex = 7;
            this.signUpButton.Text = "Ещё нет аккаунта?";
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            this.signUpButton.MouseEnter += new System.EventHandler(this.signUpButton_MouseEnter);
            this.signUpButton.MouseLeave += new System.EventHandler(this.signUpButton_MouseLeave);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Silver;
            this.clearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Image = global::OnlineCinemaDB.Properties.Resources.clear;
            this.clearButton.Location = new System.Drawing.Point(558, 35);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(80, 80);
            this.clearButton.TabIndex = 10;
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // showButton
            // 
            this.showButton.BackColor = System.Drawing.Color.Transparent;
            this.showButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.showButton.FlatAppearance.BorderSize = 0;
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showButton.ForeColor = System.Drawing.Color.Transparent;
            this.showButton.Image = global::OnlineCinemaDB.Properties.Resources.show;
            this.showButton.Location = new System.Drawing.Point(486, 279);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(55, 55);
            this.showButton.TabIndex = 9;
            this.showButton.UseVisualStyleBackColor = false;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // hideButton
            // 
            this.hideButton.BackColor = System.Drawing.Color.Transparent;
            this.hideButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hideButton.FlatAppearance.BorderSize = 0;
            this.hideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideButton.ForeColor = System.Drawing.Color.Transparent;
            this.hideButton.Image = global::OnlineCinemaDB.Properties.Resources.hide;
            this.hideButton.Location = new System.Drawing.Point(486, 279);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(55, 55);
            this.hideButton.TabIndex = 8;
            this.hideButton.UseVisualStyleBackColor = false;
            this.hideButton.Visible = false;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // authorizationPicture
            // 
            this.authorizationPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.authorizationPicture.Image = ((System.Drawing.Image)(resources.GetObject("authorizationPicture.Image")));
            this.authorizationPicture.Location = new System.Drawing.Point(12, 1);
            this.authorizationPicture.Name = "authorizationPicture";
            this.authorizationPicture.Size = new System.Drawing.Size(149, 146);
            this.authorizationPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.authorizationPicture.TabIndex = 0;
            this.authorizationPicture.TabStop = false;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 486);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.hideButton);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.loginInput);
            this.Controls.Add(this.authorizationLabel);
            this.Controls.Add(this.authorizationPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.VisibleChanged += new System.EventHandler(this.Authorization_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.authorizationPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox authorizationPicture;
        private Label authorizationLabel;
        private TextBox loginInput;
        private TextBox passwordInput;
        private Label loginLabel;
        private Label passwordLabel;
        private Button signInButton;
        private Label signUpButton;
        private Button hideButton;
        private Button showButton;
        private Button clearButton;
    }
}
