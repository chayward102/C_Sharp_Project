namespace GreensGarage
{
    partial class EquipmentForm
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
            this.lstEquipment = new System.Windows.Forms.ListBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.btnUpdateEquipment = new System.Windows.Forms.Button();
            this.btnDeleteEquipment = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblEquipmentNO = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblEquipmentID = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.panelSave = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveReturn = new System.Windows.Forms.Button();
            this.txtSaveEquipmentDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnUpdateReturn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUpdateEquipmentDesc = new System.Windows.Forms.TextBox();
            this.lblEquipmentUpdate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelDelete.SuspendLayout();
            this.panelSave.SuspendLayout();
            this.panelUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstEquipment
            // 
            this.lstEquipment.FormattingEnabled = true;
            this.lstEquipment.Location = new System.Drawing.Point(41, 37);
            this.lstEquipment.Name = "lstEquipment";
            this.lstEquipment.Size = new System.Drawing.Size(217, 329);
            this.lstEquipment.TabIndex = 6;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(171, 407);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(41, 407);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.Location = new System.Drawing.Point(307, 407);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(109, 23);
            this.btnAddEquipment.TabIndex = 2;
            this.btnAddEquipment.Text = "Add Equipment";
            this.btnAddEquipment.UseVisualStyleBackColor = true;
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click);
            // 
            // btnUpdateEquipment
            // 
            this.btnUpdateEquipment.Location = new System.Drawing.Point(458, 407);
            this.btnUpdateEquipment.Name = "btnUpdateEquipment";
            this.btnUpdateEquipment.Size = new System.Drawing.Size(103, 23);
            this.btnUpdateEquipment.TabIndex = 3;
            this.btnUpdateEquipment.Text = "Update Equipment";
            this.btnUpdateEquipment.UseVisualStyleBackColor = true;
            this.btnUpdateEquipment.Click += new System.EventHandler(this.btnUpdateEquipment_Click);
            // 
            // btnDeleteEquipment
            // 
            this.btnDeleteEquipment.Location = new System.Drawing.Point(587, 407);
            this.btnDeleteEquipment.Name = "btnDeleteEquipment";
            this.btnDeleteEquipment.Size = new System.Drawing.Size(107, 23);
            this.btnDeleteEquipment.TabIndex = 4;
            this.btnDeleteEquipment.Text = "Delete Equipment";
            this.btnDeleteEquipment.UseVisualStyleBackColor = true;
            this.btnDeleteEquipment.Click += new System.EventHandler(this.btnDeleteEquipment_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(619, 481);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblEquipmentNO
            // 
            this.lblEquipmentNO.AutoSize = true;
            this.lblEquipmentNO.Location = new System.Drawing.Point(12, 14);
            this.lblEquipmentNO.Name = "lblEquipmentNO";
            this.lblEquipmentNO.Size = new System.Drawing.Size(74, 13);
            this.lblEquipmentNO.TabIndex = 7;
            this.lblEquipmentNO.Text = "Equipment ID:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 88);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Description";
            // 
            // lblEquipmentID
            // 
            this.lblEquipmentID.AutoSize = true;
            this.lblEquipmentID.Location = new System.Drawing.Point(106, 14);
            this.lblEquipmentID.Name = "lblEquipmentID";
            this.lblEquipmentID.Size = new System.Drawing.Size(35, 13);
            this.lblEquipmentID.TabIndex = 10;
            this.lblEquipmentID.Text = "label4";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(90, 88);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 11;
            // 
            // panelDelete
            // 
            this.panelDelete.Controls.Add(this.lblEquipmentNO);
            this.panelDelete.Controls.Add(this.txtDescription);
            this.panelDelete.Controls.Add(this.lblEquipmentID);
            this.panelDelete.Controls.Add(this.lblDescription);
            this.panelDelete.Location = new System.Drawing.Point(306, 37);
            this.panelDelete.Margin = new System.Windows.Forms.Padding(2);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(208, 140);
            this.panelDelete.TabIndex = 12;
            // 
            // panelSave
            // 
            this.panelSave.Controls.Add(this.btnSave);
            this.panelSave.Controls.Add(this.btnSaveReturn);
            this.panelSave.Controls.Add(this.txtSaveEquipmentDescription);
            this.panelSave.Controls.Add(this.label3);
            this.panelSave.Location = new System.Drawing.Point(306, 37);
            this.panelSave.Margin = new System.Windows.Forms.Padding(2);
            this.panelSave.Name = "panelSave";
            this.panelSave.Size = new System.Drawing.Size(208, 197);
            this.panelSave.TabIndex = 13;
            this.panelSave.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(14, 150);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 19);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveReturn
            // 
            this.btnSaveReturn.Location = new System.Drawing.Point(133, 150);
            this.btnSaveReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveReturn.Name = "btnSaveReturn";
            this.btnSaveReturn.Size = new System.Drawing.Size(56, 19);
            this.btnSaveReturn.TabIndex = 13;
            this.btnSaveReturn.Text = "Return";
            this.btnSaveReturn.UseVisualStyleBackColor = true;
            this.btnSaveReturn.Click += new System.EventHandler(this.btnSaveReturn_Click);
            // 
            // txtSaveEquipmentDescription
            // 
            this.txtSaveEquipmentDescription.Location = new System.Drawing.Point(90, 88);
            this.txtSaveEquipmentDescription.Name = "txtSaveEquipmentDescription";
            this.txtSaveEquipmentDescription.Size = new System.Drawing.Size(100, 20);
            this.txtSaveEquipmentDescription.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Description";
            // 
            // panelUpdate
            // 
            this.panelUpdate.Controls.Add(this.btnUpdate);
            this.panelUpdate.Controls.Add(this.btnUpdateReturn);
            this.panelUpdate.Controls.Add(this.label4);
            this.panelUpdate.Controls.Add(this.txtUpdateEquipmentDesc);
            this.panelUpdate.Controls.Add(this.lblEquipmentUpdate);
            this.panelUpdate.Controls.Add(this.label6);
            this.panelUpdate.Location = new System.Drawing.Point(306, 37);
            this.panelUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(208, 197);
            this.panelUpdate.TabIndex = 14;
            this.panelUpdate.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(14, 150);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(56, 19);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnUpdateReturn
            // 
            this.btnUpdateReturn.Location = new System.Drawing.Point(133, 150);
            this.btnUpdateReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateReturn.Name = "btnUpdateReturn";
            this.btnUpdateReturn.Size = new System.Drawing.Size(56, 19);
            this.btnUpdateReturn.TabIndex = 13;
            this.btnUpdateReturn.Text = "Return";
            this.btnUpdateReturn.UseVisualStyleBackColor = true;
            this.btnUpdateReturn.Click += new System.EventHandler(this.btnUpdateReturn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Equipment ID:";
            // 
            // txtUpdateEquipmentDesc
            // 
            this.txtUpdateEquipmentDesc.Location = new System.Drawing.Point(90, 88);
            this.txtUpdateEquipmentDesc.Name = "txtUpdateEquipmentDesc";
            this.txtUpdateEquipmentDesc.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateEquipmentDesc.TabIndex = 11;
            // 
            // lblEquipmentUpdate
            // 
            this.lblEquipmentUpdate.AutoSize = true;
            this.lblEquipmentUpdate.Location = new System.Drawing.Point(106, 14);
            this.lblEquipmentUpdate.Name = "lblEquipmentUpdate";
            this.lblEquipmentUpdate.Size = new System.Drawing.Size(35, 13);
            this.lblEquipmentUpdate.TabIndex = 10;
            this.lblEquipmentUpdate.Text = "label4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Description";
            // 
            // EquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 540);
            this.Controls.Add(this.panelUpdate);
            this.Controls.Add(this.panelSave);
            this.Controls.Add(this.panelDelete);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteEquipment);
            this.Controls.Add(this.btnUpdateEquipment);
            this.Controls.Add(this.btnAddEquipment);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lstEquipment);
            this.Name = "EquipmentForm";
            this.Text = "Equipment Maintenance";
            this.Load += new System.EventHandler(this.EquipmentForm_Load);
            this.panelDelete.ResumeLayout(false);
            this.panelDelete.PerformLayout();
            this.panelSave.ResumeLayout(false);
            this.panelSave.PerformLayout();
            this.panelUpdate.ResumeLayout(false);
            this.panelUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstEquipment;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.Button btnUpdateEquipment;
        private System.Windows.Forms.Button btnDeleteEquipment;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblEquipmentNO;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblEquipmentID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.Panel panelSave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveReturn;
        private System.Windows.Forms.TextBox txtSaveEquipmentDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnUpdateReturn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUpdateEquipmentDesc;
        private System.Windows.Forms.Label lblEquipmentUpdate;
        private System.Windows.Forms.Label label6;
    }
}