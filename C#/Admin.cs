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

namespace assignment
{
    public partial class Admin : Form
    {

        public Admin()
        {
            InitializeComponent();
            ID.Hide();
            label5.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ID.Hide();
                label5.Hide();
                database db = new database();
                adminn c = new adminn();
                c.Name = name.Text;
                c.Price = int.Parse(price.Text);
                c.Qty = int.Parse(qty.Text);
                db.Saveitem(c);
                MessageBox.Show("Data are successfully saved!!", "Saving", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (MessageBox.Show("Would you like to do saving process again!!", "Saving", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ID.Hide();
                    label5.Hide();
                }
                else 
                {
                    ID.Show();
                    label5.Show();
                }
            }
            catch (FormatException format)
            {
                MessageBox.Show("Please fill the correct and complete data!!", "Saving", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Would you like to do deleting process again!!", "Deleting", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ID.Show();
                label5.Show();
                database db = new database();
                db.deleteitem(ID.Text);
                dataGridView1.DataSource = db.Displayitem(); 
            }
            else 
            {
                ID.Hide();
                label5.Hide();
            }
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            database db = new database();
            DataTable dt = db.Displayitem();
            dataGridView1.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
            database db = new database();
            DataTable dt = db.Searching(SEARCH.Text);
            dataGridView1.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new registration().Show();
            this.Hide();
        }

        private void ID_TextChanged(object sender, EventArgs e)
        {
            database db = new database();
            DataTable dt = db.searchitem();
            for (int i = 0; i < dt.Rows.Count; i++)
                if (ID.Text.Equals(dt.Rows[i][1].ToString()))
                {
                    name.Text=dt.Rows[i][0].ToString();
                    price.Text = dt.Rows[i][2].ToString();
                    qty.Text = dt.Rows[i][3].ToString();
                    break;

                }
                else
                {
                    
                }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void price_TextChanged(object sender, EventArgs e)
        {

        }

        private void qty_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try {
                ID.Show();
                label5.Show();
                admindic cd = new admindic();
                cd.Name = name.Text;
                cd.id = int.Parse(ID.Text);
                cd.Price = decimal.Parse(price.Text);
                cd.Qty = int.Parse(qty.Text);
                database db = new database();
                db.updateitem(cd);
                dataGridView1.DataSource = db.Displayitem();
            }
            catch (FormatException format)
            {
                MessageBox.Show("Please fill the correct and complete data!!", "Saving", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            database db = new database();
            DataTable dt = db.Searching(SEARCH.Text);
            dataGridView1.DataSource = dt;
        }
    }
}
