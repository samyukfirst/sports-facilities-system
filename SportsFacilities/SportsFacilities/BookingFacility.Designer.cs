namespace SportsFacilities
{
    partial class frmBookingFacility
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
            this.HiddenSlotIdLabel = new System.Windows.Forms.Label();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.MemNamelabel = new System.Windows.Forms.Label();
            this.memberLookupBtn = new System.Windows.Forms.Button();
            this.slotLookupBtn = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.FacilityNamecombobox = new System.Windows.Forms.ComboBox();
            this.dateOfUseddtp = new System.Windows.Forms.DateTimePicker();
            this.txtMemId = new System.Windows.Forms.TextBox();
            this.txttimeFrom = new System.Windows.Forms.TextBox();
            this.txtTimeTo = new System.Windows.Forms.TextBox();
            this.txtbookingId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MemberIdLabel = new System.Windows.Forms.Label();
            this.facilitylabel = new System.Windows.Forms.Label();
            this.TimeFromLabel = new System.Windows.Forms.Label();
            this.ToTimeLabel = new System.Windows.Forms.Label();
            this.BookingIdlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HiddenSlotIdLabel
            // 
            this.HiddenSlotIdLabel.AutoSize = true;
            this.HiddenSlotIdLabel.Location = new System.Drawing.Point(398, 161);
            this.HiddenSlotIdLabel.Name = "HiddenSlotIdLabel";
            this.HiddenSlotIdLabel.Size = new System.Drawing.Size(68, 13);
            this.HiddenSlotIdLabel.TabIndex = 43;
            this.HiddenSlotIdLabel.Text = "HiddenSlotId";
            this.HiddenSlotIdLabel.Visible = false;
            // 
            // PrintBtn
            // 
            this.PrintBtn.Location = new System.Drawing.Point(299, 241);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(75, 23);
            this.PrintBtn.TabIndex = 42;
            this.PrintBtn.Text = "Print";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Visible = false;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // MemNamelabel
            // 
            this.MemNamelabel.AutoSize = true;
            this.MemNamelabel.Location = new System.Drawing.Point(103, 110);
            this.MemNamelabel.Name = "MemNamelabel";
            this.MemNamelabel.Size = new System.Drawing.Size(133, 13);
            this.MemNamelabel.TabIndex = 41;
            this.MemNamelabel.Text = "MemberNameLabelHidden";
            this.MemNamelabel.Visible = false;
            // 
            // memberLookupBtn
            // 
            this.memberLookupBtn.Location = new System.Drawing.Point(218, 72);
            this.memberLookupBtn.Name = "memberLookupBtn";
            this.memberLookupBtn.Size = new System.Drawing.Size(36, 20);
            this.memberLookupBtn.TabIndex = 40;
            this.memberLookupBtn.Text = "...";
            this.memberLookupBtn.UseVisualStyleBackColor = true;
            this.memberLookupBtn.Click += new System.EventHandler(this.memberLookupBtn_Click);
            // 
            // slotLookupBtn
            // 
            this.slotLookupBtn.Location = new System.Drawing.Point(401, 192);
            this.slotLookupBtn.Name = "slotLookupBtn";
            this.slotLookupBtn.Size = new System.Drawing.Size(36, 20);
            this.slotLookupBtn.TabIndex = 39;
            this.slotLookupBtn.Text = "...";
            this.slotLookupBtn.UseVisualStyleBackColor = true;
            this.slotLookupBtn.Click += new System.EventHandler(this.slotLookupBtn_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(49, 241);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 38;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(211, 241);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 37;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(130, 241);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FacilityNamecombobox
            // 
            this.FacilityNamecombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FacilityNamecombobox.FormattingEnabled = true;
            this.FacilityNamecombobox.Location = new System.Drawing.Point(106, 153);
            this.FacilityNamecombobox.Name = "FacilityNamecombobox";
            this.FacilityNamecombobox.Size = new System.Drawing.Size(148, 21);
            this.FacilityNamecombobox.TabIndex = 35;
            this.FacilityNamecombobox.SelectedValueChanged += new System.EventHandler(this.FacilityNamecombobox_SelectedValueChanged);
            // 
            // dateOfUseddtp
            // 
            this.dateOfUseddtp.Location = new System.Drawing.Point(299, 30);
            this.dateOfUseddtp.Name = "dateOfUseddtp";
            this.dateOfUseddtp.Size = new System.Drawing.Size(183, 20);
            this.dateOfUseddtp.TabIndex = 34;
            // 
            // txtMemId
            // 
            this.txtMemId.Location = new System.Drawing.Point(105, 72);
            this.txtMemId.Name = "txtMemId";
            this.txtMemId.ReadOnly = true;
            this.txtMemId.Size = new System.Drawing.Size(100, 20);
            this.txtMemId.TabIndex = 33;
            // 
            // txttimeFrom
            // 
            this.txttimeFrom.Location = new System.Drawing.Point(105, 192);
            this.txttimeFrom.Name = "txttimeFrom";
            this.txttimeFrom.ReadOnly = true;
            this.txttimeFrom.Size = new System.Drawing.Size(100, 20);
            this.txttimeFrom.TabIndex = 32;
            // 
            // txtTimeTo
            // 
            this.txtTimeTo.Location = new System.Drawing.Point(285, 192);
            this.txtTimeTo.Name = "txtTimeTo";
            this.txtTimeTo.ReadOnly = true;
            this.txtTimeTo.Size = new System.Drawing.Size(100, 20);
            this.txtTimeTo.TabIndex = 31;
            // 
            // txtbookingId
            // 
            this.txtbookingId.Location = new System.Drawing.Point(105, 30);
            this.txtbookingId.Name = "txtbookingId";
            this.txtbookingId.ReadOnly = true;
            this.txtbookingId.Size = new System.Drawing.Size(100, 20);
            this.txtbookingId.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Date Of Use";
            // 
            // MemberIdLabel
            // 
            this.MemberIdLabel.AutoSize = true;
            this.MemberIdLabel.Location = new System.Drawing.Point(29, 72);
            this.MemberIdLabel.Name = "MemberIdLabel";
            this.MemberIdLabel.Size = new System.Drawing.Size(57, 13);
            this.MemberIdLabel.TabIndex = 28;
            this.MemberIdLabel.Text = "Member Id";
            // 
            // facilitylabel
            // 
            this.facilitylabel.AutoSize = true;
            this.facilitylabel.Location = new System.Drawing.Point(29, 153);
            this.facilitylabel.Name = "facilitylabel";
            this.facilitylabel.Size = new System.Drawing.Size(70, 13);
            this.facilitylabel.TabIndex = 27;
            this.facilitylabel.Text = "Facility Name";
            // 
            // TimeFromLabel
            // 
            this.TimeFromLabel.AutoSize = true;
            this.TimeFromLabel.Location = new System.Drawing.Point(29, 192);
            this.TimeFromLabel.Name = "TimeFromLabel";
            this.TimeFromLabel.Size = new System.Drawing.Size(62, 13);
            this.TimeFromLabel.TabIndex = 26;
            this.TimeFromLabel.Text = "Time(From):";
            // 
            // ToTimeLabel
            // 
            this.ToTimeLabel.AutoSize = true;
            this.ToTimeLabel.Location = new System.Drawing.Point(227, 195);
            this.ToTimeLabel.Name = "ToTimeLabel";
            this.ToTimeLabel.Size = new System.Drawing.Size(52, 13);
            this.ToTimeLabel.TabIndex = 25;
            this.ToTimeLabel.Text = "Time(To):";
            // 
            // BookingIdlabel
            // 
            this.BookingIdlabel.AutoSize = true;
            this.BookingIdlabel.Location = new System.Drawing.Point(29, 30);
            this.BookingIdlabel.Name = "BookingIdlabel";
            this.BookingIdlabel.Size = new System.Drawing.Size(58, 13);
            this.BookingIdlabel.TabIndex = 24;
            this.BookingIdlabel.Text = "Booking Id";
            // 
            // frmBookingFacility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 299);
            this.Controls.Add(this.HiddenSlotIdLabel);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.MemNamelabel);
            this.Controls.Add(this.memberLookupBtn);
            this.Controls.Add(this.slotLookupBtn);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.FacilityNamecombobox);
            this.Controls.Add(this.dateOfUseddtp);
            this.Controls.Add(this.txtMemId);
            this.Controls.Add(this.txttimeFrom);
            this.Controls.Add(this.txtTimeTo);
            this.Controls.Add(this.txtbookingId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MemberIdLabel);
            this.Controls.Add(this.facilitylabel);
            this.Controls.Add(this.TimeFromLabel);
            this.Controls.Add(this.ToTimeLabel);
            this.Controls.Add(this.BookingIdlabel);
            this.Name = "frmBookingFacility";
            this.Text = "BookingFacility";
            this.Load += new System.EventHandler(this.frmBookingFacility_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HiddenSlotIdLabel;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.Label MemNamelabel;
        private System.Windows.Forms.Button memberLookupBtn;
        private System.Windows.Forms.Button slotLookupBtn;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox FacilityNamecombobox;
        private System.Windows.Forms.DateTimePicker dateOfUseddtp;
        private System.Windows.Forms.TextBox txtMemId;
        private System.Windows.Forms.TextBox txttimeFrom;
        private System.Windows.Forms.TextBox txtTimeTo;
        private System.Windows.Forms.TextBox txtbookingId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label MemberIdLabel;
        private System.Windows.Forms.Label facilitylabel;
        private System.Windows.Forms.Label TimeFromLabel;
        private System.Windows.Forms.Label ToTimeLabel;
        private System.Windows.Forms.Label BookingIdlabel;
    }
}