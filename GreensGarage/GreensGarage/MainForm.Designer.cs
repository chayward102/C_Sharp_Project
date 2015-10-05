namespace GreensGarage
{
    partial class MainForm
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
            this.grpMaintenance = new System.Windows.Forms.GroupBox();
            this.btnServiceTypeEquipment = new System.Windows.Forms.Button();
            this.btnServiceType = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.btnEquipment = new System.Windows.Forms.Button();
            this.btnOwner = new System.Windows.Forms.Button();
            this.btnVehicle = new System.Windows.Forms.Button();
            this.grpReport = new System.Windows.Forms.GroupBox();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpMaintenance.SuspendLayout();
            this.grpReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMaintenance
            // 
            this.grpMaintenance.BackColor = System.Drawing.Color.Transparent;
            this.grpMaintenance.Controls.Add(this.btnServiceTypeEquipment);
            this.grpMaintenance.Controls.Add(this.btnServiceType);
            this.grpMaintenance.Controls.Add(this.btnService);
            this.grpMaintenance.Controls.Add(this.btnEquipment);
            this.grpMaintenance.Controls.Add(this.btnOwner);
            this.grpMaintenance.Controls.Add(this.btnVehicle);
            this.grpMaintenance.Location = new System.Drawing.Point(13, 94);
            this.grpMaintenance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpMaintenance.Name = "grpMaintenance";
            this.grpMaintenance.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpMaintenance.Size = new System.Drawing.Size(267, 522);
            this.grpMaintenance.TabIndex = 0;
            this.grpMaintenance.TabStop = false;
            this.grpMaintenance.Text = "Maintenance";
            // 
            // btnServiceTypeEquipment
            // 
            this.btnServiceTypeEquipment.Location = new System.Drawing.Point(28, 452);
            this.btnServiceTypeEquipment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnServiceTypeEquipment.Name = "btnServiceTypeEquipment";
            this.btnServiceTypeEquipment.Size = new System.Drawing.Size(215, 36);
            this.btnServiceTypeEquipment.TabIndex = 5;
            this.btnServiceTypeEquipment.Text = "Equipment Allocation";
            this.btnServiceTypeEquipment.UseVisualStyleBackColor = true;
            this.btnServiceTypeEquipment.Click += new System.EventHandler(this.btnServiceTypeEquipment_Click);
            // 
            // btnServiceType
            // 
            this.btnServiceType.Location = new System.Drawing.Point(28, 362);
            this.btnServiceType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnServiceType.Name = "btnServiceType";
            this.btnServiceType.Size = new System.Drawing.Size(215, 36);
            this.btnServiceType.TabIndex = 4;
            this.btnServiceType.Text = "Service Type Maintenance";
            this.btnServiceType.UseVisualStyleBackColor = true;
            this.btnServiceType.Click += new System.EventHandler(this.btnServiceType_Click);
            // 
            // btnService
            // 
            this.btnService.Location = new System.Drawing.Point(28, 276);
            this.btnService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(215, 36);
            this.btnService.TabIndex = 3;
            this.btnService.Text = "Service Maintenance";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnEquipment
            // 
            this.btnEquipment.Location = new System.Drawing.Point(28, 192);
            this.btnEquipment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEquipment.Name = "btnEquipment";
            this.btnEquipment.Size = new System.Drawing.Size(215, 36);
            this.btnEquipment.TabIndex = 2;
            this.btnEquipment.Text = "Equipment Maintenance";
            this.btnEquipment.UseVisualStyleBackColor = true;
            this.btnEquipment.Click += new System.EventHandler(this.btnEquipment_Click);
            // 
            // btnOwner
            // 
            this.btnOwner.Location = new System.Drawing.Point(28, 106);
            this.btnOwner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOwner.Name = "btnOwner";
            this.btnOwner.Size = new System.Drawing.Size(215, 36);
            this.btnOwner.TabIndex = 1;
            this.btnOwner.Text = "Owner Maintenance";
            this.btnOwner.UseVisualStyleBackColor = true;
            this.btnOwner.Click += new System.EventHandler(this.btnOwner_Click);
            // 
            // btnVehicle
            // 
            this.btnVehicle.Location = new System.Drawing.Point(28, 25);
            this.btnVehicle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.Size = new System.Drawing.Size(215, 36);
            this.btnVehicle.TabIndex = 0;
            this.btnVehicle.Text = "Vehicle Maintenance";
            this.btnVehicle.UseVisualStyleBackColor = true;
            this.btnVehicle.Click += new System.EventHandler(this.btnVehicle_Click);
            // 
            // grpReport
            // 
            this.grpReport.BackColor = System.Drawing.Color.Transparent;
            this.grpReport.Controls.Add(this.btnInvoices);
            this.grpReport.Controls.Add(this.btnExit);
            this.grpReport.Location = new System.Drawing.Point(443, 94);
            this.grpReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpReport.Name = "grpReport";
            this.grpReport.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpReport.Size = new System.Drawing.Size(267, 522);
            this.grpReport.TabIndex = 1;
            this.grpReport.TabStop = false;
            this.grpReport.Text = "Reports";
            // 
            // btnInvoices
            // 
            this.btnInvoices.Location = new System.Drawing.Point(28, 25);
            this.btnInvoices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(215, 36);
            this.btnInvoices.TabIndex = 6;
            this.btnInvoices.Text = "Invoices";
            this.btnInvoices.UseVisualStyleBackColor = true;
            this.btnInvoices.Click += new System.EventHandler(this.btnInvoices_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(28, 452);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(215, 36);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GreensGarage.Properties.Resources.GreenGarage_logo;
            this.ClientSize = new System.Drawing.Size(723, 704);
            this.Controls.Add(this.grpReport);
            this.Controls.Add(this.grpMaintenance);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpMaintenance.ResumeLayout(false);
            this.grpReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMaintenance;
        private System.Windows.Forms.Button btnServiceTypeEquipment;
        private System.Windows.Forms.Button btnServiceType;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnEquipment;
        private System.Windows.Forms.Button btnOwner;
        private System.Windows.Forms.Button btnVehicle;
        private System.Windows.Forms.GroupBox grpReport;
        private System.Windows.Forms.Button btnInvoices;
        private System.Windows.Forms.Button btnExit;
    }
}

