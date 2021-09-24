
namespace BowmanCarHire
{
    partial class frmAdd
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCLear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.frmRentalPerDay = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.frmRentalPerDay)).BeginInit();
            this.SuspendLayout();
            // 
            // frmAvailable
            // 
            this.frmAvailable.AutoSize = true;
            this.frmAvailable.Location = new System.Drawing.Point(215, 232);
            this.frmAvailable.Name = "frmAvailable";
            this.frmAvailable.Size = new System.Drawing.Size(15, 14);
            this.frmAvailable.TabIndex = 24;
            this.frmAvailable.UseVisualStyleBackColor = true;
            this.frmAvailable.CheckedChanged += new System.EventHandler(this.frmAvailable_CheckedChanged);
            // 
            // frmDateReg
            // 
            this.frmDateReg.Location = new System.Drawing.Point(215, 173);
            this.frmDateReg.Name = "frmDateReg";
            this.frmDateReg.Size = new System.Drawing.Size(100, 20);
            this.frmDateReg.TabIndex = 22;
            this.frmDateReg.TextChanged += new System.EventHandler(this.frmDateReg_TextChanged);
            // 
            // frmEngine
            // 
            this.frmEngine.Location = new System.Drawing.Point(215, 142);
            this.frmEngine.Name = "frmEngine";
            this.frmEngine.Size = new System.Drawing.Size(125, 20);
            this.frmEngine.TabIndex = 21;
            this.frmEngine.TextChanged += new System.EventHandler(this.frmEngine_TextChanged);
            // 
            // frmMake
            // 
            this.frmMake.Location = new System.Drawing.Point(215, 111);
            this.frmMake.Name = "frmMake";
            this.frmMake.Size = new System.Drawing.Size(201, 20);
            this.frmMake.TabIndex = 20;
            this.frmMake.TextChanged += new System.EventHandler(this.frmMake_TextChanged);
            // 
            // frmVehicleReg
            // 
            this.frmVehicleReg.Location = new System.Drawing.Point(215, 78);
            this.frmVehicleReg.Name = "frmVehicleReg";
            this.frmVehicleReg.Size = new System.Drawing.Size(125, 20);
            this.frmVehicleReg.TabIndex = 19;
            this.frmVehicleReg.TextChanged += new System.EventHandler(this.frmVehicleReg_TextChanged);
            // 
            // frmAvailLabel
            // 
            this.frmAvailLabel.AutoSize = true;
            this.frmAvailLabel.Location = new System.Drawing.Point(50, 230);
            this.frmAvailLabel.Name = "frmAvailLabel";
            this.frmAvailLabel.Size = new System.Drawing.Size(50, 13);
            this.frmAvailLabel.TabIndex = 18;
            this.frmAvailLabel.Text = "Available";
            // 
            // frmRentalLabel
            // 
            this.frmRentalLabel.AutoSize = true;
            this.frmRentalLabel.Location = new System.Drawing.Point(50, 205);
            this.frmRentalLabel.Name = "frmRentalLabel";
            this.frmRentalLabel.Size = new System.Drawing.Size(79, 13);
            this.frmRentalLabel.TabIndex = 17;
            this.frmRentalLabel.Text = "Rental Per Day";
            // 
            // frmDateLabel
            // 
            this.frmDateLabel.AutoSize = true;
            this.frmDateLabel.Location = new System.Drawing.Point(50, 173);
            this.frmDateLabel.Name = "frmDateLabel";
            this.frmDateLabel.Size = new System.Drawing.Size(84, 13);
            this.frmDateLabel.TabIndex = 16;
            this.frmDateLabel.Text = "Date Registered";
            // 
            // FrmEngineLabel
            // 
            this.FrmEngineLabel.AutoSize = true;
            this.FrmEngineLabel.Location = new System.Drawing.Point(50, 142);
            this.FrmEngineLabel.Name = "FrmEngineLabel";
            this.FrmEngineLabel.Size = new System.Drawing.Size(63, 13);
            this.FrmEngineLabel.TabIndex = 15;
            this.FrmEngineLabel.Text = "Engine Size";
            // 
            // frmMakeLabel
            // 
            this.frmMakeLabel.AutoSize = true;
            this.frmMakeLabel.Location = new System.Drawing.Point(50, 111);
            this.frmMakeLabel.Name = "frmMakeLabel";
            this.frmMakeLabel.Size = new System.Drawing.Size(34, 13);
            this.frmMakeLabel.TabIndex = 14;
            this.frmMakeLabel.Text = "Make";
            // 
            // frmVehicleRegLabel
            // 
            this.frmVehicleRegLabel.AutoSize = true;
            this.frmVehicleRegLabel.Location = new System.Drawing.Point(50, 78);
            this.frmVehicleRegLabel.Name = "frmVehicleRegLabel";
            this.frmVehicleRegLabel.Size = new System.Drawing.Size(141, 13);
            this.frmVehicleRegLabel.TabIndex = 13;
            this.frmVehicleRegLabel.Text = "Vehicle Registration Number";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(187, 276);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 40);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCLear
            // 
            this.btnCLear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLear.Location = new System.Drawing.Point(53, 276);
            this.btnCLear.Name = "btnCLear";
            this.btnCLear.Size = new System.Drawing.Size(111, 40);
            this.btnCLear.TabIndex = 26;
            this.btnCLear.Text = "Clear";
            this.btnCLear.UseVisualStyleBackColor = true;
            this.btnCLear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(323, 276);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 40);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmRentalPerDay
            // 
            this.frmRentalPerDay.Location = new System.Drawing.Point(215, 203);
            this.frmRentalPerDay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.frmRentalPerDay.Name = "frmRentalPerDay";
            this.frmRentalPerDay.Size = new System.Drawing.Size(120, 20);
            this.frmRentalPerDay.TabIndex = 28;
            this.frmRentalPerDay.ValueChanged += new System.EventHandler(this.frmRentalPerDay_ValueChanged);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(466, 350);
            this.Controls.Add(this.frmRentalPerDay);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCLear);
            this.Controls.Add(this.btnAdd);
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
            this.Name = "frmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAdd";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frmRentalPerDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCLear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.NumericUpDown frmRentalPerDay;
    }
}