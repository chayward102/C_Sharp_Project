namespace GreensGarage
{
    partial class ServiceTypeEquipmentForm
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
            this.dgvServiceType = new System.Windows.Forms.DataGridView();
            this.dgvServiceTypeEquipment = new System.Windows.Forms.DataGridView();
            this.dgvEquipmentDetails = new System.Windows.Forms.DataGridView();
            this.btnAllocateEquip = new System.Windows.Forms.Button();
            this.btnRemoveEquip = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblEquipment = new System.Windows.Forms.Label();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceTypeEquipment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipmentDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvServiceType
            // 
            this.dgvServiceType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceType.Location = new System.Drawing.Point(45, 34);
            this.dgvServiceType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvServiceType.Name = "dgvServiceType";
            this.dgvServiceType.RowTemplate.Height = 24;
            this.dgvServiceType.Size = new System.Drawing.Size(481, 261);
            this.dgvServiceType.TabIndex = 7;
            // 
            // dgvServiceTypeEquipment
            // 
            this.dgvServiceTypeEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceTypeEquipment.Location = new System.Drawing.Point(591, 329);
            this.dgvServiceTypeEquipment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvServiceTypeEquipment.Name = "dgvServiceTypeEquipment";
            this.dgvServiceTypeEquipment.RowTemplate.Height = 24;
            this.dgvServiceTypeEquipment.Size = new System.Drawing.Size(324, 322);
            this.dgvServiceTypeEquipment.TabIndex = 5;
            // 
            // dgvEquipmentDetails
            // 
            this.dgvEquipmentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipmentDetails.Location = new System.Drawing.Point(45, 329);
            this.dgvEquipmentDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEquipmentDetails.Name = "dgvEquipmentDetails";
            this.dgvEquipmentDetails.RowTemplate.Height = 24;
            this.dgvEquipmentDetails.Size = new System.Drawing.Size(348, 322);
            this.dgvEquipmentDetails.TabIndex = 6;
            // 
            // btnAllocateEquip
            // 
            this.btnAllocateEquip.Location = new System.Drawing.Point(461, 329);
            this.btnAllocateEquip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAllocateEquip.Name = "btnAllocateEquip";
            this.btnAllocateEquip.Size = new System.Drawing.Size(91, 54);
            this.btnAllocateEquip.TabIndex = 3;
            this.btnAllocateEquip.Text = "Allocate Equipment";
            this.btnAllocateEquip.UseVisualStyleBackColor = true;
            this.btnAllocateEquip.Click += new System.EventHandler(this.btnAllocateEquip_Click);
            // 
            // btnRemoveEquip
            // 
            this.btnRemoveEquip.Location = new System.Drawing.Point(461, 597);
            this.btnRemoveEquip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveEquip.Name = "btnRemoveEquip";
            this.btnRemoveEquip.Size = new System.Drawing.Size(91, 54);
            this.btnRemoveEquip.TabIndex = 2;
            this.btnRemoveEquip.Text = "Remove Equipment";
            this.btnRemoveEquip.UseVisualStyleBackColor = true;
            this.btnRemoveEquip.Click += new System.EventHandler(this.btnRemoveEquip_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(1004, 688);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 28);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(45, 688);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 28);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(293, 688);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(100, 28);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblEquipment
            // 
            this.lblEquipment.AutoSize = true;
            this.lblEquipment.Location = new System.Drawing.Point(588, 217);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Size = new System.Drawing.Size(46, 17);
            this.lblEquipment.TabIndex = 8;
            this.lblEquipment.Text = "label1";
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Location = new System.Drawing.Point(588, 278);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(46, 17);
            this.lblServiceType.TabIndex = 9;
            this.lblServiceType.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(588, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Allocate Equipment :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(588, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "To Service Type :";
            // 
            // ServiceTypeEquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 735);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblServiceType);
            this.Controls.Add(this.lblEquipment);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRemoveEquip);
            this.Controls.Add(this.btnAllocateEquip);
            this.Controls.Add(this.dgvEquipmentDetails);
            this.Controls.Add(this.dgvServiceTypeEquipment);
            this.Controls.Add(this.dgvServiceType);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ServiceTypeEquipmentForm";
            this.Text = "Allocate Equipment to Service";
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceTypeEquipment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipmentDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServiceType;
        private System.Windows.Forms.DataGridView dgvServiceTypeEquipment;
        private System.Windows.Forms.DataGridView dgvEquipmentDetails;
        private System.Windows.Forms.Button btnAllocateEquip;
        private System.Windows.Forms.Button btnRemoveEquip;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblEquipment;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}