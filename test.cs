/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace BowmanCarHire
{
    public partial class test : Form
    {
        SQLiteConnection connect = new SQLiteConnection(@"data source = hire.db");
        public test()
        {
            
        }

        private void test_Load(object sender, EventArgs e)
        {   //open connection

            try
            {
                connect.Open();

                //make the query
                string getDB = $@"SELECT * FROM (SELECT * from tblCar LIMIT 1 OFFSET 3)";

                //turn query into a command connecting to connection
                SQLiteCommand cmd = new SQLiteCommand(getDB, connect);

                //declaring a new table
                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                connect.Close();

                frmVehicleReg.Text = Convert.ToString(dt.Rows[0].ItemArray[1]);
                frmMake.Text = Convert.ToString(dt.Rows[0].ItemArray[2]);
                frmEngine.Text = Convert.ToString(dt.Rows[0].ItemArray[3]);
                frmDateReg.Text = Convert.ToString(dt.Rows[0].ItemArray[4]);
                frmRentalPerDay.Text = Convert.ToString(dt.Rows[0].ItemArray[5]);
                int available = Convert.ToInt32(dt.Rows[0].ItemArray[6]);
                if (available == 1)
                {
                    frmAvailable.Checked = true;
                }
                else
                {
                    frmAvailable.Checked = false;
                }

            }
            catch (Exception){
                MessageBox.Show("Cannot find data");
            }


        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // test
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "test";
            this.Load += new System.EventHandler(this.test_Load_1);
            this.ResumeLayout(false);

        }

        private void test_Load_1(object sender, EventArgs e)
        {

        }
    }
}*/
