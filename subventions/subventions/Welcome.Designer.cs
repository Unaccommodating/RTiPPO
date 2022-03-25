namespace subventions
{
    partial class Welcome
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.enter = new System.Windows.Forms.Button();
            this.registration = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.LoginText = new System.Windows.Forms.Label();
            this.Psw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enter
            // 
            this.enter.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter.Location = new System.Drawing.Point(222, 263);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(357, 40);
            this.enter.TabIndex = 1;
            this.enter.Text = "ВОЙТИ";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // registration
            // 
            this.registration.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registration.Location = new System.Drawing.Point(222, 334);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(357, 40);
            this.registration.TabIndex = 2;
            this.registration.Text = "ЗАРЕГЕСТРИРОВАТЬСЯ";
            this.registration.UseVisualStyleBackColor = true;
            this.registration.Click += new System.EventHandler(this.registration_Click);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(222, 107);
            this.login.Multiline = true;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(357, 40);
            this.login.TabIndex = 0;
            this.login.TextChanged += new System.EventHandler(this.Login_TextChanged);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(222, 192);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(357, 40);
            this.password.TabIndex = 0;
            this.password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // LoginText
            // 
            this.LoginText.AutoSize = true;
            this.LoginText.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginText.Location = new System.Drawing.Point(218, 81);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(62, 23);
            this.LoginText.TabIndex = 3;
            this.LoginText.Text = "Логин";
            this.LoginText.Click += new System.EventHandler(this.label1_Click);
            // 
            // Psw
            // 
            this.Psw.AutoSize = true;
            this.Psw.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Psw.Location = new System.Drawing.Point(218, 166);
            this.Psw.Name = "Psw";
            this.Psw.Size = new System.Drawing.Size(73, 23);
            this.Psw.TabIndex = 4;
            this.Psw.Text = "Пароль";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Psw);
            this.Controls.Add(this.LoginText);
            this.Controls.Add(this.registration);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Name = "Welcome";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button registration;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label LoginText;
        private System.Windows.Forms.Label Psw;
    }
}

