using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "petPriyutDataSet.PetTable". При необходимости она может быть перемещена или удалена.
            this.petTableTableAdapter.Fill(this.petPriyutDataSet.PetTable);

        }

        private void addpet_button_Click(object sender, EventArgs e)
        {

        }
    }
}
