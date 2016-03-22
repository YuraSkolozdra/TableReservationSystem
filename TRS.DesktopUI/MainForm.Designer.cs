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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.rbCanceledRes = new System.Windows.Forms.RadioButton();
            this.rbConfirmedRes = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblAllReservations = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblReservationsDate = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ColReservationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTimeFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTimeTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTableId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPersonsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.grvReservationData.SuspendLayout();
            this.grbSearch.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReservations
            // 
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColReservationId,
            this.ColFirstName,
            this.ColLastName,
            this.ColPhone,
            this.ColTimeFrom,
            this.ColTimeTo,
            this.ColTableId,
            this.ColCost,
            this.ColPersonsCount});
            this.dgvReservations.Location = new System.Drawing.Point(25, 151);
            this.dgvReservations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.Size = new System.Drawing.Size(1108, 347);
            this.dgvReservations.TabIndex = 0;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmFile,
            this.mmHelp});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(1193, 24);
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
            this.dtpDate.Location = new System.Drawing.Point(117, 94);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(265, 22);
            this.dtpDate.TabIndex = 4;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(761, 521);
            this.btnReserve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(165, 38);
            this.btnReserve.TabIndex = 5;
            this.btnReserve.Text = "New Reservation";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // lblReservationCount
            // 
            this.lblReservationCount.AutoSize = true;
            this.lblReservationCount.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReservationCount.Location = new System.Drawing.Point(22, 532);
            this.lblReservationCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReservationCount.Name = "lblReservationCount";
            this.lblReservationCount.Size = new System.Drawing.Size(164, 16);
            this.lblReservationCount.TabIndex = 6;
            this.lblReservationCount.Text = "Count of reservations";
            // 
            // lblTotalGuests
            // 
            this.lblTotalGuests.AutoSize = true;
            this.lblTotalGuests.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalGuests.Location = new System.Drawing.Point(281, 532);
            this.lblTotalGuests.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalGuests.Name = "lblTotalGuests";
            this.lblTotalGuests.Size = new System.Drawing.Size(96, 16);
            this.lblTotalGuests.TabIndex = 7;
            this.lblTotalGuests.Text = "TotalGuests";
            // 
            // grvReservationData
            // 
            this.grvReservationData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grvReservationData.Controls.Add(this.grbSearch);
            this.grvReservationData.Controls.Add(this.lblAllReservations);
            this.grvReservationData.Controls.Add(this.btnCancel);
            this.grvReservationData.Controls.Add(this.lblReservationsDate);
            this.grvReservationData.Controls.Add(this.btnReserve);
            this.grvReservationData.Controls.Add(this.dtpDate);
            this.grvReservationData.Controls.Add(this.lblTotalGuests);
            this.grvReservationData.Controls.Add(this.dgvReservations);
            this.grvReservationData.Controls.Add(this.lblReservationCount);
            this.grvReservationData.Location = new System.Drawing.Point(16, 53);
            this.grvReservationData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grvReservationData.Name = "grvReservationData";
            this.grvReservationData.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grvReservationData.Size = new System.Drawing.Size(1161, 618);
            this.grvReservationData.TabIndex = 8;
            this.grvReservationData.TabStop = false;
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.rbCanceledRes);
            this.grbSearch.Controls.Add(this.rbConfirmedRes);
            this.grbSearch.Controls.Add(this.btnSearch);
            this.grbSearch.Location = new System.Drawing.Point(425, 68);
            this.grbSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbSearch.Size = new System.Drawing.Size(708, 75);
            this.grbSearch.TabIndex = 10;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Searching details";
            // 
            // rbCanceledRes
            // 
            this.rbCanceledRes.AutoSize = true;
            this.rbCanceledRes.Location = new System.Drawing.Point(219, 30);
            this.rbCanceledRes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbCanceledRes.Name = "rbCanceledRes";
            this.rbCanceledRes.Size = new System.Drawing.Size(163, 20);
            this.rbCanceledRes.TabIndex = 2;
            this.rbCanceledRes.TabStop = true;
            this.rbCanceledRes.Text = "Canceled reservations";
            this.rbCanceledRes.UseVisualStyleBackColor = true;
            this.rbCanceledRes.CheckedChanged += new System.EventHandler(this.OnCheckedChange);
            // 
            // rbConfirmedRes
            // 
            this.rbConfirmedRes.AutoSize = true;
            this.rbConfirmedRes.Location = new System.Drawing.Point(35, 30);
            this.rbConfirmedRes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbConfirmedRes.Name = "rbConfirmedRes";
            this.rbConfirmedRes.Size = new System.Drawing.Size(172, 20);
            this.rbConfirmedRes.TabIndex = 1;
            this.rbConfirmedRes.TabStop = true;
            this.rbConfirmedRes.Text = "Confirmed reservations";
            this.rbConfirmedRes.UseVisualStyleBackColor = true;
            this.rbConfirmedRes.CheckedChanged += new System.EventHandler(this.OnCheckedChange);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(547, 26);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(144, 28);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblAllReservations
            // 
            this.lblAllReservations.AutoSize = true;
            this.lblAllReservations.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAllReservations.Location = new System.Drawing.Point(503, 20);
            this.lblAllReservations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllReservations.Name = "lblAllReservations";
            this.lblAllReservations.Size = new System.Drawing.Size(180, 19);
            this.lblAllReservations.TabIndex = 9;
            this.lblAllReservations.Text = "All table\'s reservation info";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(972, 521);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(161, 38);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel Reservation";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblReservationsDate
            // 
            this.lblReservationsDate.AutoSize = true;
            this.lblReservationsDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReservationsDate.Location = new System.Drawing.Point(22, 99);
            this.lblReservationsDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReservationsDate.Name = "lblReservationsDate";
            this.lblReservationsDate.Size = new System.Drawing.Size(76, 16);
            this.lblReservationsDate.TabIndex = 8;
            this.lblReservationsDate.Text = "Select date";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1193, 25);
            this.toolStrip.TabIndex = 10;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // ColReservationId
            // 
            this.ColReservationId.HeaderText = "Reservation Number";
            this.ColReservationId.Name = "ColReservationId";
            // 
            // ColFirstName
            // 
            this.ColFirstName.HeaderText = "First Name";
            this.ColFirstName.Name = "ColFirstName";
            this.ColFirstName.Width = 150;
            // 
            // ColLastName
            // 
            this.ColLastName.HeaderText = "Last Name";
            this.ColLastName.Name = "ColLastName";
            this.ColLastName.Width = 150;
            // 
            // ColPhone
            // 
            this.ColPhone.HeaderText = "Phone";
            this.ColPhone.Name = "ColPhone";
            this.ColPhone.Width = 150;
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
            // ColTableId
            // 
            this.ColTableId.HeaderText = "Table Number";
            this.ColTableId.Name = "ColTableId";
            // 
            // ColCost
            // 
            this.ColCost.HeaderText = "Cost";
            this.ColCost.Name = "ColCost";
            // 
            // ColPersonsCount
            // 
            this.ColPersonsCount.HeaderText = "Count Of People";
            this.ColPersonsCount.Name = "ColPersonsCount";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 717);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.grvReservationData);
            this.Controls.Add(this.mainMenu);
            this.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
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
        private System.Windows.Forms.Label lblReservationsDate;
        private System.Windows.Forms.Label lblAllReservations;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.RadioButton rbCanceledRes;
        private System.Windows.Forms.RadioButton rbConfirmedRes;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColReservationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTimeFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTimeTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTableId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPersonsCount;
    }
}

