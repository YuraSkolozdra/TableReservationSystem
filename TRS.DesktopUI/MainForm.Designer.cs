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
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.grvReservationData.SuspendLayout();
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
            this.dgvReservations.Location = new System.Drawing.Point(19, 45);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.Size = new System.Drawing.Size(947, 282);
            this.dgvReservations.TabIndex = 0;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmFile,
            this.mmHelp});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1024, 24);
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
            this.dtpDate.Location = new System.Drawing.Point(119, 19);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 4;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(688, 434);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(124, 31);
            this.btnReserve.TabIndex = 5;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // lblReservationCount
            // 
            this.lblReservationCount.AutoSize = true;
            this.lblReservationCount.Location = new System.Drawing.Point(25, 343);
            this.lblReservationCount.Name = "lblReservationCount";
            this.lblReservationCount.Size = new System.Drawing.Size(107, 13);
            this.lblReservationCount.TabIndex = 6;
            this.lblReservationCount.Text = "Count of reservations";
            // 
            // lblTotalGuests
            // 
            this.lblTotalGuests.AutoSize = true;
            this.lblTotalGuests.Location = new System.Drawing.Point(162, 343);
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
            this.grvReservationData.Controls.Add(this.lblReservationsDate);
            this.grvReservationData.Controls.Add(this.dtpDate);
            this.grvReservationData.Controls.Add(this.lblTotalGuests);
            this.grvReservationData.Controls.Add(this.dgvReservations);
            this.grvReservationData.Controls.Add(this.lblReservationCount);
            this.grvReservationData.Location = new System.Drawing.Point(12, 39);
            this.grvReservationData.Name = "grvReservationData";
            this.grvReservationData.Size = new System.Drawing.Size(992, 389);
            this.grvReservationData.TabIndex = 8;
            this.grvReservationData.TabStop = false;
            // 
            // lblReservationsDate
            // 
            this.lblReservationsDate.AutoSize = true;
            this.lblReservationsDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReservationsDate.Location = new System.Drawing.Point(25, 19);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 603);
            this.Controls.Add(this.grvReservationData);
            this.Controls.Add(this.btnReserve);
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
    }
}

