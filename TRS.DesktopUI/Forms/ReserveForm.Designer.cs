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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReserveForm));
            this.grbReserveData = new System.Windows.Forms.GroupBox();
            this.grbSummary = new System.Windows.Forms.GroupBox();
            this.lblSelectedTable = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gtbTables = new System.Windows.Forms.GroupBox();
            this.dgvTables = new System.Windows.Forms.DataGridView();
            this.ColTableNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCountOfSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbResData = new System.Windows.Forms.GroupBox();
            this.lblCountOfPeople = new System.Windows.Forms.Label();
            this.cbCountOfPeople = new System.Windows.Forms.ComboBox();
            this.btnCheckAvailability = new System.Windows.Forms.Button();
            this.cbTimeTo = new System.Windows.Forms.ComboBox();
            this.cbTimeFrom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblTimeFrom = new System.Windows.Forms.Label();
            this.gbCustomerData = new System.Windows.Forms.GroupBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.grbReserveData.SuspendLayout();
            this.grbSummary.SuspendLayout();
            this.gtbTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).BeginInit();
            this.gbResData.SuspendLayout();
            this.gbCustomerData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbReserveData
            // 
            this.grbReserveData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbReserveData.BackColor = System.Drawing.Color.LightBlue;
            this.grbReserveData.Controls.Add(this.grbSummary);
            this.grbReserveData.Controls.Add(this.btnReserve);
            this.grbReserveData.Controls.Add(this.btnCancel);
            this.grbReserveData.Controls.Add(this.gtbTables);
            this.grbReserveData.Controls.Add(this.gbResData);
            this.grbReserveData.Controls.Add(this.gbCustomerData);
            this.grbReserveData.Location = new System.Drawing.Point(16, 15);
            this.grbReserveData.Name = "grbReserveData";
            this.grbReserveData.Size = new System.Drawing.Size(1006, 622);
            this.grbReserveData.TabIndex = 0;
            this.grbReserveData.TabStop = false;
            // 
            // grbSummary
            // 
            this.grbSummary.Controls.Add(this.lblSelectedTable);
            this.grbSummary.Controls.Add(this.lblCost);
            this.grbSummary.Location = new System.Drawing.Point(19, 490);
            this.grbSummary.Name = "grbSummary";
            this.grbSummary.Size = new System.Drawing.Size(363, 107);
            this.grbSummary.TabIndex = 13;
            this.grbSummary.TabStop = false;
            this.grbSummary.Text = "Summary";
            // 
            // lblSelectedTable
            // 
            this.lblSelectedTable.AutoSize = true;
            this.lblSelectedTable.Location = new System.Drawing.Point(19, 32);
            this.lblSelectedTable.Name = "lblSelectedTable";
            this.lblSelectedTable.Size = new System.Drawing.Size(97, 16);
            this.lblSelectedTable.TabIndex = 1;
            this.lblSelectedTable.Text = "Selected Table";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(19, 67);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(35, 16);
            this.lblCost.TabIndex = 0;
            this.lblCost.Text = "Cost";
            // 
            // btnReserve
            // 
            this.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReserve.Image = global::TRS.DesktopUI.Properties.Resources.symbol_check_icon;
            this.btnReserve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReserve.Location = new System.Drawing.Point(492, 557);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(186, 39);
            this.btnReserve.TabIndex = 1;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Image = global::TRS.DesktopUI.Properties.Resources.symbol_delete_icon;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(706, 557);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(187, 39);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gtbTables
            // 
            this.gtbTables.Controls.Add(this.dgvTables);
            this.gtbTables.Location = new System.Drawing.Point(406, 23);
            this.gtbTables.Name = "gtbTables";
            this.gtbTables.Size = new System.Drawing.Size(576, 447);
            this.gtbTables.TabIndex = 12;
            this.gtbTables.TabStop = false;
            this.gtbTables.Text = "Available tables";
            // 
            // dgvTables
            // 
            this.dgvTables.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvTables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTableNum,
            this.ColRate,
            this.ColCountOfSeats,
            this.ColLocation});
            this.dgvTables.Location = new System.Drawing.Point(24, 37);
            this.dgvTables.Name = "dgvTables";
            this.dgvTables.Size = new System.Drawing.Size(516, 385);
            this.dgvTables.TabIndex = 0;
            this.dgvTables.SelectionChanged += new System.EventHandler(this.dgvTables_SelectionChanged);
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
            this.ColLocation.Width = 150;
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
            this.gbResData.Location = new System.Drawing.Point(19, 23);
            this.gbResData.Name = "gbResData";
            this.gbResData.Size = new System.Drawing.Size(363, 256);
            this.gbResData.TabIndex = 11;
            this.gbResData.TabStop = false;
            this.gbResData.Text = "Reservation details";
            // 
            // lblCountOfPeople
            // 
            this.lblCountOfPeople.AutoSize = true;
            this.lblCountOfPeople.Location = new System.Drawing.Point(21, 162);
            this.lblCountOfPeople.Name = "lblCountOfPeople";
            this.lblCountOfPeople.Size = new System.Drawing.Size(50, 16);
            this.lblCountOfPeople.TabIndex = 18;
            this.lblCountOfPeople.Text = "People";
            // 
            // cbCountOfPeople
            // 
            this.cbCountOfPeople.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountOfPeople.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCountOfPeople.FormattingEnabled = true;
            this.cbCountOfPeople.Location = new System.Drawing.Point(134, 159);
            this.cbCountOfPeople.Name = "cbCountOfPeople";
            this.cbCountOfPeople.Size = new System.Drawing.Size(110, 24);
            this.cbCountOfPeople.TabIndex = 17;
            this.cbCountOfPeople.SelectedIndexChanged += new System.EventHandler(this.cbCountOfPeople_SelectedIndexChanged);
            // 
            // btnCheckAvailability
            // 
            this.btnCheckAvailability.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckAvailability.Image = global::TRS.DesktopUI.Properties.Resources.search_button;
            this.btnCheckAvailability.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckAvailability.Location = new System.Drawing.Point(24, 205);
            this.btnCheckAvailability.Name = "btnCheckAvailability";
            this.btnCheckAvailability.Size = new System.Drawing.Size(222, 29);
            this.btnCheckAvailability.TabIndex = 16;
            this.btnCheckAvailability.Text = "Check availability";
            this.btnCheckAvailability.UseVisualStyleBackColor = true;
            this.btnCheckAvailability.Click += new System.EventHandler(this.btnCheckAvailability_Click);
            // 
            // cbTimeTo
            // 
            this.cbTimeTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeTo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTimeTo.FormattingEnabled = true;
            this.cbTimeTo.Location = new System.Drawing.Point(134, 111);
            this.cbTimeTo.Name = "cbTimeTo";
            this.cbTimeTo.Size = new System.Drawing.Size(110, 24);
            this.cbTimeTo.TabIndex = 14;
            this.cbTimeTo.SelectedIndexChanged += new System.EventHandler(this.cbTimeTo_SelectedIndexChanged);
            // 
            // cbTimeFrom
            // 
            this.cbTimeFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeFrom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTimeFrom.FormattingEnabled = true;
            this.cbTimeFrom.Location = new System.Drawing.Point(134, 71);
            this.cbTimeFrom.Name = "cbTimeFrom";
            this.cbTimeFrom.Size = new System.Drawing.Size(110, 24);
            this.cbTimeFrom.TabIndex = 13;
            this.cbTimeFrom.SelectedIndexChanged += new System.EventHandler(this.cbTimeFrom_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Time To";
            // 
            // lblResDate
            // 
            this.lblResDate.AutoSize = true;
            this.lblResDate.Location = new System.Drawing.Point(21, 28);
            this.lblResDate.Name = "lblResDate";
            this.lblResDate.Size = new System.Drawing.Size(36, 16);
            this.lblResDate.TabIndex = 10;
            this.lblResDate.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(134, 23);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(206, 22);
            this.dtpDate.TabIndex = 9;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // lblTimeFrom
            // 
            this.lblTimeFrom.AutoSize = true;
            this.lblTimeFrom.Location = new System.Drawing.Point(19, 74);
            this.lblTimeFrom.Name = "lblTimeFrom";
            this.lblTimeFrom.Size = new System.Drawing.Size(76, 16);
            this.lblTimeFrom.TabIndex = 0;
            this.lblTimeFrom.Text = "Time From";
            // 
            // gbCustomerData
            // 
            this.gbCustomerData.Controls.Add(this.tbLastName);
            this.gbCustomerData.Controls.Add(this.tbFirstName);
            this.gbCustomerData.Controls.Add(this.lblPhone);
            this.gbCustomerData.Controls.Add(this.tbPhone);
            this.gbCustomerData.Controls.Add(this.lblLastName);
            this.gbCustomerData.Controls.Add(this.lblFirstName);
            this.gbCustomerData.Location = new System.Drawing.Point(19, 287);
            this.gbCustomerData.Name = "gbCustomerData";
            this.gbCustomerData.Size = new System.Drawing.Size(363, 183);
            this.gbCustomerData.TabIndex = 10;
            this.gbCustomerData.TabStop = false;
            this.gbCustomerData.Text = "Customer details";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(134, 83);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(206, 22);
            this.tbLastName.TabIndex = 4;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(134, 39);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(206, 22);
            this.tbFirstName.TabIndex = 3;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(21, 137);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(47, 16);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Phone";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(134, 134);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(206, 22);
            this.tbPhone.TabIndex = 5;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(19, 86);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(63, 16);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "Surname";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(19, 45);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(74, 16);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First name";
            // 
            // ReserveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1044, 651);
            this.Controls.Add(this.grbReserveData);
            this.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReserveForm";
            this.Text = "Make a reservation";
            this.grbReserveData.ResumeLayout(false);
            this.grbSummary.ResumeLayout(false);
            this.grbSummary.PerformLayout();
            this.gtbTables.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).EndInit();
            this.gbResData.ResumeLayout(false);
            this.gbResData.PerformLayout();
            this.gbCustomerData.ResumeLayout(false);
            this.gbCustomerData.PerformLayout();
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
        private System.Windows.Forms.GroupBox grbSummary;
        private System.Windows.Forms.Label lblSelectedTable;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTableNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCountOfSeats;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLocation;
    }
}