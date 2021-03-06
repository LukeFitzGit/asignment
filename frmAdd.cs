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
    public partial class frmAdd : Form
    {
        SQLiteConnection connect = new SQLiteConnection(@"data source = hire.db");
        public frmAdd()
        {
            InitializeComponent();
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
        }
        private int availability;
        private string returnedReg;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (frmVehicleReg.Text != "" && frmMake.Text != "" && frmDateReg.Text != "" && frmEngine.Text != "" && frmRentalPerDay.Value != 0) {
                try
                {
                    //STRINGS USED FOR DB

                    string isRegInDb = $@"SELECT VehicleRegNo FROM tblCar WHERE VehicleRegNo = '" + frmVehicleReg.Text + "'";
                    connect.Open();


                    var command = connect.CreateCommand();
                    command.CommandText = isRegInDb;

                    using (var reader = command.ExecuteReader())
                    {//GETTING MATCHING RECORD
                        while (reader.Read())
                        {
                            var reg = reader.GetString(0);
                            returnedReg = reg;
                        }



                        //RETURNING IF VEHICLE REG MATCHES RECORD IN DB
                        if (frmVehicleReg.Text == returnedReg)
                        {
                            MessageBox.Show("Vehicle Registration Number may already exist in the database.");
                        }

                        //ADDING RECORD IF VehicleRegNo DOESN'T MATCH
                        if (frmVehicleReg.Text != returnedReg)
                        {
                            if (frmAvailable.Checked == true)
                            {
                                availability = 1;
                            }
                            if (frmAvailable.Checked == false)
                            {
                                availability = 0;
                            }

                            string addARecord = $@"INSERT INTO tblCar (VehicleRegNo, Make, EngineSize, DateRegistered, RentalPerDay, Available) VALUES 
                                            ('" + frmVehicleReg.Text + "', '" + frmMake.Text + "', '" + frmEngine.Text + "', '" + frmDateReg.Text + "', '" + frmRentalPerDay.Value + "', '" + availability + "')";

                            SQLiteCommand insertSQL = new SQLiteCommand(addARecord, connect);
                            insertSQL.CommandText = addARecord;
                            insertSQL.ExecuteNonQuery();
                            MessageBox.Show("You have succesfully added a new record to the database");
                            connect.Close();

                        }
                        

                    }               
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot add data");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please make sure all fields are completed");
            }
        }

        private void frmVehicleReg_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmMake_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmEngine_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDateReg_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRentalPerDay_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAvailable_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmVehicleReg.Text = "";
            frmEngine.Text = "";
            frmDateReg.Text = "";
            frmMake.Text = "";
            frmRentalPerDay.Value = 0;
            frmAvailable.Checked = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            FrmCars goToFrmCars = new FrmCars();
            this.Hide();
            goToFrmCars.ShowDialog();
            this.Close();
        }

        private void frmRentalPerDay_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
