using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; 


namespace CashierApp
{
    public partial class FormLogin : Form
    {
        
        public FormLogin()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection("server=localhost; user=root; password=; database=kasir; port=3306; SslMode=none");
        int count;

        private void button1_Click(object sender, EventArgs e)
        {
            string username, password;
            username = txtuser.Text;
            password = txtpass.Text;

            count = count + 1;

            if(count > 3)
            {
                MessageBox.Show("System blocked !", "Blocked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            else if(username == "" && password == "")
            {
                label3.Text = "Please fill username and password";
            }

            else
            {
                string query = "select * from users where username = '" + username + "' AND password = '" + password + "'";
                
                MySqlDataAdapter data = new MySqlDataAdapter(query, conn);

                DataTable dt = new DataTable();

                data.Fill(dt);

                if(dt.Rows.Count == 1)
                {
                    Main ma = new Main();
                    this.Hide();
                    ma.Show();
                }

                else
                {
                    label3.Text = "Coba lagi";
                    txtuser.Clear();
                    txtpass.Clear();
                    txtuser.Focus();

                }
            }

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
