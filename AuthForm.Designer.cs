
namespace WindowsFormsApp4
{
    partial class AuthForm
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
            this.Priyut_label = new System.Windows.Forms.Label();
            this.Auth_label = new System.Windows.Forms.Label();
            this.Login_textBox = new System.Windows.Forms.TextBox();
            this.Login_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.auth_button = new System.Windows.Forms.Button();
            this.reg_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Priyut_label
            // 
            this.Priyut_label.AutoSize = true;
            this.Priyut_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Priyut_label.Location = new System.Drawing.Point(30, 21);
            this.Priyut_label.Name = "Priyut_label";
            this.Priyut_label.Size = new System.Drawing.Size(442, 39);
            this.Priyut_label.TabIndex = 0;
            this.Priyut_label.Text = "ПРИЮТ ДЛЯ ЖИВОТНЫХ";
            this.Priyut_label.Click += new System.EventHandler(this.Priyut_label_Click);
            // 
            // Auth_label
            // 
            this.Auth_label.AutoSize = true;
            this.Auth_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Auth_label.Location = new System.Drawing.Point(105, 89);
            this.Auth_label.Name = "Auth_label";
            this.Auth_label.Size = new System.Drawing.Size(278, 39);
            this.Auth_label.TabIndex = 1;
            this.Auth_label.Text = "АВТОРИЗАЦИЯ";
            this.Auth_label.Click += new System.EventHandler(this.Auth_label_Click);
            // 
            // Login_textBox
            // 
            this.Login_textBox.Location = new System.Drawing.Point(208, 193);
            this.Login_textBox.Name = "Login_textBox";
            this.Login_textBox.Size = new System.Drawing.Size(210, 22);
            this.Login_textBox.TabIndex = 2;
            this.Login_textBox.TextChanged += new System.EventHandler(this.Login_textBox_TextChanged);
            // 
            // Login_label
            // 
            this.Login_label.AutoSize = true;
            this.Login_label.Location = new System.Drawing.Point(91, 193);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(47, 17);
            this.Login_label.TabIndex = 3;
            this.Login_label.Text = "Login:";
            this.Login_label.Click += new System.EventHandler(this.Login_label_Click);
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(91, 233);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(73, 17);
            this.Password_label.TabIndex = 5;
            this.Password_label.Text = "Password:";
            this.Password_label.Click += new System.EventHandler(this.Password_label_Click);
            // 
            // Password_textBox
            // 
            this.Password_textBox.Location = new System.Drawing.Point(208, 233);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(210, 22);
            this.Password_textBox.TabIndex = 4;
            this.Password_textBox.TextChanged += new System.EventHandler(this.Password_textBox_TextChanged);
            // 
            // auth_button
            // 
            this.auth_button.Location = new System.Drawing.Point(143, 285);
            this.auth_button.Name = "auth_button";
            this.auth_button.Size = new System.Drawing.Size(180, 46);
            this.auth_button.TabIndex = 6;
            this.auth_button.Text = "Авторизация";
            this.auth_button.UseVisualStyleBackColor = true;
            this.auth_button.Click += new System.EventHandler(this.auth_button_Click);
            // 
            // reg_button
            // 
            this.reg_button.Location = new System.Drawing.Point(143, 349);
            this.reg_button.Name = "reg_button";
            this.reg_button.Size = new System.Drawing.Size(180, 46);
            this.reg_button.TabIndex = 7;
            this.reg_button.Text = "Регистрация";
            this.reg_button.UseVisualStyleBackColor = true;
            this.reg_button.Click += new System.EventHandler(this.reg_button_Click);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.reg_button);
            this.Controls.Add(this.auth_button);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.Login_label);
            this.Controls.Add(this.Login_textBox);
            this.Controls.Add(this.Auth_label);
            this.Controls.Add(this.Priyut_label);
            this.Name = "AuthForm";
            this.Text = "AuthForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Priyut_label;
        private System.Windows.Forms.Label Auth_label;
        private System.Windows.Forms.TextBox Login_textBox;
        private System.Windows.Forms.Label Login_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.Button auth_button;
        private System.Windows.Forms.Button reg_button;
    }
}

