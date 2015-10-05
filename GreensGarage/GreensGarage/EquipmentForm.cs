using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 * TO Do
 * need to add panel requirement so different panels appear
 */
namespace GreensGarage
{
    public partial class EquipmentForm : Form
    {

        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        
        public EquipmentForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }

        public void BindControls() 
        {
            
            lstEquipment.DataSource =DM.DSGreen;
            lstEquipment.DisplayMember = "Equipment.Description";
            lstEquipment.ValueMember = "Equiptment.Description";
            currencyManager =(CurrencyManager)this.BindingContext[DM.DSGreen, "Equipment"];

            lblEquipmentID.DataBindings.Add("Text", DM.DSGreen, "Equipment.EquipmentID");
            txtDescription.DataBindings.Add("Text", DM.DSGreen, "Equipment.Description");
            //lblEquipmentUpdate.DataBindings.Add("Text", DM.DSGreen, "Equipment.EquipmentID");
            

            lblEquipmentUpdate.DataBindings.Add("Text", DM.DSGreen, "Equipment.EquipmentID");
            txtUpdateEquipmentDesc.DataBindings.Add("Text",DM.DSGreen,"Equipment.Description");
                //check caps if doesn't work.
        }

        

       
        //This section deals with all the Update functions
        private void btnUpdateEquipment_Click(object sender, EventArgs e)
        {
            btnDeleteEquipment.Enabled = false;
            btnAddEquipment.Enabled = false;
            panelUpdate.Visible = true;
            panelDelete.Visible = false;
        }

        private void btnUpdateReturn_Click(object sender, EventArgs e)
        {
            btnDeleteEquipment.Enabled = true;
            btnAddEquipment.Enabled = true;
            panelUpdate.Visible = false;
            panelDelete.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataRow updateEquipmentRow = DM.dtEquipment.Rows[currencyManager.Position];
            if (txtUpdateEquipmentDesc.Text == "")
            {
                MessageBox.Show("You must type in a Equipment description", "Error");
            }
            else
            {
                updateEquipmentRow["Description"] = txtUpdateEquipmentDesc.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateEquipment();
                MessageBox.Show("Equipment Updated successfully, Great work buddy :-) proud of you");
            }
        }

        //This section deals with Adding Equipment
        
        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            panelDelete.Visible = false;
            panelSave.Visible = true;
            btnDeleteEquipment.Enabled = false;
            btnUpdateEquipment.Enabled = false;
        }

        private void btnSaveReturn_Click(object sender, EventArgs e)
        {
            panelDelete.Visible = true;
            panelSave.Visible = false;
            btnDeleteEquipment.Enabled = true;
            btnUpdateEquipment.Enabled = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            //lblEquipmentUpdate.Text = null;
            DataRow newEquipmentRow = DM.dtEquipment.NewRow();
            if (txtSaveEquipmentDescription.Text == "")
            {
                MessageBox.Show("You must type in a Equipment Description", "Error");
                return;

            }
            else
            {
                newEquipmentRow["Description"] = txtSaveEquipmentDescription.Text;
                DM.dtEquipment.Rows.Add(newEquipmentRow);
                MessageBox.Show("Equipment added succesfully", "Success");
                DM.UpdateEquipment();
            }
            return;

        }
            

        private void btnDeleteEquipment_Click(object sender, EventArgs e)
        {
            DataRow deleteEquipmentRow = DM.dtEquipment.Rows[currencyManager.Position];
            DataRow[] ServiceTypeEquipmentRow = DM.dtServiceTypeEquipment.Select("EquipmentID = " + lblEquipmentID.Text);
            if (ServiceTypeEquipmentRow.Length == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
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
                MessageBox.Show("You may only delete Equipment that is not allocated to a service type ", "Error");
                return;

            }
            //Update
            DM.UpdateEquipment();
        }


        private void EquipmentForm_Load(object sender, EventArgs e)
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

        

        

        

        

        

     


        }


    }

