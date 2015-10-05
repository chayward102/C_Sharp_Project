namespace GreensGarage
{
    partial class ServiceTypeForm
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
            this.lstServiceType = new System.Windows.Forms.ListBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnAddServiceType = new System.Windows.Forms.Button();
            this.btnUpdateService = new System.Windows.Forms.Button();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.btnCancelUpdate = new System.Windows.Forms.Button();
            this.btnUpdateSave = new System.Windows.Forms.Button();
            this.txtUpdateHourlyRate = new System.Windows.Forms.TextBox();
            this.txtUpdateServiceTypeDescription = new System.Windows.Forms.TextBox();
            this.txtlUpdateServiceTypeID = new System.Windows.Forms.TextBox();
            this.lblUpdateHourlyRate = new System.Windows.Forms.Label();
            this.lblUpdateServiceTypeDescription = new System.Windows.Forms.Label();
            this.lblUpdateServiceTypeID = new System.Windows.Forms.Label();
            this.panelSave = new System.Windows.Forms.Panel();
            this.txtAddHourlyRate = new System.Windows.Forms.TextBox();
            this.txtAddDescription = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblAddHourlyRate = new System.Windows.Forms.Label();
            this.lblAddDesciption = new System.Windows.Forms.Label();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.txtServiceTypeDescription = new System.Windows.Forms.TextBox();
            this.txtServiceTypeID = new System.Windows.Forms.TextBox();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblServiceTypeID = new System.Windows.Forms.Label();
            this.panelUpdate.SuspendLayout();
            this.panelSave.SuspendLayout();
            this.panelDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstServiceType
            // 
            this.lstServiceType.FormattingEnabled = true;
            this.lstServiceType.Location = new System.Drawing.Point(38, 33);
            this.lstServiceType.Name = "lstServiceType";
            this.lstServiceType.Size = new System.Drawing.Size(174, 368);
            this.lstServiceType.TabIndex = 6;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(38, 453);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(137, 453);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click_1);
            // 
            // btnAddServiceType
            // 
            this.btnAddServiceType.Location = new System.Drawing.Point(261, 453);
            this.btnAddServiceType.Name = "btnAddServiceType";
            this.btnAddServiceType.Size = new System.Drawing.Size(126, 23);
            this.btnAddServiceType.TabIndex = 2;
            this.btnAddServiceType.Text = "Add Service ";
            this.btnAddServiceType.UseVisualStyleBackColor = true;
            this.btnAddServiceType.Click += new System.EventHandler(this.btnAddServiceType_Click);
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.Location = new System.Drawing.Point(436, 453);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.Size = new System.Drawing.Size(126, 23);
            this.btnUpdateService.TabIndex = 3;
            this.btnUpdateService.Text = "Update Service";
            this.btnUpdateService.UseVisualStyleBackColor = true;
            this.btnUpdateService.Click += new System.EventHandler(this.btnUpdateService_Click);
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Location = new System.Drawing.Point(605, 453);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(126, 23);
            this.btnDeleteService.TabIndex = 4;
            this.btnDeleteService.Text = "Delete Service";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(605, 497);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(126, 23);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // panelUpdate
            // 
            this.panelUpdate.Controls.Add(this.btnCancelUpdate);
            this.panelUpdate.Controls.Add(this.btnUpdateSave);
            this.panelUpdate.Controls.Add(this.txtUpdateHourlyRate);
            this.panelUpdate.Controls.Add(this.txtUpdateServiceTypeDescription);
            this.panelUpdate.Controls.Add(this.txtlUpdateServiceTypeID);
            this.panelUpdate.Controls.Add(this.lblUpdateHourlyRate);
            this.panelUpdate.Controls.Add(this.lblUpdateServiceTypeDescription);
            this.panelUpdate.Controls.Add(this.lblUpdateServiceTypeID);
            this.panelUpdate.Location = new System.Drawing.Point(228, 36);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(246, 149);
            this.panelUpdate.TabIndex = 13;
            this.panelUpdate.Visible = false;
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.Location = new System.Drawing.Point(127, 109);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCancelUpdate.TabIndex = 15;
            this.btnCancelUpdate.Text = "Cancel";
            this.btnCancelUpdate.UseVisualStyleBackColor = true;
            this.btnCancelUpdate.Click += new System.EventHandler(this.btnCancelUpdate_Click);
            // 
            // btnUpdateSave
            // 
            this.btnUpdateSave.Location = new System.Drawing.Point(21, 109);
            this.btnUpdateSave.Name = "btnUpdateSave";
            this.btnUpdateSave.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateSave.TabIndex = 14;
            this.btnUpdateSave.Text = "Update";
            this.btnUpdateSave.UseVisualStyleBackColor = true;
            this.btnUpdateSave.Click += new System.EventHandler(this.btnUpdateSave_Click);
            // 
            // txtUpdateHourlyRate
            // 
            this.txtUpdateHourlyRate.Location = new System.Drawing.Point(127, 73);
            this.txtUpdateHourlyRate.Name = "txtUpdateHourlyRate";
            this.txtUpdateHourlyRate.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateHourlyRate.TabIndex = 13;
            // 
            // txtUpdateServiceTypeDescription
            // 
            this.txtUpdateServiceTypeDescription.Location = new System.Drawing.Point(127, 38);
            this.txtUpdateServiceTypeDescription.Name = "txtUpdateServiceTypeDescription";
            this.txtUpdateServiceTypeDescription.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateServiceTypeDescription.TabIndex = 12;
            // 
            // txtlUpdateServiceTypeID
            // 
            this.txtlUpdateServiceTypeID.Location = new System.Drawing.Point(127, 7);
            this.txtlUpdateServiceTypeID.Name = "txtlUpdateServiceTypeID";
            this.txtlUpdateServiceTypeID.ReadOnly = true;
            this.txtlUpdateServiceTypeID.Size = new System.Drawing.Size(44, 20);
            this.txtlUpdateServiceTypeID.TabIndex = 11;
            // 
            // lblUpdateHourlyRate
            // 
            this.lblUpdateHourlyRate.AutoSize = true;
            this.lblUpdateHourlyRate.Location = new System.Drawing.Point(18, 80);
            this.lblUpdateHourlyRate.Name = "lblUpdateHourlyRate";
            this.lblUpdateHourlyRate.Size = new System.Drawing.Size(63, 13);
            this.lblUpdateHourlyRate.TabIndex = 10;
            this.lblUpdateHourlyRate.Text = "Hourly Rate";
            // 
            // lblUpdateServiceTypeDescription
            // 
            this.lblUpdateServiceTypeDescription.AutoSize = true;
            this.lblUpdateServiceTypeDescription.Location = new System.Drawing.Point(18, 45);
            this.lblUpdateServiceTypeDescription.Name = "lblUpdateServiceTypeDescription";
            this.lblUpdateServiceTypeDescription.Size = new System.Drawing.Size(60, 13);
            this.lblUpdateServiceTypeDescription.TabIndex = 9;
            this.lblUpdateServiceTypeDescription.Text = "Description";
            // 
            // lblUpdateServiceTypeID
            // 
            this.lblUpdateServiceTypeID.AutoSize = true;
            this.lblUpdateServiceTypeID.Location = new System.Drawing.Point(18, 11);
            this.lblUpdateServiceTypeID.Name = "lblUpdateServiceTypeID";
            this.lblUpdateServiceTypeID.Size = new System.Drawing.Size(84, 13);
            this.lblUpdateServiceTypeID.TabIndex = 8;
            this.lblUpdateServiceTypeID.Text = "Service Type ID";
            // 
            // panelSave
            // 
            this.panelSave.Controls.Add(this.txtAddHourlyRate);
            this.panelSave.Controls.Add(this.txtAddDescription);
            this.panelSave.Controls.Add(this.btnCancel);
            this.panelSave.Controls.Add(this.btnSave);
            this.panelSave.Controls.Add(this.lblAddHourlyRate);
            this.panelSave.Controls.Add(this.lblAddDesciption);
            this.panelSave.Location = new System.Drawing.Point(228, 36);
            this.panelSave.Name = "panelSave";
            this.panelSave.Size = new System.Drawing.Size(239, 148);
            this.panelSave.TabIndex = 14;
            this.panelSave.Visible = false;
            // 
            // txtAddHourlyRate
            // 
            this.txtAddHourlyRate.Location = new System.Drawing.Point(113, 51);
            this.txtAddHourlyRate.Name = "txtAddHourlyRate";
            this.txtAddHourlyRate.Size = new System.Drawing.Size(100, 20);
            this.txtAddHourlyRate.TabIndex = 18;
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.Location = new System.Drawing.Point(113, 17);
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.Size = new System.Drawing.Size(100, 20);
            this.txtAddDescription.TabIndex = 17;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(132, 110);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(18, 110);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblAddHourlyRate
            // 
            this.lblAddHourlyRate.AutoSize = true;
            this.lblAddHourlyRate.Location = new System.Drawing.Point(15, 51);
            this.lblAddHourlyRate.Name = "lblAddHourlyRate";
            this.lblAddHourlyRate.Size = new System.Drawing.Size(63, 13);
            this.lblAddHourlyRate.TabIndex = 11;
            this.lblAddHourlyRate.Text = "Hourly Rate";
            // 
            // lblAddDesciption
            // 
            this.lblAddDesciption.AutoSize = true;
            this.lblAddDesciption.Location = new System.Drawing.Point(15, 20);
            this.lblAddDesciption.Name = "lblAddDesciption";
            this.lblAddDesciption.Size = new System.Drawing.Size(60, 13);
            this.lblAddDesciption.TabIndex = 10;
            this.lblAddDesciption.Text = "Description";
            // 
            // panelDelete
            // 
            this.panelDelete.Controls.Add(this.txtHourlyRate);
            this.panelDelete.Controls.Add(this.txtServiceTypeDescription);
            this.panelDelete.Controls.Add(this.txtServiceTypeID);
            this.panelDelete.Controls.Add(this.lblHourlyRate);
            this.panelDelete.Controls.Add(this.lblDescription);
            this.panelDelete.Controls.Add(this.lblServiceTypeID);
            this.panelDelete.Location = new System.Drawing.Point(228, 36);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(239, 148);
            this.panelDelete.TabIndex = 15;
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Location = new System.Drawing.Point(128, 86);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.ReadOnly = true;
            this.txtHourlyRate.Size = new System.Drawing.Size(100, 20);
            this.txtHourlyRate.TabIndex = 18;
            // 
            // txtServiceTypeDescription
            // 
            this.txtServiceTypeDescription.Location = new System.Drawing.Point(128, 51);
            this.txtServiceTypeDescription.Name = "txtServiceTypeDescription";
            this.txtServiceTypeDescription.ReadOnly = true;
            this.txtServiceTypeDescription.Size = new System.Drawing.Size(100, 20);
            this.txtServiceTypeDescription.TabIndex = 17;
            // 
            // txtServiceTypeID
            // 
            this.txtServiceTypeID.Location = new System.Drawing.Point(128, 17);
            this.txtServiceTypeID.Name = "txtServiceTypeID";
            this.txtServiceTypeID.ReadOnly = true;
            this.txtServiceTypeID.Size = new System.Drawing.Size(44, 20);
            this.txtServiceTypeID.TabIndex = 16;
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Location = new System.Drawing.Point(22, 89);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(63, 13);
            this.lblHourlyRate.TabIndex = 15;
            this.lblHourlyRate.Text = "Hourly Rate";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(22, 51);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Description";
            // 
            // lblServiceTypeID
            // 
            this.lblServiceTypeID.AutoSize = true;
            this.lblServiceTypeID.Location = new System.Drawing.Point(22, 20);
            this.lblServiceTypeID.Name = "lblServiceTypeID";
            this.lblServiceTypeID.Size = new System.Drawing.Size(84, 13);
            this.lblServiceTypeID.TabIndex = 13;
            this.lblServiceTypeID.Text = "Service Type ID";
            // 
            // ServiceTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 540);
            this.Controls.Add(this.panelDelete);
            this.Controls.Add(this.panelSave);
            this.Controls.Add(this.panelUpdate);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteService);
            this.Controls.Add(this.btnUpdateService);
            this.Controls.Add(this.btnAddServiceType);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lstServiceType);
            this.Name = "ServiceTypeForm";
            this.Text = "Service Type Maintenance";
            this.panelUpdate.ResumeLayout(false);
            this.panelUpdate.PerformLayout();
            this.panelSave.ResumeLayout(false);
            this.panelSave.PerformLayout();
            this.panelDelete.ResumeLayout(false);
            this.panelDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstServiceType;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnAddServiceType;
        private System.Windows.Forms.Button btnUpdateService;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.Label lblUpdateHourlyRate;
        private System.Windows.Forms.Label lblUpdateServiceTypeDescription;
        private System.Windows.Forms.Button btnCancelUpdate;
        private System.Windows.Forms.Button btnUpdateSave;
        private System.Windows.Forms.TextBox txtUpdateHourlyRate;
        private System.Windows.Forms.TextBox txtUpdateServiceTypeDescription;
        private System.Windows.Forms.Panel panelSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblAddHourlyRate;
        private System.Windows.Forms.Label lblAddDesciption;
        private System.Windows.Forms.TextBox txtlUpdateServiceTypeID;
        private System.Windows.Forms.Label lblUpdateServiceTypeID;
        private System.Windows.Forms.TextBox txtAddHourlyRate;
        private System.Windows.Forms.TextBox txtAddDescription;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.TextBox txtServiceTypeDescription;
        private System.Windows.Forms.TextBox txtServiceTypeID;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblServiceTypeID;
    }
}