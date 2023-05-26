
namespace WindowsFormsApp4
{
    partial class AddPetForm
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
            this.nameform_label = new System.Windows.Forms.Label();
            this.pettype_label = new System.Windows.Forms.Label();
            this.pettype_textBox = new System.Windows.Forms.TextBox();
            this.petname_textBox = new System.Windows.Forms.TextBox();
            this.petname_label = new System.Windows.Forms.Label();
            this.petage_textBox = new System.Windows.Forms.TextBox();
            this.petage_label = new System.Windows.Forms.Label();
            this.phonenumber_textBox = new System.Windows.Forms.TextBox();
            this.phonenumber_label = new System.Windows.Forms.Label();
            this.petopisanie_textBox = new System.Windows.Forms.TextBox();
            this.petopisanie_label = new System.Windows.Forms.Label();
            this.petadd_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameform_label
            // 
            this.nameform_label.AutoSize = true;
            this.nameform_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameform_label.Location = new System.Drawing.Point(22, 24);
            this.nameform_label.Name = "nameform_label";
            this.nameform_label.Size = new System.Drawing.Size(959, 48);
            this.nameform_label.TabIndex = 0;
            this.nameform_label.Text = "ДОБАВЛЕНИЕ ЖИВОТНОГО В БАЗУ ДАННЫХ";
            // 
            // pettype_label
            // 
            this.pettype_label.AutoSize = true;
            this.pettype_label.Location = new System.Drawing.Point(214, 131);
            this.pettype_label.Name = "pettype_label";
            this.pettype_label.Size = new System.Drawing.Size(69, 17);
            this.pettype_label.TabIndex = 1;
            this.pettype_label.Text = "Pet Type:";
            // 
            // pettype_textBox
            // 
            this.pettype_textBox.Location = new System.Drawing.Point(332, 131);
            this.pettype_textBox.Name = "pettype_textBox";
            this.pettype_textBox.Size = new System.Drawing.Size(258, 22);
            this.pettype_textBox.TabIndex = 2;
            // 
            // petname_textBox
            // 
            this.petname_textBox.Location = new System.Drawing.Point(332, 171);
            this.petname_textBox.Name = "petname_textBox";
            this.petname_textBox.Size = new System.Drawing.Size(258, 22);
            this.petname_textBox.TabIndex = 4;
            // 
            // petname_label
            // 
            this.petname_label.AutoSize = true;
            this.petname_label.Location = new System.Drawing.Point(214, 171);
            this.petname_label.Name = "petname_label";
            this.petname_label.Size = new System.Drawing.Size(74, 17);
            this.petname_label.TabIndex = 3;
            this.petname_label.Text = "Pet Name:";
            // 
            // petage_textBox
            // 
            this.petage_textBox.Location = new System.Drawing.Point(332, 210);
            this.petage_textBox.Name = "petage_textBox";
            this.petage_textBox.Size = new System.Drawing.Size(258, 22);
            this.petage_textBox.TabIndex = 6;
            // 
            // petage_label
            // 
            this.petage_label.AutoSize = true;
            this.petage_label.Location = new System.Drawing.Point(214, 210);
            this.petage_label.Name = "petage_label";
            this.petage_label.Size = new System.Drawing.Size(62, 17);
            this.petage_label.TabIndex = 5;
            this.petage_label.Text = "Pet Age:";
            // 
            // phonenumber_textBox
            // 
            this.phonenumber_textBox.Location = new System.Drawing.Point(332, 255);
            this.phonenumber_textBox.Name = "phonenumber_textBox";
            this.phonenumber_textBox.Size = new System.Drawing.Size(258, 22);
            this.phonenumber_textBox.TabIndex = 8;
            // 
            // phonenumber_label
            // 
            this.phonenumber_label.AutoSize = true;
            this.phonenumber_label.Location = new System.Drawing.Point(214, 255);
            this.phonenumber_label.Name = "phonenumber_label";
            this.phonenumber_label.Size = new System.Drawing.Size(107, 17);
            this.phonenumber_label.TabIndex = 7;
            this.phonenumber_label.Text = "Phone Number:";
            // 
            // petopisanie_textBox
            // 
            this.petopisanie_textBox.Location = new System.Drawing.Point(332, 297);
            this.petopisanie_textBox.Multiline = true;
            this.petopisanie_textBox.Name = "petopisanie_textBox";
            this.petopisanie_textBox.Size = new System.Drawing.Size(258, 69);
            this.petopisanie_textBox.TabIndex = 10;
            // 
            // petopisanie_label
            // 
            this.petopisanie_label.AutoSize = true;
            this.petopisanie_label.Location = new System.Drawing.Point(214, 297);
            this.petopisanie_label.Name = "petopisanie_label";
            this.petopisanie_label.Size = new System.Drawing.Size(103, 17);
            this.petopisanie_label.TabIndex = 9;
            this.petopisanie_label.Text = "Pet Описание:";
            // 
            // petadd_button
            // 
            this.petadd_button.Location = new System.Drawing.Point(393, 386);
            this.petadd_button.Name = "petadd_button";
            this.petadd_button.Size = new System.Drawing.Size(137, 47);
            this.petadd_button.TabIndex = 11;
            this.petadd_button.Text = "Добавить животное";
            this.petadd_button.UseVisualStyleBackColor = true;
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(30, 386);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(137, 47);
            this.back_button.TabIndex = 12;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // AddPetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 464);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.petadd_button);
            this.Controls.Add(this.petopisanie_textBox);
            this.Controls.Add(this.petopisanie_label);
            this.Controls.Add(this.phonenumber_textBox);
            this.Controls.Add(this.phonenumber_label);
            this.Controls.Add(this.petage_textBox);
            this.Controls.Add(this.petage_label);
            this.Controls.Add(this.petname_textBox);
            this.Controls.Add(this.petname_label);
            this.Controls.Add(this.pettype_textBox);
            this.Controls.Add(this.pettype_label);
            this.Controls.Add(this.nameform_label);
            this.Name = "AddPetForm";
            this.Text = "AddPetForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameform_label;
        private System.Windows.Forms.Label pettype_label;
        private System.Windows.Forms.TextBox pettype_textBox;
        private System.Windows.Forms.TextBox petname_textBox;
        private System.Windows.Forms.Label petname_label;
        private System.Windows.Forms.TextBox petage_textBox;
        private System.Windows.Forms.Label petage_label;
        private System.Windows.Forms.TextBox phonenumber_textBox;
        private System.Windows.Forms.Label phonenumber_label;
        private System.Windows.Forms.TextBox petopisanie_textBox;
        private System.Windows.Forms.Label petopisanie_label;
        private System.Windows.Forms.Button petadd_button;
        private System.Windows.Forms.Button back_button;
    }
}