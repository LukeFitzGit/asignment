
namespace BowmanCarHire
{
    partial class FrmCars
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.frmVehicleRegLabel = new System.Windows.Forms.Label();
            this.frmMakeLabel = new System.Windows.Forms.Label();
            this.FrmEngineLabel = new System.Windows.Forms.Label();
            this.frmDateLabel = new System.Windows.Forms.Label();
            this.frmRentalLabel = new System.Windows.Forms.Label();
            this.frmAvailLabel = new System.Windows.Forms.Label();
            this.frmVehicleReg = new System.Windows.Forms.TextBox();
            this.frmMake = new System.Windows.Forms.TextBox();
            this.frmEngine = new System.Windows.Forms.TextBox();
            this.frmDateReg = new System.Windows.Forms.TextBox();
            this.frmAvailable = new System.Windows.Forms.CheckBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.recordCount = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.vehicleRegTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.rpdTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.carMakeTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.frmTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.updatePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.engineTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.dateregTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.availTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.frmRentalPerDay = new System.Windows.Forms.NumericUpDown();
            this.frmDataGrid = new System.Windows.Forms.DataGridView();
            this.updatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmRentalPerDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bowman Car Hire";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmVehicleRegLabel
            // 
            this.frmVehicleRegLabel.AutoSize = true;
            this.frmVehicleRegLabel.BackColor = System.Drawing.Color.Transparent;
            this.frmVehicleRegLabel.Location = new System.Drawing.Point(99, 162);
            this.frmVehicleRegLabel.Name = "frmVehicleRegLabel";
            this.frmVehicleRegLabel.Size = new System.Drawing.Size(141, 13);
            this.frmVehicleRegLabel.TabIndex = 1;
            this.frmVehicleRegLabel.Text = "Vehicle Registration Number";
            this.frmVehicleRegLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmMakeLabel
            // 
            this.frmMakeLabel.AutoSize = true;
            this.frmMakeLabel.BackColor = System.Drawing.Color.Transparent;
            this.frmMakeLabel.Location = new System.Drawing.Point(99, 195);
            this.frmMakeLabel.Name = "frmMakeLabel";
            this.frmMakeLabel.Size = new System.Drawing.Size(34, 13);
            this.frmMakeLabel.TabIndex = 2;
            this.frmMakeLabel.Text = "Make";
            this.frmMakeLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // FrmEngineLabel
            // 
            this.FrmEngineLabel.AutoSize = true;
            this.FrmEngineLabel.BackColor = System.Drawing.Color.Transparent;
            this.FrmEngineLabel.Location = new System.Drawing.Point(99, 226);
            this.FrmEngineLabel.Name = "FrmEngineLabel";
            this.FrmEngineLabel.Size = new System.Drawing.Size(63, 13);
            this.FrmEngineLabel.TabIndex = 3;
            this.FrmEngineLabel.Text = "Engine Size";
            // 
            // frmDateLabel
            // 
            this.frmDateLabel.AutoSize = true;
            this.frmDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.frmDateLabel.Location = new System.Drawing.Point(99, 257);
            this.frmDateLabel.Name = "frmDateLabel";
            this.frmDateLabel.Size = new System.Drawing.Size(84, 13);
            this.frmDateLabel.TabIndex = 4;
            this.frmDateLabel.Text = "Date Registered";
            // 
            // frmRentalLabel
            // 
            this.frmRentalLabel.AutoSize = true;
            this.frmRentalLabel.BackColor = System.Drawing.Color.Transparent;
            this.frmRentalLabel.Location = new System.Drawing.Point(99, 289);
            this.frmRentalLabel.Name = "frmRentalLabel";
            this.frmRentalLabel.Size = new System.Drawing.Size(79, 13);
            this.frmRentalLabel.TabIndex = 5;
            this.frmRentalLabel.Text = "Rental Per Day";
            // 
            // frmAvailLabel
            // 
            this.frmAvailLabel.AutoSize = true;
            this.frmAvailLabel.BackColor = System.Drawing.Color.Transparent;
            this.frmAvailLabel.Location = new System.Drawing.Point(99, 314);
            this.frmAvailLabel.Name = "frmAvailLabel";
            this.frmAvailLabel.Size = new System.Drawing.Size(50, 13);
            this.frmAvailLabel.TabIndex = 6;
            this.frmAvailLabel.Text = "Available";
            // 
            // frmVehicleReg
            // 
            this.frmVehicleReg.Location = new System.Drawing.Point(264, 162);
            this.frmVehicleReg.Name = "frmVehicleReg";
            this.frmVehicleReg.ReadOnly = true;
            this.frmVehicleReg.Size = new System.Drawing.Size(125, 20);
            this.frmVehicleReg.TabIndex = 7;
            this.frmVehicleReg.TabStop = false;
            this.vehicleRegTooltip.SetToolTip(this.frmVehicleReg, "Input your vehicle registraion number here");
            this.frmVehicleReg.TextChanged += new System.EventHandler(this.frmVehicleReg_TextChanged);
            // 
            // frmMake
            // 
            this.frmMake.Location = new System.Drawing.Point(264, 195);
            this.frmMake.Name = "frmMake";
            this.frmMake.Size = new System.Drawing.Size(201, 20);
            this.frmMake.TabIndex = 8;
            this.frmMake.TabStop = false;
            this.carMakeTooltip.SetToolTip(this.frmMake, "Enter the make of the car");
            this.frmMake.TextChanged += new System.EventHandler(this.frmMake_TextChanged);
            this.frmMake.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMake_KeyDown);
            // 
            // frmEngine
            // 
            this.frmEngine.Location = new System.Drawing.Point(264, 226);
            this.frmEngine.Name = "frmEngine";
            this.frmEngine.Size = new System.Drawing.Size(125, 20);
            this.frmEngine.TabIndex = 9;
            this.frmEngine.TabStop = false;
            this.engineTooltip.SetToolTip(this.frmEngine, "Input size of engine (eg. 1.4L)");
            this.frmEngine.TextChanged += new System.EventHandler(this.frmEngine_TextChanged);
            this.frmEngine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEngine_KeyDown);
            // 
            // frmDateReg
            // 
            this.frmDateReg.Location = new System.Drawing.Point(264, 257);
            this.frmDateReg.Name = "frmDateReg";
            this.frmDateReg.Size = new System.Drawing.Size(100, 20);
            this.frmDateReg.TabIndex = 10;
            this.frmDateReg.TabStop = false;
            this.dateregTooltip.SetToolTip(this.frmDateReg, "Please Input date (eg. 2009-05-23)");
            this.frmDateReg.TextChanged += new System.EventHandler(this.frmDateReg_TextChanged);
            this.frmDateReg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDateReg_KeyDown);
            // 
            // frmAvailable
            // 
            this.frmAvailable.AutoSize = true;
            this.frmAvailable.Location = new System.Drawing.Point(264, 316);
            this.frmAvailable.Name = "frmAvailable";
            this.frmAvailable.Size = new System.Drawing.Size(15, 14);
            this.frmAvailable.TabIndex = 12;
            this.frmAvailable.TabStop = false;
            this.availTooltip.SetToolTip(this.frmAvailable, "Check if vehicle is available");
            this.frmAvailable.UseVisualStyleBackColor = true;
            this.frmAvailable.CheckedChanged += new System.EventHandler(this.frmVehicleReg_TextChanged);
            this.frmAvailable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAvailable_KeyDown);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.White;
            this.btnFirst.FlatAppearance.BorderSize = 0;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(64, 398);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(111, 40);
            this.btnFirst.TabIndex = 13;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.White;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(181, 398);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(111, 40);
            this.btnPrevious.TabIndex = 14;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(405, 396);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(111, 40);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.White;
            this.btnLast.FlatAppearance.BorderSize = 0;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(522, 396);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(111, 40);
            this.btnLast.TabIndex = 18;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.button6_Click);
            // 
            // recordCount
            // 
            this.recordCount.Location = new System.Drawing.Point(299, 410);
            this.recordCount.Name = "recordCount";
            this.recordCount.ReadOnly = true;
            this.recordCount.Size = new System.Drawing.Size(100, 20);
            this.recordCount.TabIndex = 19;
            this.recordCount.TabStop = false;
            this.recordCount.Text = "1 of 15";
            this.recordCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.recordCount.TextChanged += new System.EventHandler(this.recordCount_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(659, 107);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 40);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(659, 151);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 40);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(659, 195);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 40);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(659, 239);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 40);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(659, 283);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 40);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(659, 327);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 40);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button10_Click);
            // 
            // vehicleRegTooltip
            // 
            this.vehicleRegTooltip.Tag = "Veh Reg";
            this.vehicleRegTooltip.Popup += new System.Windows.Forms.PopupEventHandler(this.vehicleTooltip_Popup);
            // 
            // updatePanel
            // 
            this.updatePanel.BackColor = System.Drawing.Color.Transparent;
            this.updatePanel.Controls.Add(this.label2);
            this.updatePanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.updatePanel.Location = new System.Drawing.Point(79, 134);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(404, 210);
            this.updatePanel.TabIndex = 26;
            this.updatePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(180, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "You are currently editing a record";
            // 
            // frmRentalPerDay
            // 
            this.frmRentalPerDay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.frmRentalPerDay.Location = new System.Drawing.Point(264, 287);
            this.frmRentalPerDay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.frmRentalPerDay.Name = "frmRentalPerDay";
            this.frmRentalPerDay.Size = new System.Drawing.Size(120, 20);
            this.frmRentalPerDay.TabIndex = 1;
            this.frmRentalPerDay.TabStop = false;
            this.frmRentalPerDay.ValueChanged += new System.EventHandler(this.frmRentalPerDay_ValueChanged);
            this.frmRentalPerDay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRentalPerDay_KeyDown);
            // 
            // frmDataGrid
            // 
            this.frmDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frmDataGrid.Location = new System.Drawing.Point(27, 39);
            this.frmDataGrid.Name = "frmDataGrid";
            this.frmDataGrid.Size = new System.Drawing.Size(148, 73);
            this.frmDataGrid.TabIndex = 28;
            this.frmDataGrid.Visible = false;
            // 
            // FrmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.frmDataGrid);
            this.Controls.Add(this.frmRentalPerDay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.recordCount);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updatePanel);
            this.Name = "FrmCars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task A Luke Fitzgerald 16/09/2021";
            this.frmTooltip.SetToolTip(this, "Car Hire Menu");
            this.Load += new System.EventHandler(this.FrmCars_Load);
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmRentalPerDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label frmVehicleRegLabel;
        private System.Windows.Forms.Label frmMakeLabel;
        private System.Windows.Forms.Label FrmEngineLabel;
        private System.Windows.Forms.Label frmDateLabel;
        private System.Windows.Forms.Label frmRentalLabel;
        private System.Windows.Forms.Label frmAvailLabel;
        private System.Windows.Forms.TextBox frmVehicleReg;
        private System.Windows.Forms.TextBox frmMake;
        private System.Windows.Forms.TextBox frmEngine;
        private System.Windows.Forms.TextBox frmDateReg;
        private System.Windows.Forms.CheckBox frmAvailable;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.TextBox recordCount;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip vehicleRegTooltip;
        private System.Windows.Forms.ToolTip rpdTooltip;
        private System.Windows.Forms.ToolTip carMakeTooltip;
        private System.Windows.Forms.ToolTip frmTooltip;
        private System.Windows.Forms.Panel updatePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip engineTooltip;
        private System.Windows.Forms.ToolTip dateregTooltip;
        private System.Windows.Forms.ToolTip availTooltip;
        private System.Windows.Forms.NumericUpDown frmRentalPerDay;
        private System.Windows.Forms.DataGridView frmDataGrid;
    }
}

