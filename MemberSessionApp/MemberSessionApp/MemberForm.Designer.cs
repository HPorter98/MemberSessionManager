
namespace MemberSessionApp
{
    partial class MemberForm
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmgContact = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmboSession = new System.Windows.Forms.ComboBox();
            this.lblfNameError = new System.Windows.Forms.Label();
            this.lbllNameError = new System.Windows.Forms.Label();
            this.lblAddressError = new System.Windows.Forms.Label();
            this.lblPostcodeError = new System.Windows.Forms.Label();
            this.lblContactError = new System.Windows.Forms.Label();
            this.lblEmgError = new System.Windows.Forms.Label();
            this.dateStartYear = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Location = new System.Drawing.Point(162, 65);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(135, 23);
            this.txtFirstName.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 461);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(162, 117);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(135, 23);
            this.txtLastName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(162, 166);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(135, 23);
            this.txtAddress.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Postcode";
            // 
            // txtPostcode
            // 
            this.txtPostcode.Enabled = false;
            this.txtPostcode.Location = new System.Drawing.Point(162, 213);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(135, 23);
            this.txtPostcode.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Contact";
            // 
            // txtContact
            // 
            this.txtContact.Enabled = false;
            this.txtContact.Location = new System.Drawing.Point(162, 266);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(135, 23);
            this.txtContact.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Emergency Contact";
            // 
            // txtEmgContact
            // 
            this.txtEmgContact.Enabled = false;
            this.txtEmgContact.Location = new System.Drawing.Point(162, 324);
            this.txtEmgContact.Name = "txtEmgContact";
            this.txtEmgContact.Size = new System.Drawing.Size(135, 23);
            this.txtEmgContact.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(197, 461);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add To Session";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(105, 490);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Member ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(162, 16);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(135, 23);
            this.txtID.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Start Year";
            // 
            // txtDay
            // 
            this.txtDay.Enabled = false;
            this.txtDay.Location = new System.Drawing.Point(143, 535);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(31, 23);
            this.txtDay.TabIndex = 17;
            // 
            // txtMonth
            // 
            this.txtMonth.Enabled = false;
            this.txtMonth.Location = new System.Drawing.Point(180, 535);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(31, 23);
            this.txtMonth.TabIndex = 19;
            // 
            // txtYear
            // 
            this.txtYear.Enabled = false;
            this.txtYear.Location = new System.Drawing.Point(217, 535);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(61, 23);
            this.txtYear.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(12, 410);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Session Type";
            // 
            // cmboSession
            // 
            this.cmboSession.FormattingEnabled = true;
            this.cmboSession.Items.AddRange(new object[] {
            "All ages",
            "Toddler session",
            "< 12",
            "Skateboards only",
            "Girls only"});
            this.cmboSession.Location = new System.Drawing.Point(162, 407);
            this.cmboSession.Name = "cmboSession";
            this.cmboSession.Size = new System.Drawing.Size(135, 23);
            this.cmboSession.TabIndex = 23;
            // 
            // lblfNameError
            // 
            this.lblfNameError.AutoSize = true;
            this.lblfNameError.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblfNameError.Location = new System.Drawing.Point(161, 91);
            this.lblfNameError.Name = "lblfNameError";
            this.lblfNameError.Size = new System.Drawing.Size(45, 21);
            this.lblfNameError.TabIndex = 24;
            this.lblfNameError.Text = "error";
            this.lblfNameError.Visible = false;
            // 
            // lbllNameError
            // 
            this.lbllNameError.AutoSize = true;
            this.lbllNameError.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbllNameError.Location = new System.Drawing.Point(162, 143);
            this.lbllNameError.Name = "lbllNameError";
            this.lbllNameError.Size = new System.Drawing.Size(45, 21);
            this.lbllNameError.TabIndex = 25;
            this.lbllNameError.Text = "error";
            this.lbllNameError.Visible = false;
            // 
            // lblAddressError
            // 
            this.lblAddressError.AutoSize = true;
            this.lblAddressError.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblAddressError.Location = new System.Drawing.Point(162, 192);
            this.lblAddressError.Name = "lblAddressError";
            this.lblAddressError.Size = new System.Drawing.Size(45, 21);
            this.lblAddressError.TabIndex = 26;
            this.lblAddressError.Text = "error";
            this.lblAddressError.Visible = false;
            // 
            // lblPostcodeError
            // 
            this.lblPostcodeError.AutoSize = true;
            this.lblPostcodeError.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPostcodeError.Location = new System.Drawing.Point(162, 239);
            this.lblPostcodeError.Name = "lblPostcodeError";
            this.lblPostcodeError.Size = new System.Drawing.Size(45, 21);
            this.lblPostcodeError.TabIndex = 27;
            this.lblPostcodeError.Text = "error";
            this.lblPostcodeError.Visible = false;
            // 
            // lblContactError
            // 
            this.lblContactError.AutoSize = true;
            this.lblContactError.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblContactError.Location = new System.Drawing.Point(162, 292);
            this.lblContactError.Name = "lblContactError";
            this.lblContactError.Size = new System.Drawing.Size(45, 21);
            this.lblContactError.TabIndex = 28;
            this.lblContactError.Text = "error";
            this.lblContactError.Visible = false;
            // 
            // lblEmgError
            // 
            this.lblEmgError.AutoSize = true;
            this.lblEmgError.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblEmgError.Location = new System.Drawing.Point(162, 350);
            this.lblEmgError.Name = "lblEmgError";
            this.lblEmgError.Size = new System.Drawing.Size(45, 21);
            this.lblEmgError.TabIndex = 29;
            this.lblEmgError.Text = "error";
            this.lblEmgError.Visible = false;
            // 
            // dateStartYear
            // 
            this.dateStartYear.Enabled = false;
            this.dateStartYear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStartYear.Location = new System.Drawing.Point(162, 370);
            this.dateStartYear.Name = "dateStartYear";
            this.dateStartYear.Size = new System.Drawing.Size(135, 23);
            this.dateStartYear.TabIndex = 30;
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 570);
            this.Controls.Add(this.dateStartYear);
            this.Controls.Add(this.lblEmgError);
            this.Controls.Add(this.lblContactError);
            this.Controls.Add(this.lblPostcodeError);
            this.Controls.Add(this.lblAddressError);
            this.Controls.Add(this.lbllNameError);
            this.Controls.Add(this.lblfNameError);
            this.Controls.Add(this.cmboSession);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmgContact);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtFirstName);
            this.Name = "MemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberForm";
            this.Load += new System.EventHandler(this.MemberForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmgContact;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmboSession;
        private System.Windows.Forms.Label lblfNameError;
        private System.Windows.Forms.Label lbllNameError;
        private System.Windows.Forms.Label lblAddressError;
        private System.Windows.Forms.Label lblPostcodeError;
        private System.Windows.Forms.Label lblContactError;
        private System.Windows.Forms.Label lblEmgError;
        private System.Windows.Forms.DateTimePicker dateStartYear;
    }
}