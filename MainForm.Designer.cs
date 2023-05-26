
namespace WindowsFormsApp4
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.Priyut_label = new System.Windows.Forms.Label();
            this.welcome_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.petPriyutDataSet = new WindowsFormsApp4.PetPriyutDataSet();
            this.petTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petTableTableAdapter = new WindowsFormsApp4.PetPriyutDataSetTableAdapters.PetTableTableAdapter();
            this.pettypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petcharacterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addpet_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petPriyutDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Priyut_label
            // 
            this.Priyut_label.AutoSize = true;
            this.Priyut_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Priyut_label.Location = new System.Drawing.Point(230, 9);
            this.Priyut_label.Name = "Priyut_label";
            this.Priyut_label.Size = new System.Drawing.Size(442, 39);
            this.Priyut_label.TabIndex = 1;
            this.Priyut_label.Text = "ПРИЮТ ДЛЯ ЖИВОТНЫХ";
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcome_label.Location = new System.Drawing.Point(248, 57);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(402, 39);
            this.welcome_label.TabIndex = 2;
            this.welcome_label.Text = "ДОБРО ПОЖАЛОВАТЬ!";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pettypeDataGridViewTextBoxColumn,
            this.petnameDataGridViewTextBoxColumn,
            this.petageDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.petcharacterDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.petTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(411, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1001, 316);
            this.dataGridView1.TabIndex = 3;
            // 
            // petPriyutDataSet
            // 
            this.petPriyutDataSet.DataSetName = "PetPriyutDataSet";
            this.petPriyutDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // petTableBindingSource
            // 
            this.petTableBindingSource.DataMember = "PetTable";
            this.petTableBindingSource.DataSource = this.petPriyutDataSet;
            // 
            // petTableTableAdapter
            // 
            this.petTableTableAdapter.ClearBeforeFill = true;
            // 
            // pettypeDataGridViewTextBoxColumn
            // 
            this.pettypeDataGridViewTextBoxColumn.DataPropertyName = "pet_type";
            this.pettypeDataGridViewTextBoxColumn.HeaderText = "pet_type";
            this.pettypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pettypeDataGridViewTextBoxColumn.Name = "pettypeDataGridViewTextBoxColumn";
            this.pettypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // petnameDataGridViewTextBoxColumn
            // 
            this.petnameDataGridViewTextBoxColumn.DataPropertyName = "pet_name";
            this.petnameDataGridViewTextBoxColumn.HeaderText = "pet_name";
            this.petnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.petnameDataGridViewTextBoxColumn.Name = "petnameDataGridViewTextBoxColumn";
            this.petnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // petageDataGridViewTextBoxColumn
            // 
            this.petageDataGridViewTextBoxColumn.DataPropertyName = "pet_age";
            this.petageDataGridViewTextBoxColumn.HeaderText = "pet_age";
            this.petageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.petageDataGridViewTextBoxColumn.Name = "petageDataGridViewTextBoxColumn";
            this.petageDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // petcharacterDataGridViewTextBoxColumn
            // 
            this.petcharacterDataGridViewTextBoxColumn.DataPropertyName = "pet_character";
            this.petcharacterDataGridViewTextBoxColumn.HeaderText = "pet_character";
            this.petcharacterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.petcharacterDataGridViewTextBoxColumn.Name = "petcharacterDataGridViewTextBoxColumn";
            this.petcharacterDataGridViewTextBoxColumn.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp4.Properties.Resources.Без_названия;
            this.pictureBox1.Location = new System.Drawing.Point(45, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 279);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // addpet_button
            // 
            this.addpet_button.Location = new System.Drawing.Point(757, 24);
            this.addpet_button.Name = "addpet_button";
            this.addpet_button.Size = new System.Drawing.Size(175, 61);
            this.addpet_button.TabIndex = 5;
            this.addpet_button.Text = "Добавить";
            this.addpet_button.UseVisualStyleBackColor = true;
            this.addpet_button.Click += new System.EventHandler(this.addpet_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 488);
            this.Controls.Add(this.addpet_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.Priyut_label);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petPriyutDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Priyut_label;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PetPriyutDataSet petPriyutDataSet;
        private System.Windows.Forms.BindingSource petTableBindingSource;
        private PetPriyutDataSetTableAdapters.PetTableTableAdapter petTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pettypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petcharacterDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addpet_button;
    }
}