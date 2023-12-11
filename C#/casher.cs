using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace assignment
{
    public partial class casher : Form
    {
        public casher()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            database db = new database();
            DataTable dt = db.searchitem();
            for (int i = 0; i < dt.Rows.Count; i++)
                if (textBox3.Text.Equals(dt.Rows[i][1].ToString()))
                {
                    textBox2.Text = dt.Rows[i][0].ToString();
                    textBox8.Text = dt.Rows[i][2].ToString();
                    break;

                }
                else
                {

                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            database db = new database();
            DataTable tt = db.searchvouncher();
            Vouncher va = new Vouncher();
            va.VOU = textBox4.Text;
            Boolean v = false;
             for (int r = 0; r < tt.Rows.Count; r++){
                 if (textBox4.Text.Equals(tt.Rows[r][0].ToString()))
            {
                v = true;
                break;
                
            }
            else
            {
                v = false;
                
            }
             }



            try
            {
                DataTable dt = db.searchitem();
                casheer ca = new casheer();
                ca.CName = textBox1.Text;
                ca.Vouncher = textBox4.Text;
                ca.id = int.Parse(textBox3.Text);
                ca.iName = textBox2.Text;
                ca.Price = decimal.Parse(textBox8.Text);
                ca.Qty = int.Parse(textBox6.Text);
                int p = 0;
                int dd = int.Parse(textBox6.Text);
                Boolean g = false;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (textBox3.Text.Equals(dt.Rows[i][1].ToString()))
                    {
                        g = true;
                        p = int.Parse(dt.Rows[i][3].ToString());
                        if (p > dd)
                        {
                            int u = p - dd;
                            Itemdeuction cd = new Itemdeuction();
                            cd.id = int.Parse(textBox3.Text);
                            cd.Qty = u;
                            db.updateitemded(cd);
                            
                            decimal d = decimal.Parse(textBox8.Text);
                            decimal b = decimal.Parse(textBox6.Text);
                            decimal c = d * b;
                            textBox5.Text = c.ToString();
                            ca.Amount = decimal.Parse(textBox5.Text);
                            if (v == false)
                            {
                                db.savevouncher(va);
                                db.savecasher(ca);
                                textBox4.Enabled = false;
                                MessageBox.Show("You can save the data successfully");
                              

                            }
                            else
                            {
                                db.savecasher(ca);
                                MessageBox.Show("You can save the data successfully");
                                
                                
                            }




                            break;


                        }
                        else
                        {
                            MessageBox.Show("Quantity is not enough to sell");
                            break;
                        }


                    }
                    else
                    {
                        g = false;
                    }

                }

                if (g == false)
                {
                    MessageBox.Show("ID is not exit");
                }
                else
                {
                    DataTable at = db.showsearching(textBox4.Text);
                    dataGridView1.DataSource = at;
                }
                
                
               
            }
            catch (FormatException format) 
            {
                MessageBox.Show("Please fill the correct and complete data!!", "Saving", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            catch (SqlException)
            {
                MessageBox.Show("Vouncher ID will be start with VID-", "VID-", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            database db = new database();
            DataTable tt = db.searchvouncher();
            for (int u = 0; u < tt.Rows.Count; u++)
            {
                if (textBox4.Text.Equals(tt.Rows[u][0].ToString()))
                {
                    textBox7.Text = tt.Rows[u][1].ToString();
                    textBox14.Text = tt.Rows[u][2].ToString();
                    textBox13.Text = tt.Rows[u][3].ToString();
                    textBox9.Text = tt.Rows[u][4].ToString();
                    textBox10.Text = tt.Rows[u][5].ToString();
                    

                }
                else
                {


                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox11.Text);
            decimal b;
             database db = new database();
            DataTable tt = db.searchvouncher();
            for (int u = 0; u < tt.Rows.Count; u++)
            {
                if (textBox4.Text.Equals(tt.Rows[u][0].ToString()))
                {
                    b = decimal.Parse(tt.Rows[u][5].ToString());


                    int c = Convert.ToInt32(b);
                    int d = a - c;
                    textBox12.Text = d.ToString();
                    textBox4.Enabled = true;

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            database db = new database();
            DataTable dt = db.Displayitem();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database db = new database();
            DataTable dt = db.Displayitem();
            dataGridView1.DataSource = dt;
        }
    }
}
