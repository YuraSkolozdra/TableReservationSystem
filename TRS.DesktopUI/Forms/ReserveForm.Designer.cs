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
            this.SuspendLayout();
            // 
            // grbReserveData
            // 
            this.grbReserveData.Location = new System.Drawing.Point(41, 36);
            this.grbReserveData.Name = "grbReserveData";
            this.grbReserveData.Size = new System.Drawing.Size(311, 277);
            this.grbReserveData.TabIndex = 0;
            this.grbReserveData.TabStop = false;
            // 
            // ReserveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 444);
            this.Controls.Add(this.grbReserveData);
            this.Name = "ReserveForm";
            this.Text = "ReserveForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbReserveData;
    }
}