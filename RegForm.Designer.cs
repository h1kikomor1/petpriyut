
namespace WindowsFormsApp4
{
    partial class RegForm
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
            this.reg_button = new System.Windows.Forms.Button();
            this.Password_label = new System.Windows.Forms.Label();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Login_label = new System.Windows.Forms.Label();
            this.Login_textBox = new System.Windows.Forms.TextBox();
            this.reg_label = new System.Windows.Forms.Label();
            this.Priyut_label = new System.Windows.Forms.Label();
            this.CheckPass_label = new System.Windows.Forms.Label();
            this.checkpass_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // reg_button
            // 
            this.reg_button.Location = new System.Drawing.Point(131, 329);
            this.reg_button.Name = "reg_button";
            this.reg_button.Size = new System.Drawing.Size(180, 46);
            this.reg_button.TabIndex = 14;
            this.reg_button.Text = "Регистрация";
            this.reg_button.UseVisualStyleBackColor = true;
            this.reg_button.Click += new System.EventHandler(this.reg_button_Click);
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(81, 226);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(73, 17);
            this.Password_label.TabIndex = 13;
            this.Password_label.Text = "Password:";
            // 
            // Password_textBox
            // 
            this.Password_textBox.Location = new System.Drawing.Point(198, 226);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(210, 22);
            this.Password_textBox.TabIndex = 12;
            // 
            // Login_label
            // 
            this.Login_label.AutoSize = true;
            this.Login_label.Location = new System.Drawing.Point(81, 186);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(47, 17);
            this.Login_label.TabIndex = 11;
            this.Login_label.Text = "Login:";
            // 
            // Login_textBox
            // 
            this.Login_textBox.Location = new System.Drawing.Point(198, 186);
            this.Login_textBox.Name = "Login_textBox";
            this.Login_textBox.Size = new System.Drawing.Size(210, 22);
            this.Login_textBox.TabIndex = 10;
            // 
            // reg_label
            // 
            this.reg_label.AutoSize = true;
            this.reg_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reg_label.Location = new System.Drawing.Point(95, 82);
            this.reg_label.Name = "reg_label";
            this.reg_label.Size = new System.Drawing.Size(274, 39);
            this.reg_label.TabIndex = 9;
            this.reg_label.Text = "РЕГИСТРАЦИЯ";
            // 
            // Priyut_label
            // 
            this.Priyut_label.AutoSize = true;
            this.Priyut_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Priyut_label.Location = new System.Drawing.Point(20, 14);
            this.Priyut_label.Name = "Priyut_label";
            this.Priyut_label.Size = new System.Drawing.Size(442, 39);
            this.Priyut_label.TabIndex = 8;
            this.Priyut_label.Text = "ПРИЮТ ДЛЯ ЖИВОТНЫХ";
            // 
            // CheckPass_label
            // 
            this.CheckPass_label.AutoSize = true;
            this.CheckPass_label.Location = new System.Drawing.Point(81, 272);
            this.CheckPass_label.Name = "CheckPass_label";
            this.CheckPass_label.Size = new System.Drawing.Size(112, 17);
            this.CheckPass_label.TabIndex = 16;
            this.CheckPass_label.Text = "CheckPassword:";
            // 
            // checkpass_textBox
            // 
            this.checkpass_textBox.Location = new System.Drawing.Point(198, 272);
            this.checkpass_textBox.Name = "checkpass_textBox";
            this.checkpass_textBox.Size = new System.Drawing.Size(210, 22);
            this.checkpass_textBox.TabIndex = 15;
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 413);
            this.Controls.Add(this.CheckPass_label);
            this.Controls.Add(this.checkpass_textBox);
            this.Controls.Add(this.reg_button);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.Login_label);
            this.Controls.Add(this.Login_textBox);
            this.Controls.Add(this.reg_label);
            this.Controls.Add(this.Priyut_label);
            this.Name = "RegForm";
            this.Text = "RegForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reg_button;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.Label Login_label;
        private System.Windows.Forms.TextBox Login_textBox;
        private System.Windows.Forms.Label reg_label;
        private System.Windows.Forms.Label Priyut_label;
        private System.Windows.Forms.Label CheckPass_label;
        private System.Windows.Forms.TextBox checkpass_textBox;
    }
}