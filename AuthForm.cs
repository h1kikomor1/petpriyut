using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp4
{
    public partial class AuthForm : Form
    {
        string connectionString = "Data Source=LAPTOP-J7ESJQ5V;Initial Catalog=Auth;Integrated Security=True";

        DataSet ds;
        SqlDataAdapter adapter;
        string sql = "SELECT * FROM users";
        public AuthForm()
        {
            InitializeComponent();
        }

        private void auth_button_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            adapter = new SqlDataAdapter(sql, connection);
            ds = new DataSet();
            adapter.Fill(ds);
            bool flag = false;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (String.Equals(Login_textBox.Text.ToString(), ds.Tables[0].Rows[i][0].ToString()) && String.Equals(Password_textBox.Text.ToString(), ds.Tables[0].Rows[i][1].ToString()))
                {
                    MessageBox.Show("Авторизация завершена!");
                    flag = true;

                    MainForm mainForm = new MainForm();
                    this.Hide();
                    mainForm.Show();
                    break;
                }
                if (!flag) MessageBox.Show("Авторизация провалена");
            }
            connection.Close();
        }

        private void reg_button_Click(object sender, EventArgs e)
        {
            RegForm regForm = new RegForm();
            regForm.Show();
            this.Hide();
        }

        private void Priyut_label_Click(object sender, EventArgs e)
        {

        }

        private void Auth_label_Click(object sender, EventArgs e)
        {

        }

        private void Login_label_Click(object sender, EventArgs e)
        {

        }

        private void Login_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_label_Click(object sender, EventArgs e)
        {

        }

        private void Password_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
