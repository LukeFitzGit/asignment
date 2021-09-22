using System;
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
    public partial class frmDelete : Form
    {
        SQLiteConnection connect = new SQLiteConnection(@"data source = hire.db");
        public frmDelete()
        {
            InitializeComponent();
        }

        private void frmDelete_Load(object sender, EventArgs e)
        {
            FrmCars dataToDelete = new FrmCars();
            Console.WriteLine(dataToDelete.recRPD);

            //dataToDelete.getData();
          
            
        }

        private void deleteData()
        {
            {//DELETES CURRENT DISPLAYED DATA FROM DATABASE
                try
                {
                    string deleteARecord = $@"DELETE FROM tblCar WHERE VehicleRegNo = '{frmVehicleReg.Text}'";

                    connect.Open();
                    string sendData2 = deleteARecord;
                    SQLiteCommand deleteSQL = new SQLiteCommand(connect);
                    deleteSQL.CommandText = sendData2;
                    deleteSQL.ExecuteNonQuery();
                    connect.Close();

                    FrmCars totaldata = new FrmCars();
                    totaldata.recTotal();
                    FrmCars cars = new FrmCars();
                    cars.getData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot delete data");
                }
                //TO DO
                //GET RECORD DETAILS INTO FORM
                //ATTACH DELETE FUNCTION TO DELETE BUTTON
            }

        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void btnCanc_Click(object sender, EventArgs e)
        {

            FrmCars goToCars = new FrmCars();
            this.Hide();
            goToCars.ShowDialog();
            this.Close();
        }
    }
}
