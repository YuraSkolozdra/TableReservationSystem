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
            this.dgvCurrentReservations = new System.Windows.Forms.DataGridView();
            this.ColTableId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTimeFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTimeTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPersonsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mcDate = new System.Windows.Forms.MonthCalendar();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mmFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mmHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnReserve = new System.Windows.Forms.Button();
            this.lblReservationCount = new System.Windows.Forms.Label();
            this.lblTotalGuests = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentReservations)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCurrentReservations
            // 
            this.dgvCurrentReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentReservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTableId,
            this.ColFirstName,
            this.ColLastName,
            this.ColPhone,
            this.ColTimeFrom,
            this.ColTimeTo,
            this.ColPersonsCount});
            this.dgvCurrentReservations.Location = new System.Drawing.Point(190, 72);
            this.dgvCurrentReservations.Name = "dgvCurrentReservations";
            this.dgvCurrentReservations.Size = new System.Drawing.Size(751, 252);
            this.dgvCurrentReservations.TabIndex = 0;
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
            // mcDate
            // 
            this.mcDate.Location = new System.Drawing.Point(14, 72);
            this.mcDate.MaxSelectionCount = 1;
            this.mcDate.Name = "mcDate";
            this.mcDate.TabIndex = 1;
            this.mcDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mcDate_DateSelected);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmFile,
            this.mmHelp});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(953, 24);
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(43, 278);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(67, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(532, 354);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(124, 31);
            this.btnReserve.TabIndex = 5;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            // 
            // lblReservationCount
            // 
            this.lblReservationCount.AutoSize = true;
            this.lblReservationCount.Location = new System.Drawing.Point(190, 379);
            this.lblReservationCount.Name = "lblReservationCount";
            this.lblReservationCount.Size = new System.Drawing.Size(107, 13);
            this.lblReservationCount.TabIndex = 6;
            this.lblReservationCount.Text = "Count of reservations";
            // 
            // lblTotalGuests
            // 
            this.lblTotalGuests.AutoSize = true;
            this.lblTotalGuests.Location = new System.Drawing.Point(359, 379);
            this.lblTotalGuests.Name = "lblTotalGuests";
            this.lblTotalGuests.Size = new System.Drawing.Size(64, 13);
            this.lblTotalGuests.TabIndex = 7;
            this.lblTotalGuests.Text = "TotalGuests";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 439);
            this.Controls.Add(this.lblTotalGuests);
            this.Controls.Add(this.lblReservationCount);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.mcDate);
            this.Controls.Add(this.dgvCurrentReservations);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table Reservation System";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentReservations)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCurrentReservations;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTableId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTimeFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTimeTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPersonsCount;
        private System.Windows.Forms.MonthCalendar mcDate;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem mmFile;
        private System.Windows.Forms.ToolStripMenuItem mmFileExit;
        private System.Windows.Forms.ToolStripMenuItem mmHelp;
        private System.Windows.Forms.ToolStripMenuItem mmHelpAbout;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Label lblReservationCount;
        private System.Windows.Forms.Label lblTotalGuests;
    }
}

