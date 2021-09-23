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

    public partial class FrmCars : Form
    {
        private string recReg;

        public string RecReg
        {
            get { return recReg;}
            set { recReg = value;}
        }







        public string recEng;
        public string recRPD;
        public string recDateReg;
        public string recAvailable;
        public int recNo;
        






        SQLiteConnection connect = new SQLiteConnection(@"data source = hire.db");


        public FrmCars()
        {
            InitializeComponent();
            //FrmCars frmrec = new FrmCars();
            //frmrec.recReg = frmVehicleReg.Text;
            // frmrec.recEng = frmEngine.Text;
            // frmrec.recRPD = frmRentalPerDay.Text;
            // frmrec.recDateReg = frmDateReg.Text;
            // frmrec.recAvailable = frmAvailable.Text;

            //var frmCurrentRecordList = new List<string>();
            //frmCurrentRecordList.Add(frmVehicleReg.Text);
            //frmCurrentRecordList.Add(frmEngine.Text);
            //frmCurrentRecordList.Add(frmRentalPerDay.Text);
            //frmCurrentRecordList.Add(frmDateReg.Text);
            //frmCurrentRecordList.Add(frmAvailable.Text);
            

    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            recordCounter("first");
            getData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            recordCounter("previous");
            getData();
        }

        int recordControlNo = 1;
        int totalRecords;



        public void recTotal()
        {//FINDS THE TOTAL AMOUNT OF RECORDS WHEN CALLED
            string findTotal = @"SELECT COUNT(*) FROM tblCar";

            connect.Open();
            string getTOT = findTotal;
            var command = connect.CreateCommand();
            command.CommandText = getTOT;
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var tot = reader.GetInt32(0);
                    totalRecords = tot;
                }
            }
            recordCount.Text = $"{recordControlNo} of {totalRecords}";
            connect.Close();
        }

        public void recordCounter(string frmBtn)
        {//UPDATES RECORD BOX DEPENDING ON BUTTONS PRESSED &&  ALSO USED AS A REFERENCE FOR CYCLING THROUGH -> getData()
            if (frmBtn == "next")
            {
                if (recordControlNo < totalRecords)
                { recordControlNo += 1; }
            }

            if (frmBtn == "previous")
            {
                if (recordControlNo > 1)
                { recordControlNo -= 1; }
            }

            if (frmBtn == "first")
            { recordControlNo = 1; }

            if (frmBtn == "last")
            { recordControlNo = totalRecords; }

            recordCount.Text = $"{recordControlNo} of {totalRecords}";
        }

        private void recordCount_TextChanged(object sender, EventArgs e)
        {
            recordCount.Text = $"{recordControlNo} of {totalRecords}";
        }

        private void FrmCars_Load(object sender, EventArgs e)
        {
            try
            {
                recTotal();
                getData();
            }
            catch (Exception)
            {
                MessageBox.Show("Can't load database. Check database connection.");
            }
        }



        
        public void getData()
        {//RETURNS DATA BASED ON SELECTED RECORD.
            int rowPosition = recordControlNo - 1;

            try
            {
                connect.Open();
                string getReg = $@"SELECT VehicleRegNo FROM (SELECT * from tblCar LIMIT 1 OFFSET {rowPosition})";
                recNo = rowPosition;
                var command = connect.CreateCommand();
                command.CommandText = getReg;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var reg = reader.GetString(0);
                        frmVehicleReg.Text = reg;
                        RecReg = frmVehicleReg.Text;
                        
                        
                    }
                }
                string getMake = $@"SELECT Make FROM (SELECT * from tblCar LIMIT 1 OFFSET {rowPosition});";
                var command2 = connect.CreateCommand();
                command2.CommandText = getMake;
                using (var reader2 = command2.ExecuteReader())
                {
                    while (reader2.Read())
                    {
                        var make = reader2.GetString(0);
                        frmMake.Text = make;
                    }
                }
                string getEngine = $@"SELECT EngineSize FROM (SELECT * from tblCar LIMIT 1 OFFSET {rowPosition});";
                var command3 = connect.CreateCommand();
                command3.CommandText = getEngine;
                using (var reader3 = command3.ExecuteReader())
                {
                    while (reader3.Read())
                    {
                        var eng = reader3.GetString(0);
                        frmEngine.Text = eng;
                    }
                }
                string getdate = $@"SELECT DateRegistered FROM (SELECT * from tblCar LIMIT 1 OFFSET {rowPosition});";
                var command4 = connect.CreateCommand();
                command4.CommandText = getdate;
                using (var reader4 = command4.ExecuteReader())
                {
                    while (reader4.Read())
                    {
                        var date = reader4.GetString(0);
                        frmDateReg.Text = date;
                    }
                }
                string getrpd = $@"SELECT RentalPerDay FROM (SELECT * from tblCar LIMIT 1 OFFSET {rowPosition});";
                var command5 = connect.CreateCommand();
                command5.CommandText = getrpd;
                using (var reader5 = command5.ExecuteReader())
                {
                    while (reader5.Read())
                    {
                        var rpd = reader5.GetInt32(0);
                        frmRentalPerDay.Text = $"${Convert.ToString(rpd)}";
                    }
                }
                string getavail = $@"SELECT Available FROM (SELECT * from tblCar LIMIT 1 OFFSET {rowPosition});";
                var command6 = connect.CreateCommand();
                command6.CommandText = getavail;
                using (var reader6 = command6.ExecuteReader())
                {
                    while (reader6.Read())
                    {
                        var avail = reader6.GetInt32(0);
                        if (avail == 1)
                        {
                            frmAvailable.Checked = true;
                        }
                        else
                        {
                            frmAvailable.Checked = false;
                        }
                    }
                }

                connect.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Cannot find data");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            recordCounter("next");
            getData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            recordCounter("last");
            getData();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void vehicleTooltip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmSearch searchForm = new frmSearch();
            searchForm.ShowDialog();
        }

        private void frmVehicleReg_TextChanged(object sender, EventArgs e)
        {

        }


        private int availability;
        private void button4_Click(object sender, EventArgs e)
        {
            //addRecord();           
            frmAdd openAddForm = new frmAdd();
            this.Hide();
            openAddForm.ShowDialog();
            this.Close();

        }
        public void addRecord()
        {//ADDS A NEW RECORDS TO THE DATABASE, BASED ON THE INFORMATION IN THE TEXT FIELDS. CALLED WITH ADD BUTTON.
            try
            {
                if (frmAvailable.Checked == true)
                {
                    availability = 1;
                }
                if (frmAvailable.Checked == false)
                {
                    availability = 0;
                }

                string addARecord = $@"INSERT INTO tblCar (VehicleRegNo, Make, EngineSize, DateRegistered, RentalPerDay, Available) VALUES ('" + frmVehicleReg.Text + "', '" + frmMake.Text + "', '" + frmEngine.Text + "', '" + frmDateReg.Text + "', '" + frmRentalPerDay.Text.TrimStart('$') + "', '" + availability + "')";
                connect.Open();
                SQLiteCommand insertSQL = new SQLiteCommand(connect);
                insertSQL.CommandText = addARecord;
                insertSQL.ExecuteNonQuery();
                connect.Close();
                recTotal();
                getData();
                //ISSUE: Have to prevent reg duplication so the update button can work properly
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot add data");
                return;
            }
        }
        private void updateRecord()
        {//UPDATES RECORD BASED ON INFORMATION IN TEXT FIELDS
            int j = recordControlNo - 1;
            try
            {
                if (frmAvailable.Checked == true)
                {
                    availability = 1;
                }
                if (frmAvailable.Checked == false)
                {
                    availability = 0;
                }

                string addARecord = $@"UPDATE tblCar SET VehicleRegNo = '" + frmVehicleReg.Text + "', Make = '" + frmMake.Text + "', EngineSize == '" + frmEngine.Text + "', DateRegistered== '" + frmDateReg.Text + "', RentalPerDay = '" + frmRentalPerDay.Text.TrimStart('$') + "', Available = '" + availability + "' WHERE VehicleRegNo = (SELECT VehicleRegNo from tblCar limit 1 OFFSET '" + j + "');";
                connect.Open();
                SQLiteCommand insertSQL = new SQLiteCommand(connect);
                insertSQL.CommandText = addARecord;
                insertSQL.ExecuteNonQuery();
                connect.Close();
                recTotal();
                getData();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot update data");
                return;
            }
            //UPDATE BUTTON
            //GRAY OUT THE UPDATE BUTTON UNTIL SOMETHING IS INPUTTED INTO FIELDS
            //MAKE THE VEHICLE REG UNEDITABLE
            //WHEN A BOX IS CHANGED SO IS THE COLOR
            //CANCEL BUTTON IS GRAYED OUT ALSO UNTIL TEXTBOX IS CHANGED
        }
        private void btnDelete_Click(object sender, EventArgs e) {
            DialogResult toDelete = MessageBox.Show("Are you sure you'd like to delete this record?", "Delete Record", MessageBoxButtons.YesNo);
            if (toDelete == DialogResult.Yes)
            {
                deleteData();
                recTotal();
                getData();
            }
            else if (toDelete == DialogResult.No)
            {
                MessageBox.Show("No record has been deleted.");
            }



            // frmDelete goToDeleteFrm = new frmDelete();
            //this.Hide();
            //goToDeleteFrm.ShowDialog();
            //this.Close();   
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


            private void btnCancel_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateRecord();
        }
    }
}




