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
    public partial class ServiceTypeForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        
        public ServiceTypeForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }

        public void BindControls()
        {
            lstServiceType.DataSource = DM.DSGreen;
            lstServiceType.DisplayMember = "ServiceType.Description";
            lstServiceType.ValueMember = "ServiceType.Description";
            currencyManager = (CurrencyManager)this.BindingContext[DM.DSGreen, "ServiceType"];
            txtServiceTypeID.DataBindings.Add("Text", DM.DSGreen, "ServiceType.ServiceTypeID");
            txtServiceTypeDescription.DataBindings.Add("Text", DM.DSGreen, "ServiceType.Description");
            txtHourlyRate.DataBindings.Add("Text", DM.DSGreen, "ServiceType.HourlyRate");

        }



        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
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

        private void btnAddServiceType_Click(object sender, EventArgs e)
        {
            panelSave.Visible = true;
            panelDelete.Visible = false;
            panelUpdate.Visible = false;
            btnUpdateService.Enabled = false;
            btnDeleteService.Enabled = false;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataRow newServiceTypeRow = DM.dtServiceType.NewRow();
            {
                DataRow updateServiceTypeRow = DM.dtServiceType.Rows[currencyManager.Position];
                if (txtAddDescription.Text == "")
                {
                    MessageBox.Show("You must type in a descirption, Error");
                    return;
                }
                else if (txtAddHourlyRate.Text == "")
                {
                    MessageBox.Show("You must type in a hourly rate, Error");
                    return;
                }
                else
                {
                    newServiceTypeRow["Description"] = txtAddDescription.Text;
                    newServiceTypeRow["HourlyRate"] = Convert.ToDouble(txtAddHourlyRate.Text);
                    DM.dtServiceType.Rows.Add(newServiceTypeRow);
                    DM.UpdateServiceType();
                    MessageBox.Show("you have entered a new Service", "Saved");
                    return;

                }
            }




        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelSave.Visible = false;
            panelDelete.Visible = true;
            btnDeleteService.Enabled = true;
            btnUpdateService.Enabled = true;
            btnUpdateSave.Enabled = true;
            
        }

        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            panelDelete.Visible = false;
            panelUpdate.Visible = true;
            btnDeleteService.Enabled = false;
            btnUpdateService.Enabled = false;
        }

        private void btnUpdateSave_Click(object sender, EventArgs e)
        {
            
            
                DataRow updateServiceTypeRow = DM.dtServiceType.Rows[currencyManager.Position];
                if (txtUpdateServiceTypeDescription.Text == "")
                {
                    MessageBox.Show("You must type in a service descirption, Error");
                    return;
                }
                else if (txtUpdateHourlyRate.Text == "")
                {
                    MessageBox.Show("You must type in a hourly rate, Error");
                    return;
                }
                else
                {
                    updateServiceTypeRow["Description"] = txtUpdateServiceTypeDescription.Text;
                    updateServiceTypeRow["HourlyRate"] = txtUpdateHourlyRate.Text;
                    
                    currencyManager.EndCurrentEdit();
                    DM.UpdateServiceType();
                    MessageBox.Show("Service updated successfully", "Success");
                    
                }
                return;
            }
        

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            DataRow deleteServiceTypeRow = DM.dtServiceType.Rows[currencyManager.Position];
            DataRow[] ServiceRow = DM.dtService.Select("ServiceTypeID = " + txtServiceTypeID.Text);
            DataRow[] ServiceTypeEquipment = DM.dtServiceTypeEquipment.Select("ServiceTypeID = " + txtServiceTypeID.Text);
            if (ServiceRow.Length == 0 && ServiceTypeEquipment.Length ==0)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    
                    deleteServiceTypeRow.Delete();
                    MessageBox.Show("You have deleted a service type", "Success");
                }
            else
            {
                return;
            }
        }
        else
        {
            MessageBox.Show ("You may only delete Service Types with no services or service type equipment assigned to them", "Error");
            return;    
        }
            //update
        DM.UpdateServiceType();
        }

        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            panelUpdate.Visible = false;
            btnDeleteService.Enabled = true;
            btnUpdateService.Enabled = true;
            btnUpdateSave.Enabled = true;
            panelDelete.Visible = true;
        }

        private void btnPrevious_Click_1(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                --currencyManager.Position;
            }
        }


        }
    }


