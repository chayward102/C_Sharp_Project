namespace GreensGarage
{
    partial class VehicleForm
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
            this.lstVehicle = new System.Windows.Forms.ListBox();
            this.lblVehicleID = new System.Windows.Forms.Label();
            this.lblServierType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVehicleID = new System.Windows.Forms.TextBox();
            this.txtPlateNumber = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtOwnerID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.txtOwnerIDUpdate = new System.Windows.Forms.TextBox();
            this.txtModelUpdate = new System.Windows.Forms.TextBox();
            this.txtMakeUpdate = new System.Windows.Forms.TextBox();
            this.txtPlateNumberUpdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancelUpdate = new System.Windows.Forms.Button();
            this.btnUpdateSave = new System.Windows.Forms.Button();
            this.txtLastNameUpdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFirstNameUpdate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVehicleIDUpdate = new System.Windows.Forms.TextBox();
            this.lblVehicleIDUpdate = new System.Windows.Forms.Label();
            this.panelSave = new System.Windows.Forms.Panel();
            this.cmbOwnerAdd = new System.Windows.Forms.ComboBox();
            this.txtModelAdd = new System.Windows.Forms.TextBox();
            this.txtMakeAdd = new System.Windows.Forms.TextBox();
            this.txtPlateNumberAdd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.btnSaveAdd = new System.Windows.Forms.Button();
            this.txtLastNameAdd = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFirstNameAdd = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtVehicleIDAdd = new System.Windows.Forms.TextBox();
            this.lblVehicleIDAdd = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panelUpdate.SuspendLayout();
            this.panelSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstVehicle
            // 
            this.lstVehicle.FormattingEnabled = true;
            this.lstVehicle.Location = new System.Drawing.Point(27, 22);
            this.lstVehicle.Name = "lstVehicle";
            this.lstVehicle.Size = new System.Drawing.Size(183, 355);
            this.lstVehicle.TabIndex = 6;
            this.lstVehicle.Click += new System.EventHandler(this.lstVehicles_Click);
            // 
            // lblVehicleID
            // 
            this.lblVehicleID.AutoSize = true;
            this.lblVehicleID.Location = new System.Drawing.Point(248, 22);
            this.lblVehicleID.Name = "lblVehicleID";
            this.lblVehicleID.Size = new System.Drawing.Size(53, 13);
            this.lblVehicleID.TabIndex = 2;
            this.lblVehicleID.Text = "VehicleID";
            // 
            // lblServierType
            // 
            this.lblServierType.AutoSize = true;
            this.lblServierType.Location = new System.Drawing.Point(248, 63);
            this.lblServierType.Name = "lblServierType";
            this.lblServierType.Size = new System.Drawing.Size(71, 13);
            this.lblServierType.TabIndex = 3;
            this.lblServierType.Text = "Plate Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Make";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "OwnerID";
            // 
            // txtVehicleID
            // 
            this.txtVehicleID.Location = new System.Drawing.Point(318, 22);
            this.txtVehicleID.Name = "txtVehicleID";
            this.txtVehicleID.ReadOnly = true;
            this.txtVehicleID.Size = new System.Drawing.Size(100, 20);
            this.txtVehicleID.TabIndex = 7;
            // 
            // txtPlateNumber
            // 
            this.txtPlateNumber.Location = new System.Drawing.Point(318, 63);
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.ReadOnly = true;
            this.txtPlateNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPlateNumber.TabIndex = 8;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(318, 102);
            this.txtMake.Name = "txtMake";
            this.txtMake.ReadOnly = true;
            this.txtMake.Size = new System.Drawing.Size(100, 20);
            this.txtMake.TabIndex = 9;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(318, 143);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 10;
            // 
            // txtOwnerID
            // 
            this.txtOwnerID.Location = new System.Drawing.Point(318, 185);
            this.txtOwnerID.Name = "txtOwnerID";
            this.txtOwnerID.ReadOnly = true;
            this.txtOwnerID.Size = new System.Drawing.Size(100, 20);
            this.txtOwnerID.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(318, 231);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(318, 265);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 15;
            // 
            // panelUpdate
            // 
            this.panelUpdate.Controls.Add(this.txtOwnerIDUpdate);
            this.panelUpdate.Controls.Add(this.txtModelUpdate);
            this.panelUpdate.Controls.Add(this.txtMakeUpdate);
            this.panelUpdate.Controls.Add(this.txtPlateNumberUpdate);
            this.panelUpdate.Controls.Add(this.label1);
            this.panelUpdate.Controls.Add(this.label2);
            this.panelUpdate.Controls.Add(this.label10);
            this.panelUpdate.Controls.Add(this.label11);
            this.panelUpdate.Controls.Add(this.btnCancelUpdate);
            this.panelUpdate.Controls.Add(this.btnUpdateSave);
            this.panelUpdate.Controls.Add(this.txtLastNameUpdate);
            this.panelUpdate.Controls.Add(this.label8);
            this.panelUpdate.Controls.Add(this.txtFirstNameUpdate);
            this.panelUpdate.Controls.Add(this.label9);
            this.panelUpdate.Controls.Add(this.txtVehicleIDUpdate);
            this.panelUpdate.Controls.Add(this.lblVehicleIDUpdate);
            this.panelUpdate.Location = new System.Drawing.Point(246, 6);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(188, 346);
            this.panelUpdate.TabIndex = 16;
            this.panelUpdate.Visible = false;
            // 
            // txtOwnerIDUpdate
            // 
            this.txtOwnerIDUpdate.Location = new System.Drawing.Point(79, 177);
            this.txtOwnerIDUpdate.Name = "txtOwnerIDUpdate";
            this.txtOwnerIDUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtOwnerIDUpdate.TabIndex = 39;
            // 
            // txtModelUpdate
            // 
            this.txtModelUpdate.Location = new System.Drawing.Point(79, 135);
            this.txtModelUpdate.Name = "txtModelUpdate";
            this.txtModelUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtModelUpdate.TabIndex = 38;
            // 
            // txtMakeUpdate
            // 
            this.txtMakeUpdate.Location = new System.Drawing.Point(79, 94);
            this.txtMakeUpdate.Name = "txtMakeUpdate";
            this.txtMakeUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtMakeUpdate.TabIndex = 37;
            // 
            // txtPlateNumberUpdate
            // 
            this.txtPlateNumberUpdate.Location = new System.Drawing.Point(79, 55);
            this.txtPlateNumberUpdate.Name = "txtPlateNumberUpdate";
            this.txtPlateNumberUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtPlateNumberUpdate.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "OwnerID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Model";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Make";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Plate Number";
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.Location = new System.Drawing.Point(104, 311);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCancelUpdate.TabIndex = 31;
            this.btnCancelUpdate.Text = "Cancel";
            this.btnCancelUpdate.UseVisualStyleBackColor = true;
            this.btnCancelUpdate.Click += new System.EventHandler(this.btnCancelUpdate_Click);
            // 
            // btnUpdateSave
            // 
            this.btnUpdateSave.Location = new System.Drawing.Point(15, 311);
            this.btnUpdateSave.Name = "btnUpdateSave";
            this.btnUpdateSave.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateSave.TabIndex = 30;
            this.btnUpdateSave.Text = "Update";
            this.btnUpdateSave.UseVisualStyleBackColor = true;
            this.btnUpdateSave.Click += new System.EventHandler(this.btnUpdateSave_Click);
            // 
            // txtLastNameUpdate
            // 
            this.txtLastNameUpdate.Location = new System.Drawing.Point(79, 259);
            this.txtLastNameUpdate.Name = "txtLastNameUpdate";
            this.txtLastNameUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtLastNameUpdate.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Last Name";
            // 
            // txtFirstNameUpdate
            // 
            this.txtFirstNameUpdate.Location = new System.Drawing.Point(79, 225);
            this.txtFirstNameUpdate.Name = "txtFirstNameUpdate";
            this.txtFirstNameUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtFirstNameUpdate.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "First Name";
            // 
            // txtVehicleIDUpdate
            // 
            this.txtVehicleIDUpdate.Location = new System.Drawing.Point(79, 16);
            this.txtVehicleIDUpdate.Name = "txtVehicleIDUpdate";
            this.txtVehicleIDUpdate.ReadOnly = true;
            this.txtVehicleIDUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtVehicleIDUpdate.TabIndex = 21;
            // 
            // lblVehicleIDUpdate
            // 
            this.lblVehicleIDUpdate.AutoSize = true;
            this.lblVehicleIDUpdate.Location = new System.Drawing.Point(9, 16);
            this.lblVehicleIDUpdate.Name = "lblVehicleIDUpdate";
            this.lblVehicleIDUpdate.Size = new System.Drawing.Size(53, 13);
            this.lblVehicleIDUpdate.TabIndex = 16;
            this.lblVehicleIDUpdate.Text = "VehicleID";
            // 
            // panelSave
            // 
            this.panelSave.Controls.Add(this.cmbOwnerAdd);
            this.panelSave.Controls.Add(this.txtModelAdd);
            this.panelSave.Controls.Add(this.txtMakeAdd);
            this.panelSave.Controls.Add(this.txtPlateNumberAdd);
            this.panelSave.Controls.Add(this.label12);
            this.panelSave.Controls.Add(this.label13);
            this.panelSave.Controls.Add(this.label14);
            this.panelSave.Controls.Add(this.label17);
            this.panelSave.Controls.Add(this.btnCancelAdd);
            this.panelSave.Controls.Add(this.btnSaveAdd);
            this.panelSave.Controls.Add(this.txtLastNameAdd);
            this.panelSave.Controls.Add(this.label15);
            this.panelSave.Controls.Add(this.txtFirstNameAdd);
            this.panelSave.Controls.Add(this.label16);
            this.panelSave.Controls.Add(this.txtVehicleIDAdd);
            this.panelSave.Controls.Add(this.lblVehicleIDAdd);
            this.panelSave.Location = new System.Drawing.Point(246, 9);
            this.panelSave.Name = "panelSave";
            this.panelSave.Size = new System.Drawing.Size(188, 346);
            this.panelSave.TabIndex = 17;
            this.panelSave.Visible = false;
            // 
            // cmbOwnerAdd
            // 
            this.cmbOwnerAdd.FormattingEnabled = true;
            this.cmbOwnerAdd.Location = new System.Drawing.Point(82, 175);
            this.cmbOwnerAdd.Name = "cmbOwnerAdd";
            this.cmbOwnerAdd.Size = new System.Drawing.Size(97, 21);
            this.cmbOwnerAdd.TabIndex = 47;
            // 
            // txtModelAdd
            // 
            this.txtModelAdd.Location = new System.Drawing.Point(82, 135);
            this.txtModelAdd.Name = "txtModelAdd";
            this.txtModelAdd.Size = new System.Drawing.Size(100, 20);
            this.txtModelAdd.TabIndex = 46;
            // 
            // txtMakeAdd
            // 
            this.txtMakeAdd.Location = new System.Drawing.Point(82, 94);
            this.txtMakeAdd.Name = "txtMakeAdd";
            this.txtMakeAdd.Size = new System.Drawing.Size(100, 20);
            this.txtMakeAdd.TabIndex = 45;
            // 
            // txtPlateNumberAdd
            // 
            this.txtPlateNumberAdd.Location = new System.Drawing.Point(82, 55);
            this.txtPlateNumberAdd.Name = "txtPlateNumberAdd";
            this.txtPlateNumberAdd.Size = new System.Drawing.Size(100, 20);
            this.txtPlateNumberAdd.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "OwnerID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "Model";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "Make";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 13);
            this.label17.TabIndex = 40;
            this.label17.Text = "Plate Number";
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.Location = new System.Drawing.Point(104, 311);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAdd.TabIndex = 31;
            this.btnCancelAdd.Text = "Cancel";
            this.btnCancelAdd.UseVisualStyleBackColor = true;
            this.btnCancelAdd.Click += new System.EventHandler(this.btnCancelAdd_Click);
            // 
            // btnSaveAdd
            // 
            this.btnSaveAdd.Location = new System.Drawing.Point(15, 311);
            this.btnSaveAdd.Name = "btnSaveAdd";
            this.btnSaveAdd.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAdd.TabIndex = 30;
            this.btnSaveAdd.Text = "Add";
            this.btnSaveAdd.UseVisualStyleBackColor = true;
            this.btnSaveAdd.Click += new System.EventHandler(this.btnSaveAdd_Click);
            // 
            // txtLastNameAdd
            // 
            this.txtLastNameAdd.Location = new System.Drawing.Point(79, 259);
            this.txtLastNameAdd.Name = "txtLastNameAdd";
            this.txtLastNameAdd.Size = new System.Drawing.Size(100, 20);
            this.txtLastNameAdd.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 267);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Last Name";
            // 
            // txtFirstNameAdd
            // 
            this.txtFirstNameAdd.Location = new System.Drawing.Point(79, 225);
            this.txtFirstNameAdd.Name = "txtFirstNameAdd";
            this.txtFirstNameAdd.Size = new System.Drawing.Size(100, 20);
            this.txtFirstNameAdd.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 225);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "First Name";
            // 
            // txtVehicleIDAdd
            // 
            this.txtVehicleIDAdd.Location = new System.Drawing.Point(79, 16);
            this.txtVehicleIDAdd.Name = "txtVehicleIDAdd";
            this.txtVehicleIDAdd.ReadOnly = true;
            this.txtVehicleIDAdd.Size = new System.Drawing.Size(37, 20);
            this.txtVehicleIDAdd.TabIndex = 21;
            // 
            // lblVehicleIDAdd
            // 
            this.lblVehicleIDAdd.AutoSize = true;
            this.lblVehicleIDAdd.Location = new System.Drawing.Point(9, 16);
            this.lblVehicleIDAdd.Name = "lblVehicleIDAdd";
            this.lblVehicleIDAdd.Size = new System.Drawing.Size(53, 13);
            this.lblVehicleIDAdd.TabIndex = 16;
            this.lblVehicleIDAdd.Text = "VehicleID";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(27, 421);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(99, 23);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(135, 421);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(99, 23);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(493, 421);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Vehicle";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(371, 421);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update Vehicle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(251, 421);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Vehicle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(493, 485);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(99, 23);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // VehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 540);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.panelSave);
            this.Controls.Add(this.panelUpdate);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOwnerID);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtPlateNumber);
            this.Controls.Add(this.txtVehicleID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblServierType);
            this.Controls.Add(this.lblVehicleID);
            this.Controls.Add(this.lstVehicle);
            this.Name = "VehicleForm";
            this.Text = "Vehicle Maintenance";
            this.panelUpdate.ResumeLayout(false);
            this.panelUpdate.PerformLayout();
            this.panelSave.ResumeLayout(false);
            this.panelSave.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstVehicle;
        private System.Windows.Forms.Label lblVehicleID;
        private System.Windows.Forms.Label lblServierType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVehicleID;
        private System.Windows.Forms.TextBox txtPlateNumber;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtOwnerID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.TextBox txtLastNameUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFirstNameUpdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVehicleIDUpdate;
        private System.Windows.Forms.Label lblVehicleIDUpdate;
        private System.Windows.Forms.Panel panelSave;
        private System.Windows.Forms.TextBox txtLastNameAdd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtFirstNameAdd;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtVehicleIDAdd;
        private System.Windows.Forms.Label lblVehicleIDAdd;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnCancelUpdate;
        private System.Windows.Forms.Button btnUpdateSave;
        private System.Windows.Forms.Button btnCancelAdd;
        private System.Windows.Forms.Button btnSaveAdd;
        private System.Windows.Forms.TextBox txtModelUpdate;
        private System.Windows.Forms.TextBox txtMakeUpdate;
        private System.Windows.Forms.TextBox txtPlateNumberUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtModelAdd;
        private System.Windows.Forms.TextBox txtMakeAdd;
        private System.Windows.Forms.TextBox txtPlateNumberAdd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbOwnerAdd;
        private System.Windows.Forms.TextBox txtOwnerIDUpdate;
    }
}