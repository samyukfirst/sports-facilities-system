namespace SportsFacilities
{
    partial class SearchFacilityForm
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
            this.FacilityNameLabel = new System.Windows.Forms.Label();
            this.FacilityNameComboBox = new System.Windows.Forms.ComboBox();
            this.CheckAvailabilityButton = new System.Windows.Forms.Button();
            this.SearchDataGrid = new System.Windows.Forms.DataGridView();
            this.SearchCloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SearchDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FacilityNameLabel
            // 
            this.FacilityNameLabel.AutoSize = true;
            this.FacilityNameLabel.Location = new System.Drawing.Point(39, 56);
            this.FacilityNameLabel.Name = "FacilityNameLabel";
            this.FacilityNameLabel.Size = new System.Drawing.Size(70, 13);
            this.FacilityNameLabel.TabIndex = 0;
            this.FacilityNameLabel.Text = "Facility Name";
            // 
            // FacilityNameComboBox
            // 
            this.FacilityNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FacilityNameComboBox.FormattingEnabled = true;
            this.FacilityNameComboBox.Location = new System.Drawing.Point(153, 53);
            this.FacilityNameComboBox.Name = "FacilityNameComboBox";
            this.FacilityNameComboBox.Size = new System.Drawing.Size(119, 21);
            this.FacilityNameComboBox.TabIndex = 1;
            this.FacilityNameComboBox.DropDown += new System.EventHandler(this.FacilityNameComboBox_SelectedIndexChanged);
            this.FacilityNameComboBox.SelectedIndexChanged += new System.EventHandler(this.FacilityNameComboBox_SelectedIndexChanged);
            // 
            // CheckAvailabilityButton
            // 
            this.CheckAvailabilityButton.Location = new System.Drawing.Point(287, 51);
            this.CheckAvailabilityButton.Name = "CheckAvailabilityButton";
            this.CheckAvailabilityButton.Size = new System.Drawing.Size(109, 23);
            this.CheckAvailabilityButton.TabIndex = 2;
            this.CheckAvailabilityButton.Text = "Check Availability";
            this.CheckAvailabilityButton.UseVisualStyleBackColor = true;
            this.CheckAvailabilityButton.Click += new System.EventHandler(this.CheckAvailabilityButton_Click);
            // 
            // SearchDataGrid
            // 
            this.SearchDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchDataGrid.Location = new System.Drawing.Point(33, 105);
            this.SearchDataGrid.Name = "SearchDataGrid";
            this.SearchDataGrid.Size = new System.Drawing.Size(355, 179);
            this.SearchDataGrid.TabIndex = 3;
            // 
            // SearchCloseButton
            // 
            this.SearchCloseButton.Location = new System.Drawing.Point(175, 305);
            this.SearchCloseButton.Name = "SearchCloseButton";
            this.SearchCloseButton.Size = new System.Drawing.Size(75, 23);
            this.SearchCloseButton.TabIndex = 4;
            this.SearchCloseButton.Text = "Close";
            this.SearchCloseButton.UseVisualStyleBackColor = true;
            this.SearchCloseButton.Click += new System.EventHandler(this.SearchCloseButton_Click);
            // 
            // SearchFacilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 348);
            this.Controls.Add(this.SearchCloseButton);
            this.Controls.Add(this.SearchDataGrid);
            this.Controls.Add(this.CheckAvailabilityButton);
            this.Controls.Add(this.FacilityNameComboBox);
            this.Controls.Add(this.FacilityNameLabel);
            this.Name = "SearchFacilityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchFacility";
            ((System.ComponentModel.ISupportInitialize)(this.SearchDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FacilityNameLabel;
        private System.Windows.Forms.ComboBox FacilityNameComboBox;
        private System.Windows.Forms.Button CheckAvailabilityButton;
        private System.Windows.Forms.DataGridView SearchDataGrid;
        private System.Windows.Forms.Button SearchCloseButton;
    }
}