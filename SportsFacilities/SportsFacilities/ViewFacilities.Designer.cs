namespace SportsFacilities
{
    partial class ViewFacilities
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
            this.FacilityGrid = new System.Windows.Forms.DataGridView();
            this.okbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FacilityGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FacilityGrid
            // 
            this.FacilityGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FacilityGrid.Location = new System.Drawing.Point(29, 30);
            this.FacilityGrid.Name = "FacilityGrid";
            this.FacilityGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FacilityGrid.Size = new System.Drawing.Size(289, 212);
            this.FacilityGrid.TabIndex = 0;
            // 
            // okbutton
            // 
            this.okbutton.Location = new System.Drawing.Point(79, 259);
            this.okbutton.Name = "okbutton";
            this.okbutton.Size = new System.Drawing.Size(75, 23);
            this.okbutton.TabIndex = 1;
            this.okbutton.Text = "Ok";
            this.okbutton.UseVisualStyleBackColor = true;
            this.okbutton.Click += new System.EventHandler(this.okbutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(193, 259);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.cancelbutton.TabIndex = 2;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // ViewFacilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 301);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.okbutton);
            this.Controls.Add(this.FacilityGrid);
            this.Name = "ViewFacilities";
            this.Text = "ViewFacilities";
            this.Load += new System.EventHandler(this.ViewFacilities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FacilityGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FacilityGrid;
        private System.Windows.Forms.Button okbutton;
        private System.Windows.Forms.Button cancelbutton;
    }
}