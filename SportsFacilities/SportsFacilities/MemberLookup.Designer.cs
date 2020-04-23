namespace SportsFacilities
{
    partial class frmMemberLookup
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
            this.MemberGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MemberGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(212, 266);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.cancelbutton.TabIndex = 8;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // okbutton
            // 
            this.okbutton.Location = new System.Drawing.Point(98, 266);
            this.okbutton.Name = "okbutton";
            this.okbutton.Size = new System.Drawing.Size(75, 23);
            this.okbutton.TabIndex = 7;
            this.okbutton.Text = "Ok";
            this.okbutton.UseVisualStyleBackColor = true;
            this.okbutton.Click += new System.EventHandler(this.okbutton_Click);
            // 
            // MemberGrid
            // 
            this.MemberGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberGrid.Location = new System.Drawing.Point(48, 37);
            this.MemberGrid.Name = "MemberGrid";
            this.MemberGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MemberGrid.Size = new System.Drawing.Size(289, 212);
            this.MemberGrid.TabIndex = 6;
            // 
            // frmMemberLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 321);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.okbutton);
            this.Controls.Add(this.MemberGrid);
            this.Name = "frmMemberLookup";
            this.Text = "MemberLookup";
            this.Load += new System.EventHandler(this.frmMemberLookup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MemberGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button okbutton;
        private System.Windows.Forms.DataGridView MemberGrid;
    }
}