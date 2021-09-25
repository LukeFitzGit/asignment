/*
namespace BowmanCarHire
{
    partial class test
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.frmRentalPerDay = new System.Windows.Forms.NumericUpDown();
            this.frmAvailable = new System.Windows.Forms.CheckBox();
            this.frmDateReg = new System.Windows.Forms.TextBox();
            this.frmEngine = new System.Windows.Forms.TextBox();
            this.frmMake = new System.Windows.Forms.TextBox();
            this.frmVehicleReg = new System.Windows.Forms.TextBox();
            this.frmAvailLabel = new System.Windows.Forms.Label();
            this.frmRentalLabel = new System.Windows.Forms.Label();
            this.frmDateLabel = new System.Windows.Forms.Label();
            this.FrmEngineLabel = new System.Windows.Forms.Label();
            this.frmMakeLabel = new System.Windows.Forms.Label();
            this.frmVehicleRegLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.frmRentalPerDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // frmRentalPerDay
            // 
            this.frmRentalPerDay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.frmRentalPerDay.Location = new System.Drawing.Point(391, 255);
            this.frmRentalPerDay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.frmRentalPerDay.Name = "frmRentalPerDay";
            this.frmRentalPerDay.Size = new System.Drawing.Size(120, 20);
            this.frmRentalPerDay.TabIndex = 13;
            this.frmRentalPerDay.TabStop = false;
            // 
            // frmAvailable
            // 
            this.frmAvailable.AutoSize = true;
            this.frmAvailable.Location = new System.Drawing.Point(391, 284);
            this.frmAvailable.Name = "frmAvailable";
            this.frmAvailable.Size = new System.Drawing.Size(15, 14);
            this.frmAvailable.TabIndex = 24;
            this.frmAvailable.TabStop = false;
            this.frmAvailable.UseVisualStyleBackColor = true;
            // 
            // frmDateReg
            // 
            this.frmDateReg.Location = new System.Drawing.Point(391, 225);
            this.frmDateReg.Name = "frmDateReg";
            this.frmDateReg.Size = new System.Drawing.Size(100, 20);
            this.frmDateReg.TabIndex = 23;
            this.frmDateReg.TabStop = false;
            // 
            // frmEngine
            // 
            this.frmEngine.Location = new System.Drawing.Point(391, 194);
            this.frmEngine.Name = "frmEngine";
            this.frmEngine.Size = new System.Drawing.Size(125, 20);
            this.frmEngine.TabIndex = 22;
            this.frmEngine.TabStop = false;
            // 
            // frmMake
            // 
            this.frmMake.Location = new System.Drawing.Point(391, 163);
            this.frmMake.Name = "frmMake";
            this.frmMake.Size = new System.Drawing.Size(201, 20);
            this.frmMake.TabIndex = 21;
            this.frmMake.TabStop = false;
            // 
            // frmVehicleReg
            // 
            this.frmVehicleReg.Location = new System.Drawing.Point(391, 130);
            this.frmVehicleReg.Name = "frmVehicleReg";
            this.frmVehicleReg.ReadOnly = true;
            this.frmVehicleReg.Size = new System.Drawing.Size(125, 20);
            this.frmVehicleReg.TabIndex = 20;
            this.frmVehicleReg.TabStop = false;
            // 
            // frmAvailLabel
            // 
            this.frmAvailLabel.AutoSize = true;
            this.frmAvailLabel.BackColor = System.Drawing.Color.Transparent;
            this.frmAvailLabel.Location = new System.Drawing.Point(226, 282);
            this.frmAvailLabel.Name = "frmAvailLabel";
            this.frmAvailLabel.Size = new System.Drawing.Size(50, 13);
            this.frmAvailLabel.TabIndex = 19;
            this.frmAvailLabel.Text = "Available";
            // 
            // frmRentalLabel
            // 
            this.frmRentalLabel.AutoSize = true;
            this.frmRentalLabel.BackColor = System.Drawing.Color.Transparent;
            this.frmRentalLabel.Location = new System.Drawing.Point(226, 257);
            this.frmRentalLabel.Name = "frmRentalLabel";
            this.frmRentalLabel.Size = new System.Drawing.Size(79, 13);
            this.frmRentalLabel.TabIndex = 18;
            this.frmRentalLabel.Text = "Rental Per Day";
            // 
            // frmDateLabel
            // 
            this.frmDateLabel.AutoSize = true;
            this.frmDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.frmDateLabel.Location = new System.Drawing.Point(226, 225);
            this.frmDateLabel.Name = "frmDateLabel";
            this.frmDateLabel.Size = new System.Drawing.Size(84, 13);
            this.frmDateLabel.TabIndex = 17;
            this.frmDateLabel.Text = "Date Registered";
            // 
            // FrmEngineLabel
            // 
            this.FrmEngineLabel.AutoSize = true;
            this.FrmEngineLabel.BackColor = System.Drawing.Color.Transparent;
            this.FrmEngineLabel.Location = new System.Drawing.Point(226, 194);
            this.FrmEngineLabel.Name = "FrmEngineLabel";
            this.FrmEngineLabel.Size = new System.Drawing.Size(63, 13);
            this.FrmEngineLabel.TabIndex = 16;
            this.FrmEngineLabel.Text = "Engine Size";
            // 
            // frmMakeLabel
            // 
            this.frmMakeLabel.AutoSize = true;
            this.frmMakeLabel.BackColor = System.Drawing.Color.Transparent;
            this.frmMakeLabel.Location = new System.Drawing.Point(226, 163);
            this.frmMakeLabel.Name = "frmMakeLabel";
            this.frmMakeLabel.Size = new System.Drawing.Size(34, 13);
            this.frmMakeLabel.TabIndex = 15;
            this.frmMakeLabel.Text = "Make";
            // 
            // frmVehicleRegLabel
            // 
            this.frmVehicleRegLabel.AutoSize = true;
            this.frmVehicleRegLabel.BackColor = System.Drawing.Color.Transparent;
            this.frmVehicleRegLabel.Location = new System.Drawing.Point(226, 130);
            this.frmVehicleRegLabel.Name = "frmVehicleRegLabel";
            this.frmVehicleRegLabel.Size = new System.Drawing.Size(141, 13);
            this.frmVehicleRegLabel.TabIndex = 14;
            this.frmVehicleRegLabel.Text = "Vehicle Registration Number";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(693, 86);
            this.dataGridView1.TabIndex = 25;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.frmRentalPerDay);
            this.Controls.Add(this.frmAvailable);
            this.Controls.Add(this.frmDateReg);
            this.Controls.Add(this.frmEngine);
            this.Controls.Add(this.frmMake);
            this.Controls.Add(this.frmVehicleReg);
            this.Controls.Add(this.frmAvailLabel);
            this.Controls.Add(this.frmRentalLabel);
            this.Controls.Add(this.frmDateLabel);
            this.Controls.Add(this.FrmEngineLabel);
            this.Controls.Add(this.frmMakeLabel);
            this.Controls.Add(this.frmVehicleRegLabel);
            this.Name = "test";
            this.Text = "test";
            this.Load += new System.EventHandler(this.test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frmRentalPerDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown frmRentalPerDay;
        private System.Windows.Forms.CheckBox frmAvailable;
        private System.Windows.Forms.TextBox frmDateReg;
        private System.Windows.Forms.TextBox frmEngine;
        private System.Windows.Forms.TextBox frmMake;
        private System.Windows.Forms.TextBox frmVehicleReg;
        private System.Windows.Forms.Label frmAvailLabel;
        private System.Windows.Forms.Label frmRentalLabel;
        private System.Windows.Forms.Label frmDateLabel;
        private System.Windows.Forms.Label FrmEngineLabel;
        private System.Windows.Forms.Label frmMakeLabel;
        private System.Windows.Forms.Label frmVehicleRegLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}*/