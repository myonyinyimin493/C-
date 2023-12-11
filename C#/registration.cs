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
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
            password.PasswordChar = '*';
            password.MaxLength = 20;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reg c = new reg();
            c.Name = name.Text;
            c.Password = password.Text;
            database d = new database();
            d.deletepassword(c);
            d.savepassword(c);
            MessageBox.Show("Your password and username are changed!!","Registration", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            new Form1().Show();
            this.Hide();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
