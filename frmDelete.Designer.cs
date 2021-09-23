
namespace BowmanCarHire
{
    partial class frmDelete
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnCanc = new System.Windows.Forms.Button();
            this.frmAvailable = new System.Windows.Forms.CheckBox();
            this.frmRentalPerDay = new System.Windows.Forms.TextBox();
            this.frmDateReg = new System.Windows.Forms.TextBox();
            this.frmEngine = new System.Windows.Forms.TextBox();
            this.frmMake = new System.Windows.Forms.TextBox();
            this.delVehicleReg = new System.Windows.Forms.TextBox();
            this.frmAvailLabel = new System.Windows.Forms.Label();
            this.frmRentalLabel = new System.Windows.Forms.Label();
            this.frmDateLabel = new System.Windows.Forms.Label();
            this.FrmEngineLabel = new System.Windows.Forms.Label();
            this.frmMakeLabel = new System.Windows.Forms.Label();
            this.frmVehicleRegLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure you want to delete:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(118, 313);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(125, 38);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "DELETE";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnCanc
            // 
            this.btnCanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanc.Location = new System.Drawing.Point(280, 313);
            this.btnCanc.Name = "btnCanc";
            this.btnCanc.Size = new System.Drawing.Size(125, 38);
            this.btnCanc.TabIndex = 2;
            this.btnCanc.Text = "CANCEL";
            this.btnCanc.UseVisualStyleBackColor = true;
            this.btnCanc.Click += new System.EventHandler(this.btnCanc_Click);
            // 
            // frmAvailable
            // 
            this.frmAvailable.AutoSize = true;
            this.frmAvailable.Location = new System.Drawing.Point(280, 282);
            this.frmAvailable.Name = "frmAvailable";
            this.frmAvailable.Size = new System.Drawing.Size(15, 14);
            this.frmAvailable.TabIndex = 24;
            this.frmAvailable.UseVisualStyleBackColor = true;
            // 
            // frmRentalPerDay
            // 
            this.frmRentalPerDay.Location = new System.Drawing.Point(280, 255);
            this.frmRentalPerDay.Name = "frmRentalPerDay";
            this.frmRentalPerDay.Size = new System.Drawing.Size(100, 20);
            this.frmRentalPerDay.TabIndex = 23;
            // 
            // frmDateReg
            // 
            this.frmDateReg.Location = new System.Drawing.Point(280, 223);
            this.frmDateReg.Name = "frmDateReg";
            this.frmDateReg.Size = new System.Drawing.Size(100, 20);
            this.frmDateReg.TabIndex = 22;
            // 
            // frmEngine
            // 
            this.frmEngine.Location = new System.Drawing.Point(280, 192);
            this.frmEngine.Name = "frmEngine";
            this.frmEngine.Size = new System.Drawing.Size(125, 20);
            this.frmEngine.TabIndex = 21;
            // 
            // frmMake
            // 
            this.frmMake.Location = new System.Drawing.Point(280, 161);
            this.frmMake.Name = "frmMake";
            this.frmMake.Size = new System.Drawing.Size(201, 20);
            this.frmMake.TabIndex = 20;
            // 
            // delVehicleReg
            // 
            this.delVehicleReg.Location = new System.Drawing.Point(280, 128);
            this.delVehicleReg.Name = "delVehicleReg";
            this.delVehicleReg.Size = new System.Drawing.Size(125, 20);
            this.delVehicleReg.TabIndex = 19;
            // 
            // frmAvailLabel
            // 
            this.frmAvailLabel.AutoSize = true;
            this.frmAvailLabel.Location = new System.Drawing.Point(115, 280);
            this.frmAvailLabel.Name = "frmAvailLabel";
            this.frmAvailLabel.Size = new System.Drawing.Size(50, 13);
            this.frmAvailLabel.TabIndex = 18;
            this.frmAvailLabel.Text = "Available";
            // 
            // frmRentalLabel
            // 
            this.frmRentalLabel.AutoSize = true;
            this.frmRentalLabel.Location = new System.Drawing.Point(115, 255);
            this.frmRentalLabel.Name = "frmRentalLabel";
            this.frmRentalLabel.Size = new System.Drawing.Size(79, 13);
            this.frmRentalLabel.TabIndex = 17;
            this.frmRentalLabel.Text = "Rental Per Day";
            // 
            // frmDateLabel
            // 
            this.frmDateLabel.AutoSize = true;
            this.frmDateLabel.Location = new System.Drawing.Point(115, 223);
            this.frmDateLabel.Name = "frmDateLabel";
            this.frmDateLabel.Size = new System.Drawing.Size(84, 13);
            this.frmDateLabel.TabIndex = 16;
            this.frmDateLabel.Text = "Date Registered";
            // 
            // FrmEngineLabel
            // 
            this.FrmEngineLabel.AutoSize = true;
            this.FrmEngineLabel.Location = new System.Drawing.Point(115, 192);
            this.FrmEngineLabel.Name = "FrmEngineLabel";
            this.FrmEngineLabel.Size = new System.Drawing.Size(63, 13);
            this.FrmEngineLabel.TabIndex = 15;
            this.FrmEngineLabel.Text = "Engine Size";
            // 
            // frmMakeLabel
            // 
            this.frmMakeLabel.AutoSize = true;
            this.frmMakeLabel.Location = new System.Drawing.Point(115, 161);
            this.frmMakeLabel.Name = "frmMakeLabel";
            this.frmMakeLabel.Size = new System.Drawing.Size(34, 13);
            this.frmMakeLabel.TabIndex = 14;
            this.frmMakeLabel.Text = "Make";
            // 
            // frmVehicleRegLabel
            // 
            this.frmVehicleRegLabel.AutoSize = true;
            this.frmVehicleRegLabel.Location = new System.Drawing.Point(115, 128);
            this.frmVehicleRegLabel.Name = "frmVehicleRegLabel";
            this.frmVehicleRegLabel.Size = new System.Drawing.Size(141, 13);
            this.frmVehicleRegLabel.TabIndex = 13;
            this.frmVehicleRegLabel.Text = "Vehicle Registration Number";
            // 
            // frmDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 380);
            this.Controls.Add(this.frmAvailable);
            this.Controls.Add(this.frmRentalPerDay);
            this.Controls.Add(this.frmDateReg);
            this.Controls.Add(this.frmEngine);
            this.Controls.Add(this.frmMake);
            this.Controls.Add(this.delVehicleReg);
            this.Controls.Add(this.frmAvailLabel);
            this.Controls.Add(this.frmRentalLabel);
            this.Controls.Add(this.frmDateLabel);
            this.Controls.Add(this.FrmEngineLabel);
            this.Controls.Add(this.frmMakeLabel);
            this.Controls.Add(this.frmVehicleRegLabel);
            this.Controls.Add(this.btnCanc);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.label1);
            this.Name = "frmDelete";
            this.Text = "frmDelete";
            this.Load += new System.EventHandler(this.frmDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCanc;
        private System.Windows.Forms.CheckBox frmAvailable;
        private System.Windows.Forms.TextBox frmRentalPerDay;
        private System.Windows.Forms.TextBox frmDateReg;
        private System.Windows.Forms.TextBox frmEngine;
        private System.Windows.Forms.TextBox frmMake;
        private System.Windows.Forms.TextBox delVehicleReg;
        private System.Windows.Forms.Label frmAvailLabel;
        private System.Windows.Forms.Label frmRentalLabel;
        private System.Windows.Forms.Label frmDateLabel;
        private System.Windows.Forms.Label FrmEngineLabel;
        private System.Windows.Forms.Label frmMakeLabel;
        private System.Windows.Forms.Label frmVehicleRegLabel;
    }
}