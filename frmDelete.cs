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

        public void frmDelete_Load(object sender, EventArgs e)
        {
            //FrmCars dataToDelete = new FrmCars();
            //Console.WriteLine(dataToDelete.recRPD);

            //FrmCars dataToDelete = new FrmCars();
            //ataToDelete.recReg = delVehicleReg.Text;

            FrmCars dataToDelete = new FrmCars();
            //int rowPosition = dataToDelete.recNo;
           // if (dataToDelete.ShowDialog() == DialogResult.OK)
            //{

         delVehicleReg.Text = dataToDelete.RecReg;
            //}
            

            //dataToDelete.getData();
            //frmVehicleReg.Text = FrmCars.frmVehicleReg.Text;

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
