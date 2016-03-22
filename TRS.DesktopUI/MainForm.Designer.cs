namespace TRS.DesktopUI
{
    partial class MainForm
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
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mmFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mmHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnReserve = new System.Windows.Forms.Button();
            this.lblReservationCount = new System.Windows.Forms.Label();
            this.lblTotalGuests = new System.Windows.Forms.Label();
            this.grvReservationData = new System.Windows.Forms.GroupBox();
            this.lblReservationsDate = new System.Windows.Forms.Label();
            this.ColReservationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTableId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTimeFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTimeTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPersonsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAllReservations = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.grvReservationData.SuspendLayout();
            this.grbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReservations
            // 
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColReservationId,
            this.ColTableId,
            this.ColFirstName,
            this.ColLastName,
            this.ColPhone,
            this.ColTimeFrom,
            this.ColTimeTo,
            this.ColPersonsCount,
            this.ColCost});
            this.dgvReservations.Location = new System.Drawing.Point(19, 123);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.Size = new System.Drawing.Size(969, 282);
            this.dgvReservations.TabIndex = 0;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmFile,
            this.mmHelp});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1051, 24);
            this.mainMenu.TabIndex = 2;
            this.mainMenu.Text = "mainMenu";
            // 
            // mmFile
            // 
            this.mmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmFileExit});
            this.mmFile.Name = "mmFile";
            this.mmFile.Size = new System.Drawing.Size(37, 20);
            this.mmFile.Text = "File";
            // 
            // mmFileExit
            // 
            this.mmFileExit.Name = "mmFileExit";
            this.mmFileExit.Size = new System.Drawing.Size(92, 22);
            this.mmFileExit.Text = "Exit";
            // 
            // mmHelp
            // 
            this.mmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmHelpAbout});
            this.mmHelp.Name = "mmHelp";
            this.mmHelp.Size = new System.Drawing.Size(44, 20);
            this.mmHelp.Text = "Help";
            // 
            // mmHelpAbout
            // 
            this.mmHelpAbout.Name = "mmHelpAbout";
            this.mmHelpAbout.Size = new System.Drawing.Size(147, 22);
            this.mmHelpAbout.Text = "About Author";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(109, 66);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 4;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(711, 432);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(124, 31);
            this.btnReserve.TabIndex = 5;
            this.btnReserve.Text = "New Reservation";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // lblReservationCount
            // 
            this.lblReservationCount.AutoSize = true;
            this.lblReservationCount.Location = new System.Drawing.Point(16, 432);
            this.lblReservationCount.Name = "lblReservationCount";
            this.lblReservationCount.Size = new System.Drawing.Size(107, 13);
            this.lblReservationCount.TabIndex = 6;
            this.lblReservationCount.Text = "Count of reservations";
            // 
            // lblTotalGuests
            // 
            this.lblTotalGuests.AutoSize = true;
            this.lblTotalGuests.Location = new System.Drawing.Point(152, 432);
            this.lblTotalGuests.Name = "lblTotalGuests";
            this.lblTotalGuests.Size = new System.Drawing.Size(64, 13);
            this.lblTotalGuests.TabIndex = 7;
            this.lblTotalGuests.Text = "TotalGuests";
            // 
            // grvReservationData
            // 
            this.grvReservationData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grvReservationData.Controls.Add(this.grbSearch);
            this.grvReservationData.Controls.Add(this.btnCancel);
            this.grvReservationData.Controls.Add(this.lblReservationsDate);
            this.grvReservationData.Controls.Add(this.btnReserve);
            this.grvReservationData.Controls.Add(this.dtpDate);
            this.grvReservationData.Controls.Add(this.lblTotalGuests);
            this.grvReservationData.Controls.Add(this.dgvReservations);
            this.grvReservationData.Controls.Add(this.lblReservationCount);
            this.grvReservationData.Location = new System.Drawing.Point(12, 62);
            this.grvReservationData.Name = "grvReservationData";
            this.grvReservationData.Size = new System.Drawing.Size(1027, 500);
            this.grvReservationData.TabIndex = 8;
            this.grvReservationData.TabStop = false;
            // 
            // lblReservationsDate
            // 
            this.lblReservationsDate.AutoSize = true;
            this.lblReservationsDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReservationsDate.Location = new System.Drawing.Point(27, 67);
            this.lblReservationsDate.Name = "lblReservationsDate";
            this.lblReservationsDate.Size = new System.Drawing.Size(76, 16);
            this.lblReservationsDate.TabIndex = 8;
            this.lblReservationsDate.Text = "Select date";
            // 
            // ColReservationId
            // 
            this.ColReservationId.HeaderText = "Reservation Number";
            this.ColReservationId.Name = "ColReservationId";
            // 
            // ColTableId
            // 
            this.ColTableId.HeaderText = "Table Number";
            this.ColTableId.Name = "ColTableId";
            // 
            // ColFirstName
            // 
            this.ColFirstName.HeaderText = "First Name";
            this.ColFirstName.Name = "ColFirstName";
            // 
            // ColLastName
            // 
            this.ColLastName.HeaderText = "Last Name";
            this.ColLastName.Name = "ColLastName";
            // 
            // ColPhone
            // 
            this.ColPhone.HeaderText = "Phone";
            this.ColPhone.Name = "ColPhone";
            // 
            // ColTimeFrom
            // 
            this.ColTimeFrom.HeaderText = "From";
            this.ColTimeFrom.Name = "ColTimeFrom";
            // 
            // ColTimeTo
            // 
            this.ColTimeTo.HeaderText = "To";
            this.ColTimeTo.Name = "ColTimeTo";
            // 
            // ColPersonsCount
            // 
            this.ColPersonsCount.HeaderText = "Count Of People";
            this.ColPersonsCount.Name = "ColPersonsCount";
            // 
            // ColCost
            // 
            this.ColCost.HeaderText = "Cost";
            this.ColCost.Name = "ColCost";
            // 
            // lblAllReservations
            // 
            this.lblAllReservations.AutoSize = true;
            this.lblAllReservations.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAllReservations.Location = new System.Drawing.Point(377, 40);
            this.lblAllReservations.Name = "lblAllReservations";
            this.lblAllReservations.Size = new System.Drawing.Size(180, 19);
            this.lblAllReservations.TabIndex = 9;
            this.lblAllReservations.Text = "All table\'s reservation info";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(867, 432);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 31);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel Reservation";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.radioButton2);
            this.grbSearch.Controls.Add(this.rbActive);
            this.grbSearch.Controls.Add(this.btnSearch);
            this.grbSearch.Location = new System.Drawing.Point(457, 46);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(531, 61);
            this.grbSearch.TabIndex = 10;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Searching details";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(410, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Location = new System.Drawing.Point(26, 24);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(115, 17);
            this.rbActive.TabIndex = 1;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Active reservations";
            this.rbActive.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(147, 24);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(130, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Canceled reservations";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 590);
            this.Controls.Add(this.lblAllReservations);
            this.Controls.Add(this.grvReservationData);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table Reservation System";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.grvReservationData.ResumeLayout(false);
            this.grvReservationData.PerformLayout();
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem mmFile;
        private System.Windows.Forms.ToolStripMenuItem mmFileExit;
        private System.Windows.Forms.ToolStripMenuItem mmHelp;
        private System.Windows.Forms.ToolStripMenuItem mmHelpAbout;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Label lblReservationCount;
        private System.Windows.Forms.Label lblTotalGuests;
        private System.Windows.Forms.GroupBox grvReservationData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColReservationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTableId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTimeFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTimeTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPersonsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCost;
        private System.Windows.Forms.Label lblReservationsDate;
        private System.Windows.Forms.Label lblAllReservations;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
    }
}

