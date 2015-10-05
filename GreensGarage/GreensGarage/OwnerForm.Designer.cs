namespace GreensGarage
{
    partial class OwnerForm
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
            this.lstOwner = new System.Windows.Forms.ListBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddOwner = new System.Windows.Forms.Button();
            this.btnUpdateOwner = new System.Windows.Forms.Button();
            this.btnDeleteOwner = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panelAddOwner = new System.Windows.Forms.Panel();
            this.lblEditPhoneNumber = new System.Windows.Forms.Label();
            this.lblEditSuburb = new System.Windows.Forms.Label();
            this.lblEditStreetAddress = new System.Windows.Forms.Label();
            this.lblEditFirstName = new System.Windows.Forms.Label();
            this.lblEditLastName = new System.Windows.Forms.Label();
            this.txtEditLastName = new System.Windows.Forms.TextBox();
            this.txtEditPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEditSuburb = new System.Windows.Forms.TextBox();
            this.txtEditStreetAddress = new System.Windows.Forms.TextBox();
            this.txtEditFirstName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveUpdate = new System.Windows.Forms.Button();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.btnUpdateCancel = new System.Windows.Forms.Button();
            this.txtUpdatePhone = new System.Windows.Forms.TextBox();
            this.txtUpdateSuburb = new System.Windows.Forms.TextBox();
            this.txtUpdateStreet = new System.Windows.Forms.TextBox();
            this.txtUpdateFirstName = new System.Windows.Forms.TextBox();
            this.txtUpdateLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblfirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtOwnerID = new System.Windows.Forms.TextBox();
            this.lblOwnerNo = new System.Windows.Forms.Label();
            this.panelAddOwner.SuspendLayout();
            this.panelUpdate.SuspendLayout();
            this.panelDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstOwner
            // 
            this.lstOwner.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lstOwner.FormattingEnabled = true;
            this.lstOwner.Location = new System.Drawing.Point(13, 13);
            this.lstOwner.Name = "lstOwner";
            this.lstOwner.Size = new System.Drawing.Size(217, 407);
            this.lstOwner.TabIndex = 6;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(132, 457);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(98, 23);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click_1);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(13, 457);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(98, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // btnAddOwner
            // 
            this.btnAddOwner.Location = new System.Drawing.Point(258, 457);
            this.btnAddOwner.Name = "btnAddOwner";
            this.btnAddOwner.Size = new System.Drawing.Size(98, 23);
            this.btnAddOwner.TabIndex = 2;
            this.btnAddOwner.Text = "Add Owner";
            this.btnAddOwner.UseVisualStyleBackColor = true;
            this.btnAddOwner.Click += new System.EventHandler(this.btnAddOwner_Click);
            // 
            // btnUpdateOwner
            // 
            this.btnUpdateOwner.Location = new System.Drawing.Point(389, 457);
            this.btnUpdateOwner.Name = "btnUpdateOwner";
            this.btnUpdateOwner.Size = new System.Drawing.Size(98, 23);
            this.btnUpdateOwner.TabIndex = 3;
            this.btnUpdateOwner.Text = "Update Owner";
            this.btnUpdateOwner.UseVisualStyleBackColor = true;
            this.btnUpdateOwner.Click += new System.EventHandler(this.btnUpdateOwner_Click);
            // 
            // btnDeleteOwner
            // 
            this.btnDeleteOwner.Location = new System.Drawing.Point(514, 457);
            this.btnDeleteOwner.Name = "btnDeleteOwner";
            this.btnDeleteOwner.Size = new System.Drawing.Size(98, 23);
            this.btnDeleteOwner.TabIndex = 4;
            this.btnDeleteOwner.Text = "Delete Owner";
            this.btnDeleteOwner.UseVisualStyleBackColor = true;
            this.btnDeleteOwner.Click += new System.EventHandler(this.btnDeleteOwner_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(514, 505);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(98, 23);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click_1);
            // 
            // panelAddOwner
            // 
            this.panelAddOwner.Controls.Add(this.lblEditPhoneNumber);
            this.panelAddOwner.Controls.Add(this.lblEditSuburb);
            this.panelAddOwner.Controls.Add(this.lblEditStreetAddress);
            this.panelAddOwner.Controls.Add(this.lblEditFirstName);
            this.panelAddOwner.Controls.Add(this.lblEditLastName);
            this.panelAddOwner.Controls.Add(this.txtEditLastName);
            this.panelAddOwner.Controls.Add(this.txtEditPhoneNumber);
            this.panelAddOwner.Controls.Add(this.txtEditSuburb);
            this.panelAddOwner.Controls.Add(this.txtEditStreetAddress);
            this.panelAddOwner.Controls.Add(this.txtEditFirstName);
            this.panelAddOwner.Controls.Add(this.btnCancel);
            this.panelAddOwner.Controls.Add(this.btnSave);
            this.panelAddOwner.Location = new System.Drawing.Point(249, 15);
            this.panelAddOwner.Name = "panelAddOwner";
            this.panelAddOwner.Size = new System.Drawing.Size(266, 362);
            this.panelAddOwner.TabIndex = 20;
            this.panelAddOwner.Visible = false;
            // 
            // lblEditPhoneNumber
            // 
            this.lblEditPhoneNumber.AutoSize = true;
            this.lblEditPhoneNumber.Location = new System.Drawing.Point(28, 224);
            this.lblEditPhoneNumber.Name = "lblEditPhoneNumber";
            this.lblEditPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblEditPhoneNumber.TabIndex = 13;
            this.lblEditPhoneNumber.Text = "Phone Number";
            // 
            // lblEditSuburb
            // 
            this.lblEditSuburb.AutoSize = true;
            this.lblEditSuburb.Location = new System.Drawing.Point(28, 181);
            this.lblEditSuburb.Name = "lblEditSuburb";
            this.lblEditSuburb.Size = new System.Drawing.Size(41, 13);
            this.lblEditSuburb.TabIndex = 12;
            this.lblEditSuburb.Text = "Suburb";
            // 
            // lblEditStreetAddress
            // 
            this.lblEditStreetAddress.AutoSize = true;
            this.lblEditStreetAddress.Location = new System.Drawing.Point(28, 138);
            this.lblEditStreetAddress.Name = "lblEditStreetAddress";
            this.lblEditStreetAddress.Size = new System.Drawing.Size(76, 13);
            this.lblEditStreetAddress.TabIndex = 11;
            this.lblEditStreetAddress.Text = "Street Address";
            // 
            // lblEditFirstName
            // 
            this.lblEditFirstName.AutoSize = true;
            this.lblEditFirstName.Location = new System.Drawing.Point(28, 98);
            this.lblEditFirstName.Name = "lblEditFirstName";
            this.lblEditFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblEditFirstName.TabIndex = 10;
            this.lblEditFirstName.Text = "First Name";
            // 
            // lblEditLastName
            // 
            this.lblEditLastName.AutoSize = true;
            this.lblEditLastName.Location = new System.Drawing.Point(28, 52);
            this.lblEditLastName.Name = "lblEditLastName";
            this.lblEditLastName.Size = new System.Drawing.Size(58, 13);
            this.lblEditLastName.TabIndex = 9;
            this.lblEditLastName.Text = "Last Name";
            // 
            // txtEditLastName
            // 
            this.txtEditLastName.Location = new System.Drawing.Point(140, 49);
            this.txtEditLastName.Name = "txtEditLastName";
            this.txtEditLastName.Size = new System.Drawing.Size(100, 20);
            this.txtEditLastName.TabIndex = 7;
            // 
            // txtEditPhoneNumber
            // 
            this.txtEditPhoneNumber.Location = new System.Drawing.Point(140, 224);
            this.txtEditPhoneNumber.Name = "txtEditPhoneNumber";
            this.txtEditPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtEditPhoneNumber.TabIndex = 6;
            // 
            // txtEditSuburb
            // 
            this.txtEditSuburb.Location = new System.Drawing.Point(140, 181);
            this.txtEditSuburb.Name = "txtEditSuburb";
            this.txtEditSuburb.Size = new System.Drawing.Size(100, 20);
            this.txtEditSuburb.TabIndex = 5;
            // 
            // txtEditStreetAddress
            // 
            this.txtEditStreetAddress.Location = new System.Drawing.Point(140, 131);
            this.txtEditStreetAddress.MaxLength = 30;
            this.txtEditStreetAddress.Name = "txtEditStreetAddress";
            this.txtEditStreetAddress.Size = new System.Drawing.Size(100, 20);
            this.txtEditStreetAddress.TabIndex = 4;
            // 
            // txtEditFirstName
            // 
            this.txtEditFirstName.Location = new System.Drawing.Point(140, 98);
            this.txtEditFirstName.Name = "txtEditFirstName";
            this.txtEditFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtEditFirstName.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(140, 312);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(29, 312);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveUpdate
            // 
            this.btnSaveUpdate.Location = new System.Drawing.Point(28, 312);
            this.btnSaveUpdate.Name = "btnSaveUpdate";
            this.btnSaveUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnSaveUpdate.TabIndex = 14;
            this.btnSaveUpdate.Text = "Update";
            this.btnSaveUpdate.UseVisualStyleBackColor = true;
            this.btnSaveUpdate.Click += new System.EventHandler(this.btnSaveUpdate_Click);
            // 
            // panelUpdate
            // 
            this.panelUpdate.Controls.Add(this.btnUpdateCancel);
            this.panelUpdate.Controls.Add(this.txtUpdatePhone);
            this.panelUpdate.Controls.Add(this.txtUpdateSuburb);
            this.panelUpdate.Controls.Add(this.txtUpdateStreet);
            this.panelUpdate.Controls.Add(this.txtUpdateFirstName);
            this.panelUpdate.Controls.Add(this.txtUpdateLastName);
            this.panelUpdate.Controls.Add(this.btnSaveUpdate);
            this.panelUpdate.Controls.Add(this.label5);
            this.panelUpdate.Controls.Add(this.label4);
            this.panelUpdate.Controls.Add(this.label3);
            this.panelUpdate.Controls.Add(this.label2);
            this.panelUpdate.Controls.Add(this.label1);
            this.panelUpdate.Location = new System.Drawing.Point(252, 15);
            this.panelUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(266, 362);
            this.panelUpdate.TabIndex = 21;
            this.panelUpdate.Visible = false;
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.Location = new System.Drawing.Point(147, 312);
            this.btnUpdateCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(68, 23);
            this.btnUpdateCancel.TabIndex = 20;
            this.btnUpdateCancel.Text = "Cancel";
            this.btnUpdateCancel.UseVisualStyleBackColor = true;
            this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
            // 
            // txtUpdatePhone
            // 
            this.txtUpdatePhone.Location = new System.Drawing.Point(118, 220);
            this.txtUpdatePhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdatePhone.Name = "txtUpdatePhone";
            this.txtUpdatePhone.Size = new System.Drawing.Size(98, 20);
            this.txtUpdatePhone.TabIndex = 19;
            // 
            // txtUpdateSuburb
            // 
            this.txtUpdateSuburb.Location = new System.Drawing.Point(118, 184);
            this.txtUpdateSuburb.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateSuburb.Name = "txtUpdateSuburb";
            this.txtUpdateSuburb.Size = new System.Drawing.Size(98, 20);
            this.txtUpdateSuburb.TabIndex = 18;
            // 
            // txtUpdateStreet
            // 
            this.txtUpdateStreet.Location = new System.Drawing.Point(118, 129);
            this.txtUpdateStreet.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateStreet.Name = "txtUpdateStreet";
            this.txtUpdateStreet.Size = new System.Drawing.Size(98, 20);
            this.txtUpdateStreet.TabIndex = 17;
            // 
            // txtUpdateFirstName
            // 
            this.txtUpdateFirstName.Location = new System.Drawing.Point(118, 94);
            this.txtUpdateFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateFirstName.Name = "txtUpdateFirstName";
            this.txtUpdateFirstName.Size = new System.Drawing.Size(98, 20);
            this.txtUpdateFirstName.TabIndex = 16;
            // 
            // txtUpdateLastName
            // 
            this.txtUpdateLastName.Location = new System.Drawing.Point(118, 48);
            this.txtUpdateLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateLastName.Name = "txtUpdateLastName";
            this.txtUpdateLastName.Size = new System.Drawing.Size(98, 20);
            this.txtUpdateLastName.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Suburb";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Street Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Last Name";
            // 
            // panelDelete
            // 
            this.panelDelete.Controls.Add(this.txtPhone);
            this.panelDelete.Controls.Add(this.txtSuburb);
            this.panelDelete.Controls.Add(this.txtStreetAddress);
            this.panelDelete.Controls.Add(this.txtFirstName);
            this.panelDelete.Controls.Add(this.txtLastName);
            this.panelDelete.Controls.Add(this.lblPhoneNumber);
            this.panelDelete.Controls.Add(this.lblSuburb);
            this.panelDelete.Controls.Add(this.lblStreetAddress);
            this.panelDelete.Controls.Add(this.lblfirstName);
            this.panelDelete.Controls.Add(this.lblLastName);
            this.panelDelete.Controls.Add(this.txtOwnerID);
            this.panelDelete.Controls.Add(this.lblOwnerNo);
            this.panelDelete.Location = new System.Drawing.Point(250, 11);
            this.panelDelete.Margin = new System.Windows.Forms.Padding(2);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(266, 362);
            this.panelDelete.TabIndex = 22;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(115, 224);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 25;
            // 
            // txtSuburb
            // 
            this.txtSuburb.AcceptsReturn = true;
            this.txtSuburb.Location = new System.Drawing.Point(115, 181);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.ReadOnly = true;
            this.txtSuburb.Size = new System.Drawing.Size(99, 20);
            this.txtSuburb.TabIndex = 24;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(115, 135);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.ReadOnly = true;
            this.txtStreetAddress.Size = new System.Drawing.Size(99, 20);
            this.txtStreetAddress.TabIndex = 23;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(115, 101);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(99, 20);
            this.txtFirstName.TabIndex = 22;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(115, 53);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(99, 20);
            this.txtLastName.TabIndex = 21;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(16, 227);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNumber.TabIndex = 20;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(16, 184);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(41, 13);
            this.lblSuburb.TabIndex = 19;
            this.lblSuburb.Text = "Suburb";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(16, 138);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(76, 13);
            this.lblStreetAddress.TabIndex = 18;
            this.lblStreetAddress.Text = "Street Address";
            // 
            // lblfirstName
            // 
            this.lblfirstName.AutoSize = true;
            this.lblfirstName.Location = new System.Drawing.Point(16, 101);
            this.lblfirstName.Name = "lblfirstName";
            this.lblfirstName.Size = new System.Drawing.Size(57, 13);
            this.lblfirstName.TabIndex = 17;
            this.lblfirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(16, 56);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 16;
            this.lblLastName.Text = "Last Name";
            // 
            // txtOwnerID
            // 
            this.txtOwnerID.Location = new System.Drawing.Point(115, 13);
            this.txtOwnerID.Name = "txtOwnerID";
            this.txtOwnerID.ReadOnly = true;
            this.txtOwnerID.Size = new System.Drawing.Size(37, 20);
            this.txtOwnerID.TabIndex = 15;
            // 
            // lblOwnerNo
            // 
            this.lblOwnerNo.AutoSize = true;
            this.lblOwnerNo.Location = new System.Drawing.Point(19, 13);
            this.lblOwnerNo.Name = "lblOwnerNo";
            this.lblOwnerNo.Size = new System.Drawing.Size(49, 13);
            this.lblOwnerNo.TabIndex = 14;
            this.lblOwnerNo.Text = "OwnerID";
            // 
            // OwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 540);
            this.Controls.Add(this.panelDelete);
            this.Controls.Add(this.panelAddOwner);
            this.Controls.Add(this.panelUpdate);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteOwner);
            this.Controls.Add(this.btnUpdateOwner);
            this.Controls.Add(this.btnAddOwner);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lstOwner);
            this.Name = "OwnerForm";
            this.Text = "Owner Maintenance";
            this.panelAddOwner.ResumeLayout(false);
            this.panelAddOwner.PerformLayout();
            this.panelUpdate.ResumeLayout(false);
            this.panelUpdate.PerformLayout();
            this.panelDelete.ResumeLayout(false);
            this.panelDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstOwner;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddOwner;
        private System.Windows.Forms.Button btnUpdateOwner;
        private System.Windows.Forms.Button btnDeleteOwner;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel panelAddOwner;
        private System.Windows.Forms.Label lblEditPhoneNumber;
        private System.Windows.Forms.Label lblEditSuburb;
        private System.Windows.Forms.Label lblEditStreetAddress;
        private System.Windows.Forms.Label lblEditFirstName;
        private System.Windows.Forms.Label lblEditLastName;
        private System.Windows.Forms.TextBox txtEditLastName;
        private System.Windows.Forms.TextBox txtEditPhoneNumber;
        private System.Windows.Forms.TextBox txtEditSuburb;
        private System.Windows.Forms.TextBox txtEditStreetAddress;
        private System.Windows.Forms.TextBox txtEditFirstName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveUpdate;
        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.Button btnUpdateCancel;
        private System.Windows.Forms.TextBox txtUpdatePhone;
        private System.Windows.Forms.TextBox txtUpdateSuburb;
        private System.Windows.Forms.TextBox txtUpdateStreet;
        private System.Windows.Forms.TextBox txtUpdateFirstName;
        private System.Windows.Forms.TextBox txtUpdateLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblfirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtOwnerID;
        private System.Windows.Forms.Label lblOwnerNo;
    }
}