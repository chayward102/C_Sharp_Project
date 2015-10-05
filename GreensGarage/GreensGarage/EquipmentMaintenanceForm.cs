using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GreensGarage
{
    public partial class EquipmentMaintenanceForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public EquipmentMaintenanceForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddEquipment.Left = 320;
            pnlAddEquipment.Top = 150;
        }
        public void BindControls()
        {
            lblEquipmentID.DataBindings.Add("Text", DM.DSGreen, "Equipment.EquipmentID");
            txtDescription.DataBindings.Add("Text", DM.DSGreen, "Equipment.Description");
            txtDescription.Enabled = false;
            lstEquipments.DataSource = DM.DSGreen;
            lstEquipments.DisplayMember = "Equipment.Description";
            lstEquipments.ValueMember = "Equipment.Description";
            currencyManager = (CurrencyManager)this.BindingContext[DM.DSGreen, "EQUIPMENT"];
        }
        private void EquipmentMaintenanceForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            lblEquipmentID.Text = null;
            DataRow newEquipmentRow = DM.dtEquipment.NewRow();
            lstEquipments.Visible = false;
            btnDeleteEquipment.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnUpdateEquipment.Enabled = false;
            btnAddEquipment.Enabled = false;
            pnlAddEquipment.Show();
            
        }

        private void btnDeleteEquipment_Click(object sender, EventArgs e)
        {
            DataRow deleteEquipmentRow = DM.dtEquipment.Rows[currencyManager.Position];
            DataRow[] ServiceTypeEquipmentRow = DM.dtServiceTypeEquipment.Select("EquipmentID = " + lblEquipmentID.Text);
            if (ServiceTypeEquipmentRow.Length == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this record", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteEquipmentRow.Delete();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("You may only delete Equipments that are not allocated", "Error");
                return;
            }
            //Update
            DM.UpdateEquipment();
        }

        private void btnUpdateEquipment_Click(object sender, EventArgs e)
        {
            DataRow updateEquipmentRow = DM.dtEquipment.Rows[currencyManager.Position];
            if (txtDescription.Text == "")
            {
                MessageBox.Show("You must type in equipment description", "Error");
            }
            else
            {
                updateEquipmentRow["Description"] = txtDescription.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateEquipment();
                MessageBox.Show("Equipment Updated successfully", "Success");
            }
            return;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddEquipment.Hide();
            lstEquipments.Enabled = true;
            lstEquipments.Visible = true;
            btnDeleteEquipment.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateEquipment.Enabled = true;
            btnAddEquipment.Enabled = true;
        }

        private void btnSaveEquipment_Click(object sender, EventArgs e)
        {
            lblEquipmentID.Text = null;
            DataRow newEquipmentRow = DM.dtEquipment.NewRow();
            if (txtAddDescription.Text == "")
            {
                MessageBox.Show("You must type an Equipment Desciption", "Error");
            }
            else
            {
                newEquipmentRow["Description"] = txtAddDescription.Text;
                DM.dtEquipment.Rows.Add(newEquipmentRow);
                MessageBox.Show("Equipment added successfully", "Success");
            }
            return;
        }
    }
}
