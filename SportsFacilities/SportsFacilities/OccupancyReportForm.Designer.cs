namespace SportsFacilities
{
    partial class OccupancyReportForm
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
            this.OccupancyReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // OccupancyReportViewer
            // 
            this.OccupancyReportViewer.ActiveViewIndex = -1;
            this.OccupancyReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OccupancyReportViewer.CachedPageNumberPerDoc = 10;
            this.OccupancyReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.OccupancyReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OccupancyReportViewer.Location = new System.Drawing.Point(0, 0);
            this.OccupancyReportViewer.Name = "OccupancyReportViewer";
            this.OccupancyReportViewer.Size = new System.Drawing.Size(284, 262);
            this.OccupancyReportViewer.TabIndex = 0;
            this.OccupancyReportViewer.Load += new System.EventHandler(this.OccupancyReportViewer_Load);
            // 
            // OccupancyReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.OccupancyReportViewer);
            this.Name = "OccupancyReportForm";
            this.Text = "OccupancyReportForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer OccupancyReportViewer;
    }
}