/*{//---DISPLAYS THE DATABASE ONTO THE DATA GRID---
    SQLiteConnection con = new SQLiteConnection(@"data source = tictacdb.db");
    con.Open();
    string query = "SELECT * FROM scoresTable";
    SQLiteCommand cmd = new SQLiteCommand(query, con);
    DataTable dt = new DataTable();
    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
    adapter.Fill(dt);
    dataGridView1.DataSource = dt;
}
public void scoreToDb1()
{//---INSERTS PLAYER 1'S SCORE INTO DATABASE---
    SQLiteConnection con = new SQLiteConnection(@"data source = tictacdb.db");
    con.Open();
    string sendData = "INSERT INTO scoresTable (player, winCount) VALUES ('" + p1Label.Text + "'," + p1sc.Text + ")";
    SQLiteCommand insertSQL = new SQLiteCommand(con);
    insertSQL.CommandText = sendData;
    insertSQL.ExecuteNonQuery();
    con.Close();
}
public void scoreToDb2()
{//---INSERTS PLAYER 2'S SCORE INTO DATABASE---
    SQLiteConnection con = new SQLiteConnection(@"data source = tictacdb.db");
    con.Open();
    string sendData2 = "INSERT INTO scoresTable (player, winCount) VALUES ('" + p2Label.Text + "'," + p2sc.Text + ")";
    SQLiteCommand insertSQL = new SQLiteCommand(con);
    insertSQL.CommandText = sendData2;
    insertSQL.ExecuteNonQuery();
    con.Close();*/