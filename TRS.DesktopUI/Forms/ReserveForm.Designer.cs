namespace TRS.DesktopUI.Forms
{
    partial class ReserveForm
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
            this.grbReserveData = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblTimeFrom = new System.Windows.Forms.Label();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbCustomerData = new System.Windows.Forms.GroupBox();
            this.gbResData = new System.Windows.Forms.GroupBox();
            this.lblResDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTimeFrom = new System.Windows.Forms.ComboBox();
            this.cbTimeTo = new System.Windows.Forms.ComboBox();
            this.gtbTables = new System.Windows.Forms.GroupBox();
            this.dgvTables = new System.Windows.Forms.DataGridView();
            this.btnCheckAvailability = new System.Windows.Forms.Button();
            this.cbCountOfPeople = new System.Windows.Forms.ComboBox();
            this.lblCountOfPeople = new System.Windows.Forms.Label();
            this.ColTableNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCountOfSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbSummary = new System.Windows.Forms.GroupBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblSelectedTable = new System.Windows.Forms.Label();
            this.grbReserveData.SuspendLayout();
            this.gbCustomerData.SuspendLayout();
            this.gbResData.SuspendLayout();
            this.gtbTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).BeginInit();
            this.grbSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbReserveData
            // 
            this.grbReserveData.Controls.Add(this.grbSummary);
            this.grbReserveData.Controls.Add(this.btnReserve);
            this.grbReserveData.Controls.Add(this.btnCancel);
            this.grbReserveData.Controls.Add(this.gtbTables);
            this.grbReserveData.Controls.Add(this.gbResData);
            this.grbReserveData.Controls.Add(this.gbCustomerData);
            this.grbReserveData.Location = new System.Drawing.Point(12, 12);
            this.grbReserveData.Name = "grbReserveData";
            this.grbReserveData.Size = new System.Drawing.Size(857, 505);
            this.grbReserveData.TabIndex = 0;
            this.grbReserveData.TabStop = false;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(100, 19);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(156, 20);
            this.dtpDate.TabIndex = 9;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(15, 112);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Phone";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(15, 71);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(49, 13);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "Surname";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(15, 32);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(55, 13);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First name";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(100, 109);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(156, 20);
            this.tbPhone.TabIndex = 5;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(100, 68);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(156, 20);
            this.tbLastName.TabIndex = 4;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(100, 32);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(156, 20);
            this.tbFirstName.TabIndex = 3;
            // 
            // lblTimeFrom
            // 
            this.lblTimeFrom.AutoSize = true;
            this.lblTimeFrom.Location = new System.Drawing.Point(15, 61);
            this.lblTimeFrom.Name = "lblTimeFrom";
            this.lblTimeFrom.Size = new System.Drawing.Size(56, 13);
            this.lblTimeFrom.TabIndex = 0;
            this.lblTimeFrom.Text = "Time From";
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(420, 443);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(140, 32);
            this.btnReserve.TabIndex = 1;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(620, 443);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(141, 32);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbCustomerData
            // 
            this.gbCustomerData.Controls.Add(this.tbLastName);
            this.gbCustomerData.Controls.Add(this.tbFirstName);
            this.gbCustomerData.Controls.Add(this.lblPhone);
            this.gbCustomerData.Controls.Add(this.tbPhone);
            this.gbCustomerData.Controls.Add(this.lblLastName);
            this.gbCustomerData.Controls.Add(this.lblFirstName);
            this.gbCustomerData.Location = new System.Drawing.Point(15, 233);
            this.gbCustomerData.Name = "gbCustomerData";
            this.gbCustomerData.Size = new System.Drawing.Size(273, 149);
            this.gbCustomerData.TabIndex = 10;
            this.gbCustomerData.TabStop = false;
            this.gbCustomerData.Text = "Customer details";
            // 
            // gbResData
            // 
            this.gbResData.Controls.Add(this.lblCountOfPeople);
            this.gbResData.Controls.Add(this.cbCountOfPeople);
            this.gbResData.Controls.Add(this.btnCheckAvailability);
            this.gbResData.Controls.Add(this.cbTimeTo);
            this.gbResData.Controls.Add(this.cbTimeFrom);
            this.gbResData.Controls.Add(this.label1);
            this.gbResData.Controls.Add(this.lblResDate);
            this.gbResData.Controls.Add(this.dtpDate);
            this.gbResData.Controls.Add(this.lblTimeFrom);
            this.gbResData.Location = new System.Drawing.Point(15, 19);
            this.gbResData.Name = "gbResData";
            this.gbResData.Size = new System.Drawing.Size(273, 208);
            this.gbResData.TabIndex = 11;
            this.gbResData.TabStop = false;
            this.gbResData.Text = "Reservation details";
            // 
            // lblResDate
            // 
            this.lblResDate.AutoSize = true;
            this.lblResDate.Location = new System.Drawing.Point(15, 20);
            this.lblResDate.Name = "lblResDate";
            this.lblResDate.Size = new System.Drawing.Size(30, 13);
            this.lblResDate.TabIndex = 10;
            this.lblResDate.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Time To";
            // 
            // cbTimeFrom
            // 
            this.cbTimeFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeFrom.FormattingEnabled = true;
            this.cbTimeFrom.Location = new System.Drawing.Point(100, 58);
            this.cbTimeFrom.Name = "cbTimeFrom";
            this.cbTimeFrom.Size = new System.Drawing.Size(84, 21);
            this.cbTimeFrom.TabIndex = 13;
            this.cbTimeFrom.SelectedIndexChanged += new System.EventHandler(this.cbTimeFrom_SelectedIndexChanged);
            // 
            // cbTimeTo
            // 
            this.cbTimeTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeTo.FormattingEnabled = true;
            this.cbTimeTo.Location = new System.Drawing.Point(100, 90);
            this.cbTimeTo.Name = "cbTimeTo";
            this.cbTimeTo.Size = new System.Drawing.Size(84, 21);
            this.cbTimeTo.TabIndex = 14;
            this.cbTimeTo.SelectedIndexChanged += new System.EventHandler(this.cbTimeTo_SelectedIndexChanged);
            // 
            // gtbTables
            // 
            this.gtbTables.Controls.Add(this.dgvTables);
            this.gtbTables.Location = new System.Drawing.Point(304, 19);
            this.gtbTables.Name = "gtbTables";
            this.gtbTables.Size = new System.Drawing.Size(529, 363);
            this.gtbTables.TabIndex = 12;
            this.gtbTables.TabStop = false;
            this.gtbTables.Text = "Available tables";
            // 
            // dgvTables
            // 
            this.dgvTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTableNum,
            this.ColRate,
            this.ColCountOfSeats,
            this.ColLocation});
            this.dgvTables.Location = new System.Drawing.Point(18, 30);
            this.dgvTables.Name = "dgvTables";
            this.dgvTables.Size = new System.Drawing.Size(487, 313);
            this.dgvTables.TabIndex = 0;
            this.dgvTables.SelectionChanged += new System.EventHandler(this.dgvTables_SelectionChanged);
            // 
            // btnCheckAvailability
            // 
            this.btnCheckAvailability.Location = new System.Drawing.Point(18, 166);
            this.btnCheckAvailability.Name = "btnCheckAvailability";
            this.btnCheckAvailability.Size = new System.Drawing.Size(166, 23);
            this.btnCheckAvailability.TabIndex = 16;
            this.btnCheckAvailability.Text = "Check availability";
            this.btnCheckAvailability.UseVisualStyleBackColor = true;
            this.btnCheckAvailability.Click += new System.EventHandler(this.btnCheckAvailability_Click);
            // 
            // cbCountOfPeople
            // 
            this.cbCountOfPeople.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountOfPeople.FormattingEnabled = true;
            this.cbCountOfPeople.Location = new System.Drawing.Point(100, 129);
            this.cbCountOfPeople.Name = "cbCountOfPeople";
            this.cbCountOfPeople.Size = new System.Drawing.Size(84, 21);
            this.cbCountOfPeople.TabIndex = 17;
            this.cbCountOfPeople.SelectedIndexChanged += new System.EventHandler(this.cbCountOfPeople_SelectedIndexChanged);
            // 
            // lblCountOfPeople
            // 
            this.lblCountOfPeople.AutoSize = true;
            this.lblCountOfPeople.Location = new System.Drawing.Point(15, 132);
            this.lblCountOfPeople.Name = "lblCountOfPeople";
            this.lblCountOfPeople.Size = new System.Drawing.Size(40, 13);
            this.lblCountOfPeople.TabIndex = 18;
            this.lblCountOfPeople.Text = "People";
            // 
            // ColTableNum
            // 
            this.ColTableNum.HeaderText = "Table Number";
            this.ColTableNum.Name = "ColTableNum";
            // 
            // ColRate
            // 
            this.ColRate.HeaderText = "Rate";
            this.ColRate.Name = "ColRate";
            // 
            // ColCountOfSeats
            // 
            this.ColCountOfSeats.HeaderText = "Count of seats";
            this.ColCountOfSeats.Name = "ColCountOfSeats";
            // 
            // ColLocation
            // 
            this.ColLocation.HeaderText = "Location";
            this.ColLocation.Name = "ColLocation";
            // 
            // grbSummary
            // 
            this.grbSummary.Controls.Add(this.lblSelectedTable);
            this.grbSummary.Controls.Add(this.lblCost);
            this.grbSummary.Location = new System.Drawing.Point(15, 398);
            this.grbSummary.Name = "grbSummary";
            this.grbSummary.Size = new System.Drawing.Size(273, 87);
            this.grbSummary.TabIndex = 13;
            this.grbSummary.TabStop = false;
            this.grbSummary.Text = "Summary";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(15, 55);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(28, 13);
            this.lblCost.TabIndex = 0;
            this.lblCost.Text = "Cost";
            // 
            // lblSelectedTable
            // 
            this.lblSelectedTable.AutoSize = true;
            this.lblSelectedTable.Location = new System.Drawing.Point(15, 26);
            this.lblSelectedTable.Name = "lblSelectedTable";
            this.lblSelectedTable.Size = new System.Drawing.Size(79, 13);
            this.lblSelectedTable.TabIndex = 1;
            this.lblSelectedTable.Text = "Selected Table";
            // 
            // ReserveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 529);
            this.Controls.Add(this.grbReserveData);
            this.Name = "ReserveForm";
            this.Text = "Make a reservation";
            this.grbReserveData.ResumeLayout(false);
            this.gbCustomerData.ResumeLayout(false);
            this.gbCustomerData.PerformLayout();
            this.gbResData.ResumeLayout(false);
            this.gbResData.PerformLayout();
            this.gtbTables.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).EndInit();
            this.grbSummary.ResumeLayout(false);
            this.grbSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbReserveData;
        private System.Windows.Forms.Label lblTimeFrom;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.GroupBox gbCustomerData;
        private System.Windows.Forms.GroupBox gbResData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResDate;
        private System.Windows.Forms.ComboBox cbTimeFrom;
        private System.Windows.Forms.ComboBox cbTimeTo;
        private System.Windows.Forms.GroupBox gtbTables;
        private System.Windows.Forms.DataGridView dgvTables;
        private System.Windows.Forms.Button btnCheckAvailability;
        private System.Windows.Forms.Label lblCountOfPeople;
        private System.Windows.Forms.ComboBox cbCountOfPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTableNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCountOfSeats;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLocation;
        private System.Windows.Forms.GroupBox grbSummary;
        private System.Windows.Forms.Label lblSelectedTable;
        private System.Windows.Forms.Label lblCost;
    }
}