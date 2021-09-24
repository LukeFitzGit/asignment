
namespace BowmanCarHire
{
    partial class frmSearch
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
            this.frmFieldLabel = new System.Windows.Forms.Label();
            this.frmOperatorLabel = new System.Windows.Forms.Label();
            this.frmValueLabel = new System.Windows.Forms.Label();
            this.cboField = new System.Windows.Forms.ComboBox();
            this.cboOperator = new System.Windows.Forms.ComboBox();
            this.valueTextbox = new System.Windows.Forms.TextBox();
            this.frmDataGrid = new System.Windows.Forms.DataGridView();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.frmDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // frmFieldLabel
            // 
            this.frmFieldLabel.AutoSize = true;
            this.frmFieldLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.frmFieldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmFieldLabel.Location = new System.Drawing.Point(38, 63);
            this.frmFieldLabel.Name = "frmFieldLabel";
            this.frmFieldLabel.Size = new System.Drawing.Size(38, 16);
            this.frmFieldLabel.TabIndex = 0;
            this.frmFieldLabel.Text = "Field";
            this.frmFieldLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmOperatorLabel
            // 
            this.frmOperatorLabel.AutoSize = true;
            this.frmOperatorLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.frmOperatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmOperatorLabel.Location = new System.Drawing.Point(216, 63);
            this.frmOperatorLabel.Name = "frmOperatorLabel";
            this.frmOperatorLabel.Size = new System.Drawing.Size(61, 16);
            this.frmOperatorLabel.TabIndex = 1;
            this.frmOperatorLabel.Text = "Operator";
            // 
            // frmValueLabel
            // 
            this.frmValueLabel.AutoSize = true;
            this.frmValueLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.frmValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmValueLabel.Location = new System.Drawing.Point(349, 63);
            this.frmValueLabel.Name = "frmValueLabel";
            this.frmValueLabel.Size = new System.Drawing.Size(43, 16);
            this.frmValueLabel.TabIndex = 2;
            this.frmValueLabel.Text = "Value";
            // 
            // cboField
            // 
            this.cboField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboField.FormattingEnabled = true;
            this.cboField.Location = new System.Drawing.Point(41, 100);
            this.cboField.Name = "cboField";
            this.cboField.Size = new System.Drawing.Size(121, 21);
            this.cboField.TabIndex = 3;
            this.cboField.SelectedIndexChanged += new System.EventHandler(this.cboField_SelectedIndexChanged);
            // 
            // cboOperator
            // 
            this.cboOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperator.FormattingEnabled = true;
            this.cboOperator.Location = new System.Drawing.Point(219, 100);
            this.cboOperator.Name = "cboOperator";
            this.cboOperator.Size = new System.Drawing.Size(58, 21);
            this.cboOperator.TabIndex = 4;
            this.cboOperator.SelectedIndexChanged += new System.EventHandler(this.cboOperator_SelectedIndexChanged);
            // 
            // valueTextbox
            // 
            this.valueTextbox.Location = new System.Drawing.Point(352, 100);
            this.valueTextbox.Name = "valueTextbox";
            this.valueTextbox.Size = new System.Drawing.Size(147, 20);
            this.valueTextbox.TabIndex = 5;
            // 
            // frmDataGrid
            // 
            this.frmDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frmDataGrid.Location = new System.Drawing.Point(32, 158);
            this.frmDataGrid.Name = "frmDataGrid";
            this.frmDataGrid.Size = new System.Drawing.Size(579, 152);
            this.frmDataGrid.TabIndex = 6;
            this.frmDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRun.FlatAppearance.BorderSize = 0;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(524, 31);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(103, 51);
            this.btnRun.TabIndex = 7;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(524, 88);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 50);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(32, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 107);
            this.panel1.TabIndex = 9;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(639, 322);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.frmDataGrid);
            this.Controls.Add(this.valueTextbox);
            this.Controls.Add(this.cboOperator);
            this.Controls.Add(this.cboField);
            this.Controls.Add(this.frmValueLabel);
            this.Controls.Add(this.frmOperatorLabel);
            this.Controls.Add(this.frmFieldLabel);
            this.Controls.Add(this.panel1);
            this.Name = "frmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Task A Luke Fitzgerald 17/09/2021";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frmDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label frmFieldLabel;
        private System.Windows.Forms.Label frmOperatorLabel;
        private System.Windows.Forms.Label frmValueLabel;
        private System.Windows.Forms.ComboBox cboField;
        private System.Windows.Forms.ComboBox cboOperator;
        private System.Windows.Forms.TextBox valueTextbox;
        private System.Windows.Forms.DataGridView frmDataGrid;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
    }
}