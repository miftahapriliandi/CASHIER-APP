using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "KSR001" && textBox2.Text == "12345")
            {
                FormHome frmHome = new FormHome();
                frmHome.Show();
            }
            else
            {
                MessageBox.Show("Kode / Password Anda salah!");
            }
        }
    }
}
