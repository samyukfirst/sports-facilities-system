namespace SportsFacilities
{
    partial class SlotLookUpForm
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
            this.cancelbutton = new System.Windows.Forms.Button();
            this.okbutton = new System.Windows.Forms.Button();
            this.SlotGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SlotGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(201, 258);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.cancelbutton.TabIndex = 8;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // okbutton
            // 
            this.okbutton.Location = new System.Drawing.Point(87, 258);
            this.okbutton.Name = "okbutton";
            this.okbutton.Size = new System.Drawing.Size(75, 23);
            this.okbutton.TabIndex = 7;
            this.okbutton.Text = "Ok";
            this.okbutton.UseVisualStyleBackColor = true;
            this.okbutton.Click += new System.EventHandler(this.okbutton_Click);
            // 
            // SlotGrid
            // 
            this.SlotGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SlotGrid.Location = new System.Drawing.Point(37, 29);
            this.SlotGrid.Name = "SlotGrid";
            this.SlotGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SlotGrid.Size = new System.Drawing.Size(289, 212);
            this.SlotGrid.TabIndex = 6;
            // 
            // SlotLookUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 314);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.okbutton);
            this.Controls.Add(this.SlotGrid);
            this.Name = "SlotLookUpForm";
            this.Text = "SlotLookUpForm";
            this.Load += new System.EventHandler(this.SlotLookUpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SlotGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button okbutton;
        private System.Windows.Forms.DataGridView SlotGrid;
    }
}