namespace GreensGarage
{
    partial class ServiceForm
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
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.Hours = new System.Windows.Forms.Label();
            this.dpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbServiceType = new System.Windows.Forms.ComboBox();
            this.cmbVehicle = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.txtUpdateHours = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dpUpdate = new System.Windows.Forms.DateTimePicker();
            this.txtUpdateServiceTypeID = new System.Windows.Forms.TextBox();
            this.txtUpdateVehicleID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdateCancel = new System.Windows.Forms.Button();
            this.btnUpdateSave = new System.Windows.Forms.Button();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.txtServiceDescription = new System.Windows.Forms.TextBox();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.txtPlateNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            this.panelAdd.SuspendLayout();
            this.panelUpdate.SuspendLayout();
            this.panelDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvService
            // 
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.Location = new System.Drawing.Point(12, 12);
            this.dgvService.Name = "dgvService";
            this.dgvService.Size = new System.Drawing.Size(561, 352);
            this.dgvService.TabIndex = 7;
            this.dgvService.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvService_CellMouseClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(588, 392);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 19);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Service";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(714, 392);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 19);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update Service";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(830, 392);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 19);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Service";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(830, 436);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 19);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.label11);
            this.panelAdd.Controls.Add(this.label10);
            this.panelAdd.Controls.Add(this.txtHours);
            this.panelAdd.Controls.Add(this.Hours);
            this.panelAdd.Controls.Add(this.dpDate);
            this.panelAdd.Controls.Add(this.cmbServiceType);
            this.panelAdd.Controls.Add(this.cmbVehicle);
            this.panelAdd.Controls.Add(this.btnCancel);
            this.panelAdd.Controls.Add(this.btnSave);
            this.panelAdd.Location = new System.Drawing.Point(608, 12);
            this.panelAdd.Margin = new System.Windows.Forms.Padding(2);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(202, 222);
            this.panelAdd.TabIndex = 19;
            this.panelAdd.Visible = false;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(51, 143);
            this.txtHours.Margin = new System.Windows.Forms.Padding(2);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(27, 20);
            this.txtHours.TabIndex = 6;
            // 
            // Hours
            // 
            this.Hours.AutoSize = true;
            this.Hours.Location = new System.Drawing.Point(12, 145);
            this.Hours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(35, 13);
            this.Hours.TabIndex = 5;
            this.Hours.Text = "Hours";
            // 
            // dpDate
            // 
            this.dpDate.Location = new System.Drawing.Point(14, 117);
            this.dpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(151, 20);
            this.dpDate.TabIndex = 4;
            // 
            // cmbServiceType
            // 
            this.cmbServiceType.FormattingEnabled = true;
            this.cmbServiceType.Location = new System.Drawing.Point(100, 59);
            this.cmbServiceType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbServiceType.Name = "cmbServiceType";
            this.cmbServiceType.Size = new System.Drawing.Size(92, 21);
            this.cmbServiceType.TabIndex = 3;
            // 
            // cmbVehicle
            // 
            this.cmbVehicle.FormattingEnabled = true;
            this.cmbVehicle.Location = new System.Drawing.Point(100, 17);
            this.cmbVehicle.Margin = new System.Windows.Forms.Padding(2);
            this.cmbVehicle.Name = "cmbVehicle";
            this.cmbVehicle.Size = new System.Drawing.Size(92, 21);
            this.cmbVehicle.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(100, 180);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 19);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(14, 180);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 19);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save Service";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelUpdate
            // 
            this.panelUpdate.Controls.Add(this.txtUpdateHours);
            this.panelUpdate.Controls.Add(this.label9);
            this.panelUpdate.Controls.Add(this.dpUpdate);
            this.panelUpdate.Controls.Add(this.txtUpdateServiceTypeID);
            this.panelUpdate.Controls.Add(this.txtUpdateVehicleID);
            this.panelUpdate.Controls.Add(this.label8);
            this.panelUpdate.Controls.Add(this.label5);
            this.panelUpdate.Controls.Add(this.btnUpdateCancel);
            this.panelUpdate.Controls.Add(this.btnUpdateSave);
            this.panelUpdate.Location = new System.Drawing.Point(830, 12);
            this.panelUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(202, 180);
            this.panelUpdate.TabIndex = 20;
            this.panelUpdate.Visible = false;
            // 
            // txtUpdateHours
            // 
            this.txtUpdateHours.Location = new System.Drawing.Point(68, 107);
            this.txtUpdateHours.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateHours.Name = "txtUpdateHours";
            this.txtUpdateHours.Size = new System.Drawing.Size(28, 20);
            this.txtUpdateHours.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 111);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Hours";
            // 
            // dpUpdate
            // 
            this.dpUpdate.Location = new System.Drawing.Point(17, 77);
            this.dpUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.dpUpdate.Name = "dpUpdate";
            this.dpUpdate.Size = new System.Drawing.Size(151, 20);
            this.dpUpdate.TabIndex = 6;
            // 
            // txtUpdateServiceTypeID
            // 
            this.txtUpdateServiceTypeID.Location = new System.Drawing.Point(103, 41);
            this.txtUpdateServiceTypeID.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateServiceTypeID.Name = "txtUpdateServiceTypeID";
            this.txtUpdateServiceTypeID.ReadOnly = true;
            this.txtUpdateServiceTypeID.Size = new System.Drawing.Size(28, 20);
            this.txtUpdateServiceTypeID.TabIndex = 5;
            // 
            // txtUpdateVehicleID
            // 
            this.txtUpdateVehicleID.Location = new System.Drawing.Point(103, 8);
            this.txtUpdateVehicleID.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateVehicleID.Name = "txtUpdateVehicleID";
            this.txtUpdateVehicleID.ReadOnly = true;
            this.txtUpdateVehicleID.Size = new System.Drawing.Size(28, 20);
            this.txtUpdateVehicleID.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 46);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Service Type ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Vehicle ID";
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.Location = new System.Drawing.Point(120, 148);
            this.btnUpdateCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(56, 19);
            this.btnUpdateCancel.TabIndex = 1;
            this.btnUpdateCancel.Text = "Cancel";
            this.btnUpdateCancel.UseVisualStyleBackColor = true;
            this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
            // 
            // btnUpdateSave
            // 
            this.btnUpdateSave.Location = new System.Drawing.Point(12, 148);
            this.btnUpdateSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateSave.Name = "btnUpdateSave";
            this.btnUpdateSave.Size = new System.Drawing.Size(96, 19);
            this.btnUpdateSave.TabIndex = 0;
            this.btnUpdateSave.Text = "Update Service";
            this.btnUpdateSave.UseVisualStyleBackColor = true;
            this.btnUpdateSave.Click += new System.EventHandler(this.btnUpdateSave_Click);
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Location = new System.Drawing.Point(437, 370);
            this.btnChangeStatus.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(136, 19);
            this.btnChangeStatus.TabIndex = 2;
            this.btnChangeStatus.Text = "Change Status to paid";
            this.btnChangeStatus.UseVisualStyleBackColor = true;
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
            // 
            // panelDelete
            // 
            this.panelDelete.Controls.Add(this.txtHourlyRate);
            this.panelDelete.Controls.Add(this.txtServiceDescription);
            this.panelDelete.Controls.Add(this.txtOwnerName);
            this.panelDelete.Controls.Add(this.txtPlateNumber);
            this.panelDelete.Controls.Add(this.label7);
            this.panelDelete.Controls.Add(this.label6);
            this.panelDelete.Controls.Add(this.label4);
            this.panelDelete.Controls.Add(this.label3);
            this.panelDelete.Controls.Add(this.label2);
            this.panelDelete.Controls.Add(this.label1);
            this.panelDelete.Location = new System.Drawing.Point(897, 217);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(229, 214);
            this.panelDelete.TabIndex = 22;
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Location = new System.Drawing.Point(117, 168);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.ReadOnly = true;
            this.txtHourlyRate.Size = new System.Drawing.Size(100, 20);
            this.txtHourlyRate.TabIndex = 22;
            // 
            // txtServiceDescription
            // 
            this.txtServiceDescription.Location = new System.Drawing.Point(117, 142);
            this.txtServiceDescription.Name = "txtServiceDescription";
            this.txtServiceDescription.ReadOnly = true;
            this.txtServiceDescription.Size = new System.Drawing.Size(100, 20);
            this.txtServiceDescription.TabIndex = 21;
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Location = new System.Drawing.Point(117, 74);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.ReadOnly = true;
            this.txtOwnerName.Size = new System.Drawing.Size(100, 20);
            this.txtOwnerName.TabIndex = 20;
            // 
            // txtPlateNumber
            // 
            this.txtPlateNumber.Location = new System.Drawing.Point(117, 48);
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.ReadOnly = true;
            this.txtPlateNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPlateNumber.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Hourly Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Service Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Service Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Owner Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Plate Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Vehical Details";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 20);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Vehicle ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 62);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Service Type";
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 480);
            this.Controls.Add(this.panelDelete);
            this.Controls.Add(this.btnChangeStatus);
            this.Controls.Add(this.panelUpdate);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvService);
            this.Name = "ServiceForm";
            this.Text = "Service Maintenance";
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelUpdate.ResumeLayout(false);
            this.panelUpdate.PerformLayout();
            this.panelDelete.ResumeLayout(false);
            this.panelDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvService;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label Hours;
        private System.Windows.Forms.DateTimePicker dpDate;
        private System.Windows.Forms.ComboBox cmbServiceType;
        private System.Windows.Forms.ComboBox cmbVehicle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.Button btnUpdateCancel;
        private System.Windows.Forms.Button btnUpdateSave;
        private System.Windows.Forms.TextBox txtUpdateHours;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dpUpdate;
        private System.Windows.Forms.TextBox txtUpdateServiceTypeID;
        private System.Windows.Forms.TextBox txtUpdateVehicleID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnChangeStatus;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.TextBox txtServiceDescription;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.TextBox txtPlateNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}