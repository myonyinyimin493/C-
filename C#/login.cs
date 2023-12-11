using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reg c = new reg();
            c.Name = name.Text;
            c.Password = password.Text;
            database db = new database();
            DataTable dt= db.searchpassword();
            for (int i = 0; i < dt.Rows.Count; i++)
            if (c.Name=="Staff" && c.Password=="123")
            {
                new casher().Show();
                this.Hide();
            }
            else if (dt.Rows[i][0].Equals(name.Text) && dt.Rows[i][1].Equals(password.Text))
            {
                new Admin().Show();
                this.Hide();
                break;
            }
            else
            {
                MessageBox.Show("Your password and username are not correct!!", "Log In error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
