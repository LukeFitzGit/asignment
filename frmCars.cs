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

        //MAKE FIELDS ONLY TAKE CERTAIN INPUTS
        //REWRITE TOOLTIPS
        //FIX EDIT NOTIFICATION FOR RPD





        SQLiteConnection connect = new SQLiteConnection(@"data source = hire.db");


        public FrmCars()
        {
            InitializeComponent();
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
        {//UPDATES RECORD BOX DEPENDING ON BUTTONS PRESSED && ALSO USED AS A REFERENCE FOR CYCLING THROUGH -> getData()
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
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
            updatePanel.Visible = false;


            if (btnUpdate.Enabled == true)
            {
                updatePanel.Visible = true;
            }

        }
        public void getData()
        {
            int rowPosition = recordControlNo - 1;

            try
            {//RETURNS DATA BASED ON SELECTED RECORD.
                connect.Open();

                //make the query
                string getDB = $@"SELECT * FROM (SELECT * from tblCar LIMIT 1 OFFSET {rowPosition})";

                //turn query into a command connecting to connection
                SQLiteCommand cmd = new SQLiteCommand(getDB, connect);

                //declaring a new table
                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);
                frmDataGrid.DataSource = dt;
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

                btnUpdate.Enabled = false;
                btnCancel.Enabled = false;
                updatePanel.Visible = false;
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
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
            updatePanel.Visible = true;
        }


        private int availability;
        private void button4_Click(object sender, EventArgs e)
        {
            frmAdd openAddForm = new frmAdd();
            this.Hide();
            openAddForm.ShowDialog();
            this.Close();

        }

        private void updateRecord()
        {//UPDATES RECORD BASED ON INFORMATION IN TEXT FIELDS
            int offsetNumber = recordControlNo - 1;
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

                string updateARecord = $@"UPDATE tblCar SET VehicleRegNo = '" + frmVehicleReg.Text + "', Make = '" + frmMake.Text + "', EngineSize == '" + frmEngine.Text + "', DateRegistered== '" + frmDateReg.Text + "', RentalPerDay = '" + frmRentalPerDay.Value + "', Available = '" + availability + "' WHERE VehicleRegNo = (SELECT VehicleRegNo from tblCar limit 1 OFFSET '" + offsetNumber + "');";
                connect.Open();
                SQLiteCommand insertSQL = new SQLiteCommand(connect);
                insertSQL.CommandText = updateARecord;
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


        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult toDelete = MessageBox.Show("Are you sure you'd like to delete this record?", "Delete Record", MessageBoxButtons.YesNo);
            if (toDelete == DialogResult.Yes)
            {
                deleteData();
                MessageBox.Show("Record Deleted");


            }
            else if (toDelete == DialogResult.No)
            {
                MessageBox.Show("No record has been deleted.");
            }

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
                    recTotal();
                    recordCounter("last");
                    getData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot delete data");
                }
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            getData();
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
            updatePanel.Visible = false;
            frmMake.BackColor = Color.White;
            frmEngine.BackColor = Color.White;
            frmDateReg.BackColor = Color.White;
            frmAvailable.BackColor = Color.White;
            frmRentalPerDay.BackColor = Color.White;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            DialogResult toUpdate = MessageBox.Show("Are you sure you'd like to Update this record?", "Update Record", MessageBoxButtons.YesNo);
            if (toUpdate == DialogResult.Yes)
            {
                updateRecord();
                MessageBox.Show("Record Updated");


            }
            else if (toUpdate == DialogResult.No)
            {
                MessageBox.Show("No record has been deleted.");
            }
            frmMake.BackColor = Color.White;
            frmEngine.BackColor = Color.White;
            frmDateReg.BackColor = Color.White;
            frmAvailable.BackColor = Color.White;
            frmRentalPerDay.BackColor = Color.White;

        }

        private void frmMake_TextChanged(object sender, EventArgs e)
        {

            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
            updatePanel.Visible = true;
        }

        private void frmEngine_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
            updatePanel.Visible = true;
        }

        private void frmDateReg_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
            updatePanel.Visible = true;
        }

        private void frmRentalPerDay_TextChanged(object sender, EventArgs e)
        {

            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
            updatePanel.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dateRegTooltip_Popup(object sender, PopupEventArgs e)
        {
        }

        private void frmRentalPerDay_ValueChanged(object sender, EventArgs e)
        {

            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
            updatePanel.Visible = true;

        }
        private void frmRentalPerDay_KeyDown(object sender, KeyEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
            updatePanel.Visible = true;
            frmRentalPerDay.BackColor = Color.LightGoldenrodYellow;
        }

        public void frmMake_KeyDown(object sender, KeyEventArgs e)
        {
            frmMake.BackColor = Color.LightGoldenrodYellow;
        }

        private void frmEngine_KeyDown(object sender, KeyEventArgs e)
        {
            frmEngine.BackColor = Color.LightGoldenrodYellow;
        }

        private void frmDateReg_KeyDown(object sender, KeyEventArgs e)
        {
            frmDateReg.BackColor = Color.LightGoldenrodYellow;
        }

        private void frmAvailable_KeyDown(object sender, KeyEventArgs e)
        {
            frmAvailable.BackColor = Color.LightGoldenrodYellow;
        }
    }
}




/* THIS IS THE OLD METHOD OF GETTING DATA I DID BEFORE I KNEW WHAT I WAS DOING
 * 
public void getDataOld()
{
    int rowPosition = recordControlNo - 1;

    try
    {
        connect.Open();
        string getReg = $@"SELECT VehicleRegNo FROM (SELECT * from tblCar LIMIT 1 OFFSET {rowPosition})";

        var command = connect.CreateCommand();
        command.CommandText = getReg;
        using (var reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                var reg = reader.GetString(0);
                frmVehicleReg.Text = reg;                 
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
                frmRentalPerDay.Value = rpd;
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
        btnUpdate.Enabled = false;
        btnCancel.Enabled = false;
        updatePanel.Visible = false;


        connect.Close();
    }

    catch (Exception)
    {
        MessageBox.Show("Cannot find data");
    }
}*/



/* OLD WAY TO ADD RECORDS BEFORE MAKING AN ADD FORM
 * 
 * public void addRecord()
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
}*/