namespace SportsFacilities
{
    partial class LaunchPadForm
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
            this.CancelBookingMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MastersMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MembersMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FacilitiesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MakeNewBookingMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListOfMembersMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OccupancyRateMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRateReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelBookingMenu
            // 
            this.CancelBookingMenu.Name = "CancelBookingMenu";
            this.CancelBookingMenu.Size = new System.Drawing.Size(208, 22);
            this.CancelBookingMenu.Text = "Cancel Booking";
            this.CancelBookingMenu.Click += new System.EventHandler(this.CancelBookingMenu_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MastersMenu,
            this.bookingToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(491, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MastersMenu
            // 
            this.MastersMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MembersMenu,
            this.FacilitiesMenu,
            this.toolStripMenuItem1,
            this.ExitMenu});
            this.MastersMenu.Name = "MastersMenu";
            this.MastersMenu.Size = new System.Drawing.Size(60, 20);
            this.MastersMenu.Text = "Masters";
            // 
            // MembersMenu
            // 
            this.MembersMenu.Name = "MembersMenu";
            this.MembersMenu.Size = new System.Drawing.Size(124, 22);
            this.MembersMenu.Text = "Members";
            this.MembersMenu.Click += new System.EventHandler(this.MembersMenu_Click);
            // 
            // FacilitiesMenu
            // 
            this.FacilitiesMenu.Name = "FacilitiesMenu";
            this.FacilitiesMenu.Size = new System.Drawing.Size(124, 22);
            this.FacilitiesMenu.Text = "Facilities";
            this.FacilitiesMenu.Click += new System.EventHandler(this.FacilitiesMenu_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(121, 6);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(124, 22);
            this.ExitMenu.Text = "Exit";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MakeNewBookingMenu,
            this.CancelBookingMenu,
            this.searchToolStripMenuItem});
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.bookingToolStripMenuItem.Text = "Bookings";
            // 
            // MakeNewBookingMenu
            // 
            this.MakeNewBookingMenu.Name = "MakeNewBookingMenu";
            this.MakeNewBookingMenu.Size = new System.Drawing.Size(208, 22);
            this.MakeNewBookingMenu.Text = "Make New Booking";
            this.MakeNewBookingMenu.Click += new System.EventHandler(this.MakeNewBookingMenu_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.searchToolStripMenuItem.Text = "Search Available Facilities";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListOfMembersMenu,
            this.OccupancyRateMenu});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // ListOfMembersMenu
            // 
            this.ListOfMembersMenu.Name = "ListOfMembersMenu";
            this.ListOfMembersMenu.Size = new System.Drawing.Size(177, 22);
            this.ListOfMembersMenu.Text = "List of Members";
            this.ListOfMembersMenu.Click += new System.EventHandler(this.ListOfMembersMenu_Click);
            // 
            // OccupancyRateMenu
            // 
            this.OccupancyRateMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewRateReportToolStripMenuItem,
            this.viewChartToolStripMenuItem});
            this.OccupancyRateMenu.Name = "OccupancyRateMenu";
            this.OccupancyRateMenu.Size = new System.Drawing.Size(177, 22);
            this.OccupancyRateMenu.Text = "Occupancy Reports";
            // 
            // viewRateReportToolStripMenuItem
            // 
            this.viewRateReportToolStripMenuItem.Name = "viewRateReportToolStripMenuItem";
            this.viewRateReportToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.viewRateReportToolStripMenuItem.Text = "View Rate Report";
            this.viewRateReportToolStripMenuItem.Click += new System.EventHandler(this.viewRateReportToolStripMenuItem_Click);
            // 
            // viewChartToolStripMenuItem
            // 
            this.viewChartToolStripMenuItem.Name = "viewChartToolStripMenuItem";
            this.viewChartToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.viewChartToolStripMenuItem.Text = "View Chart";
            this.viewChartToolStripMenuItem.Click += new System.EventHandler(this.viewChartToolStripMenuItem_Click);
            // 
            // LaunchPadForm
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 378);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "LaunchPadForm";
            this.Text = "Sports Facility Booking System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem CancelBookingMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MastersMenu;
        private System.Windows.Forms.ToolStripMenuItem MembersMenu;
        private System.Windows.Forms.ToolStripMenuItem FacilitiesMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MakeNewBookingMenu;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListOfMembersMenu;
        private System.Windows.Forms.ToolStripMenuItem OccupancyRateMenu;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewRateReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewChartToolStripMenuItem;
    }
}