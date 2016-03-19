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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentReservations)).BeginInit();
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 439);
            this.Controls.Add(this.mcDate);
            this.Controls.Add(this.dgvCurrentReservations);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table Reservation System";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentReservations)).EndInit();
            this.ResumeLayout(false);

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
    }
}

