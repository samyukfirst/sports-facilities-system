namespace SportsFacilities
{
    partial class OccupancyChartForm
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
            this.OccupancyChartViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // OccupancyChartViewer
            // 
            this.OccupancyChartViewer.ActiveViewIndex = -1;
            this.OccupancyChartViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OccupancyChartViewer.CachedPageNumberPerDoc = 10;
            this.OccupancyChartViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.OccupancyChartViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OccupancyChartViewer.Location = new System.Drawing.Point(0, 0);
            this.OccupancyChartViewer.Name = "OccupancyChartViewer";
            this.OccupancyChartViewer.Size = new System.Drawing.Size(493, 325);
            this.OccupancyChartViewer.TabIndex = 0;
            this.OccupancyChartViewer.Load += new System.EventHandler(this.OccupancyChartViewer_Load);
            // 
            // OccupancyChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 325);
            this.Controls.Add(this.OccupancyChartViewer);
            this.Name = "OccupancyChartForm";
            this.Text = "OccupancyChartForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer OccupancyChartViewer;
    }
}