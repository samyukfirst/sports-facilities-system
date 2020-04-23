namespace SportsFacilities
{
    partial class frmFacility
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFacName = new System.Windows.Forms.TextBox();
            this.txtFacilityId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFacility = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(191, 144);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(29, 144);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 14;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(272, 144);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 13;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(110, 144);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFacName
            // 
            this.txtFacName.Location = new System.Drawing.Point(144, 90);
            this.txtFacName.Name = "txtFacName";
            this.txtFacName.Size = new System.Drawing.Size(141, 20);
            this.txtFacName.TabIndex = 11;
            // 
            // txtFacilityId
            // 
            this.txtFacilityId.Location = new System.Drawing.Point(144, 45);
            this.txtFacilityId.Name = "txtFacilityId";
            this.txtFacilityId.ReadOnly = true;
            this.txtFacilityId.Size = new System.Drawing.Size(60, 20);
            this.txtFacilityId.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Facility Name";
            // 
            // lblFacility
            // 
            this.lblFacility.AutoSize = true;
            this.lblFacility.Location = new System.Drawing.Point(49, 45);
            this.lblFacility.Name = "lblFacility";
            this.lblFacility.Size = new System.Drawing.Size(53, 13);
            this.lblFacility.TabIndex = 8;
            this.lblFacility.Text = "Facility ID";
            // 
            // frmFacility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 214);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFacName);
            this.Controls.Add(this.txtFacilityId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFacility);
            this.Name = "frmFacility";
            this.Text = "MaintainFacility";
            this.Load += new System.EventHandler(this.frmFacility_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFacName;
        private System.Windows.Forms.TextBox txtFacilityId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFacility;
    }
}