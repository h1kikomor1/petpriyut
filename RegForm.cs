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
    public partial class RegForm : Form
    {
        string connectionString = "Data Source=LAPTOP-J7ESJQ5V;Initial Catalog=Auth;Integrated Security=True";

        DataSet ds;
        SqlDataAdapter adapter;
        string sql = "SELECT * FROM users";
        public RegForm()
        {
            InitializeComponent();
        }

        private void reg_button_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            if (String.Equals(Password_textBox.Text, checkpass_textBox.Text))
            {
                string sql = String.Format("INSERT INTO [dbo].[users] ([login] ,[password] ,[Priv]) VALUES ('{0}', '{1}', '{2}')", Login_textBox.Text, Password_textBox.Text, "User");
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Регистрация завершена!");
                AuthForm authForm = new AuthForm();
                this.Hide();
                authForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Регистрация не завершена!");
            }
            connection.Close();
        }
    }
}
