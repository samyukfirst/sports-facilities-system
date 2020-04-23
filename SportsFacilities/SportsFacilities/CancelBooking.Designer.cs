namespace SportsFacilities
{
    partial class CancelBooking
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
            this.facNameTextBox = new System.Windows.Forms.TextBox();
            this.BookingIdComboBox = new System.Windows.Forms.ComboBox();
            this.MemNamelabel = new System.Windows.Forms.Label();
            this.memberLookupBtn = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dateOfUseddtp = new System.Windows.Forms.DateTimePicker();
            this.txtMemId = new System.Windows.Forms.TextBox();
            this.txttimeFrom = new System.Windows.Forms.TextBox();
            this.txtTimeTo = new System.Windows.Forms.TextBox();
            this.DateOfUseDtp = new System.Windows.Forms.Label();
            this.MemberIdLabel = new System.Windows.Forms.Label();
            this.facilitylabel = new System.Windows.Forms.Label();
            this.TimeFromLabel = new System.Windows.Forms.Label();
            this.ToTimeLabel = new System.Windows.Forms.Label();
            this.BookingIdlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // facNameTextBox
            // 
            this.facNameTextBox.Location = new System.Drawing.Point(115, 149);
            this.facNameTextBox.Name = "facNameTextBox";
            this.facNameTextBox.ReadOnly = true;
            this.facNameTextBox.Size = new System.Drawing.Size(126, 20);
            this.facNameTextBox.TabIndex = 61;
            // 
            // BookingIdComboBox
            // 
            this.BookingIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BookingIdComboBox.FormattingEnabled = true;
            this.BookingIdComboBox.Location = new System.Drawing.Point(113, 106);
            this.BookingIdComboBox.Name = "BookingIdComboBox";
            this.BookingIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.BookingIdComboBox.TabIndex = 60;
            this.BookingIdComboBox.SelectedValueChanged += new System.EventHandler(this.getFacilityName);
            // 
            // MemNamelabel
            // 
            this.MemNamelabel.AutoSize = true;
            this.MemNamelabel.Location = new System.Drawing.Point(108, 71);
            this.MemNamelabel.Name = "MemNamelabel";
            this.MemNamelabel.Size = new System.Drawing.Size(133, 13);
            this.MemNamelabel.TabIndex = 59;
            this.MemNamelabel.Text = "MemberNameLabelHidden";
            this.MemNamelabel.Visible = false;
            // 
            // memberLookupBtn
            // 
            this.memberLookupBtn.Location = new System.Drawing.Point(221, 32);
            this.memberLookupBtn.Name = "memberLookupBtn";
            this.memberLookupBtn.Size = new System.Drawing.Size(36, 20);
            this.memberLookupBtn.TabIndex = 58;
            this.memberLookupBtn.Text = "...";
            this.memberLookupBtn.UseVisualStyleBackColor = true;
            this.memberLookupBtn.Click += new System.EventHandler(this.memberLookupBtn_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(221, 240);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(153, 23);
            this.btnView.TabIndex = 57;
            this.btnView.Text = "View Cancelled Bookings";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(111, 240);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 23);
            this.btnCancel.TabIndex = 56;
            this.btnCancel.Text = "Cancel Booking";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dateOfUseddtp
            // 
            this.dateOfUseddtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfUseddtp.Location = new System.Drawing.Point(347, 30);
            this.dateOfUseddtp.Name = "dateOfUseddtp";
            this.dateOfUseddtp.Size = new System.Drawing.Size(103, 20);
            this.dateOfUseddtp.TabIndex = 55;
            // 
            // txtMemId
            // 
            this.txtMemId.Location = new System.Drawing.Point(111, 30);
            this.txtMemId.Name = "txtMemId";
            this.txtMemId.ReadOnly = true;
            this.txtMemId.Size = new System.Drawing.Size(100, 20);
            this.txtMemId.TabIndex = 54;
            // 
            // txttimeFrom
            // 
            this.txttimeFrom.Location = new System.Drawing.Point(115, 191);
            this.txttimeFrom.Name = "txttimeFrom";
            this.txttimeFrom.ReadOnly = true;
            this.txttimeFrom.Size = new System.Drawing.Size(100, 20);
            this.txttimeFrom.TabIndex = 53;
            // 
            // txtTimeTo
            // 
            this.txtTimeTo.Location = new System.Drawing.Point(295, 191);
            this.txtTimeTo.Name = "txtTimeTo";
            this.txtTimeTo.ReadOnly = true;
            this.txtTimeTo.Size = new System.Drawing.Size(100, 20);
            this.txtTimeTo.TabIndex = 52;
            // 
            // DateOfUseDtp
            // 
            this.DateOfUseDtp.AutoSize = true;
            this.DateOfUseDtp.Location = new System.Drawing.Point(275, 33);
            this.DateOfUseDtp.Name = "DateOfUseDtp";
            this.DateOfUseDtp.Size = new System.Drawing.Size(66, 13);
            this.DateOfUseDtp.TabIndex = 51;
            this.DateOfUseDtp.Text = "Date Of Use";
            // 
            // MemberIdLabel
            // 
            this.MemberIdLabel.AutoSize = true;
            this.MemberIdLabel.Location = new System.Drawing.Point(28, 32);
            this.MemberIdLabel.Name = "MemberIdLabel";
            this.MemberIdLabel.Size = new System.Drawing.Size(57, 13);
            this.MemberIdLabel.TabIndex = 50;
            this.MemberIdLabel.Text = "Member Id";
            // 
            // facilitylabel
            // 
            this.facilitylabel.AutoSize = true;
            this.facilitylabel.Location = new System.Drawing.Point(31, 152);
            this.facilitylabel.Name = "facilitylabel";
            this.facilitylabel.Size = new System.Drawing.Size(70, 13);
            this.facilitylabel.TabIndex = 49;
            this.facilitylabel.Text = "Facility Name";
            // 
            // TimeFromLabel
            // 
            this.TimeFromLabel.AutoSize = true;
            this.TimeFromLabel.Location = new System.Drawing.Point(31, 191);
            this.TimeFromLabel.Name = "TimeFromLabel";
            this.TimeFromLabel.Size = new System.Drawing.Size(62, 13);
            this.TimeFromLabel.TabIndex = 48;
            this.TimeFromLabel.Text = "Time(From):";
            // 
            // ToTimeLabel
            // 
            this.ToTimeLabel.AutoSize = true;
            this.ToTimeLabel.Location = new System.Drawing.Point(237, 194);
            this.ToTimeLabel.Name = "ToTimeLabel";
            this.ToTimeLabel.Size = new System.Drawing.Size(52, 13);
            this.ToTimeLabel.TabIndex = 47;
            this.ToTimeLabel.Text = "Time(To):";
            // 
            // BookingIdlabel
            // 
            this.BookingIdlabel.AutoSize = true;
            this.BookingIdlabel.Location = new System.Drawing.Point(30, 106);
            this.BookingIdlabel.Name = "BookingIdlabel";
            this.BookingIdlabel.Size = new System.Drawing.Size(58, 13);
            this.BookingIdlabel.TabIndex = 46;
            this.BookingIdlabel.Text = "Booking Id";
            // 
            // CancelBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 302);
            this.Controls.Add(this.facNameTextBox);
            this.Controls.Add(this.BookingIdComboBox);
            this.Controls.Add(this.MemNamelabel);
            this.Controls.Add(this.memberLookupBtn);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dateOfUseddtp);
            this.Controls.Add(this.txtMemId);
            this.Controls.Add(this.txttimeFrom);
            this.Controls.Add(this.txtTimeTo);
            this.Controls.Add(this.DateOfUseDtp);
            this.Controls.Add(this.MemberIdLabel);
            this.Controls.Add(this.facilitylabel);
            this.Controls.Add(this.TimeFromLabel);
            this.Controls.Add(this.ToTimeLabel);
            this.Controls.Add(this.BookingIdlabel);
            this.Name = "CancelBooking";
            this.Text = "CancelBooking";
            this.Load += new System.EventHandler(this.CancelBooking_Load);
            this.Click += new System.EventHandler(this.CancelBooking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox facNameTextBox;
        private System.Windows.Forms.ComboBox BookingIdComboBox;
        private System.Windows.Forms.Label MemNamelabel;
        private System.Windows.Forms.Button memberLookupBtn;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dateOfUseddtp;
        private System.Windows.Forms.TextBox txtMemId;
        private System.Windows.Forms.TextBox txttimeFrom;
        private System.Windows.Forms.TextBox txtTimeTo;
        private System.Windows.Forms.Label DateOfUseDtp;
        private System.Windows.Forms.Label MemberIdLabel;
        private System.Windows.Forms.Label facilitylabel;
        private System.Windows.Forms.Label TimeFromLabel;
        private System.Windows.Forms.Label ToTimeLabel;
        private System.Windows.Forms.Label BookingIdlabel;


    }
}