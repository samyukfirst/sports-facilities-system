namespace SportsFacilities
{
    partial class MembersReport
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
            this.MembersReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // MembersReportViewer
            // 
            this.MembersReportViewer.ActiveViewIndex = -1;
            this.MembersReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MembersReportViewer.CachedPageNumberPerDoc = 10;
            this.MembersReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.MembersReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MembersReportViewer.Location = new System.Drawing.Point(0, 0);
            this.MembersReportViewer.Name = "MembersReportViewer";
            this.MembersReportViewer.Size = new System.Drawing.Size(578, 319);
            this.MembersReportViewer.TabIndex = 0;
            // 
            // MembersReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 319);
            this.Controls.Add(this.MembersReportViewer);
            this.Name = "MembersReport";
            this.Text = "Sports Facility System- Member Information";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer MembersReportViewer;

    }
}