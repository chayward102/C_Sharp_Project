using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 *This form allows user to add update and delete from the owner table in the DB
 */

namespace GreensGarage
{
    public partial class OwnerForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        
        

        public OwnerForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }

        public void BindControls()
        {
            //How to get first and last name displayed....Ask
            lstOwner.DataSource = DM.DSGreen;
            lstOwner.DisplayMember =  "Owner.LastName";
            lstOwner.ValueMember = "Owner.LastName";

            currencyManager = (CurrencyManager)this.BindingContext[DM.DSGreen, "Owner"];

            txtOwnerID.DataBindings.Add("Text", DM.DSGreen, "Owner.OwnerID");
            txtLastName.DataBindings.Add("Text", DM.DSGreen, "Owner.LastName");
            txtFirstName.DataBindings.Add("Text", DM.DSGreen, "Owner.FirstName");
            txtStreetAddress.DataBindings.Add("Text", DM.DSGreen, "Owner.StreetAddress");
            txtSuburb.DataBindings.Add("Text", DM.DSGreen, "Owner.Suburb");
            txtPhone.DataBindings.Add("Text", DM.DSGreen, "Owner.PhoneNumber");

            //This wont work I need to put in in a load owners on click function similar to Vehicle Maintenance form 
            //txtUpdateOwnerID.DataBindings.Add("Text", DM.DSGreen, "Owner.OwnerID");
            txtUpdateLastName.DataBindings.Add("Text", DM.DSGreen, "Owner.LastName");
            txtUpdateFirstName.DataBindings.Add("Text", DM.DSGreen, "Owner.FirstName");
            txtUpdateStreet.DataBindings.Add("Text", DM.DSGreen, "Owner.StreetAddress");
            txtUpdateSuburb.DataBindings.Add("Text", DM.DSGreen, "Owner.Suburb");
            txtUpdatePhone.DataBindings.Add("Text", DM.DSGreen, "Owner.PhoneNumber");



        }

        //this section deals with adding Owners
        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            panelAddOwner.Visible = true;
            panelDelete.Visible = false;
            btnUpdateOwner.Enabled = false;
            btnDeleteOwner.Enabled = false;        
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelAddOwner.Visible = false;
            panelDelete.Visible = true;
            btnUpdateOwner.Enabled = true;
            btnDeleteOwner.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataRow newOwnerRow = DM.dtOwner.NewRow();

           {
                
                if (txtEditPhoneNumber.Text == "")
                {
                    MessageBox.Show("You must type in a phone number", "Error");
                    return;
                }
                else if (txtEditFirstName.Text == "")
                {
                    MessageBox.Show("You must type in a first name", "Error");
                    return;
                }
                else if (txtEditLastName.Text == "")
                {
                    MessageBox.Show("You must type in a last name", "Error");
                    return;
                }
                else if (txtEditSuburb.Text == "")
                {
                    MessageBox.Show("You must type in a suburb", "Error");
                    return;
                }
                else if (txtEditStreetAddress.Text == "")
                {
                    MessageBox.Show("You must type in a street address", "Error");
                    return;
                }
                else
                {
                    newOwnerRow["FirstName"] = txtEditFirstName.Text;
                    newOwnerRow["LastName"] = txtEditLastName.Text;
                    newOwnerRow["Suburb"] = txtEditSuburb.Text;
                    newOwnerRow["StreetAddress"] = txtEditStreetAddress.Text;
                    newOwnerRow["PhoneNumber"] = txtEditPhoneNumber.Text;
                    //8888888888888888888888888888888888888888888888888888888888888888888888888888888
                    //add condition if owner has vehicals cannot be deleted
                    DM.dtOwner.Rows.Add(newOwnerRow);
                    DM.UpdateOwner();

                    MessageBox.Show("You have added a new owner", "Saved");
                    return;
                }



            }
        }

        
        //this section deals with updating owner
        private void btnUpdateOwner_Click(object sender, EventArgs e)
        {
            panelUpdate.Visible = true;
            panelDelete.Visible = false;       
            btnAddOwner.Enabled = false;
            btnDeleteOwner.Enabled = false;
        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            panelUpdate.Visible = false;
            panelDelete.Visible = true;
            btnAddOwner.Enabled = true;
            btnDeleteOwner.Enabled = true;
        }


        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            DataRow updateOwnerRow = DM.dtOwner.Rows[currencyManager.Position];
            if (txtEditPhoneNumber.Text == "")
            { MessageBox.Show("You must type in a phone number", "Error");
                return;
            }
            else if (txtEditFirstName.Text == "")
            {
                MessageBox.Show("You must type in a first name", "Error");
                return;
            }
            else if (txtEditLastName.Text == "")
            {
                MessageBox.Show("You must type in a last name", "Error");
                return;
            }
            else if (txtEditSuburb.Text == "")
            {
                MessageBox.Show("You must type in a suburb", "Error");
                return;
            }
            else if (txtEditStreetAddress.Text == "")
            {
                MessageBox.Show("You must type in a street address", "Error");
                return;
            }
            else
            {
                updateOwnerRow["FirstName"] = txtEditFirstName.Text;
                updateOwnerRow["LastName"] = txtEditLastName.Text;
                updateOwnerRow["Suburb"] = txtEditSuburb.Text;
                updateOwnerRow["StreetAddress"] = txtEditStreetAddress.Text;
                updateOwnerRow["PhoneNumber"] = txtEditPhoneNumber.Text;
                MessageBox.Show("Owner updated successfully", "Success");
                currencyManager.EndCurrentEdit();
                DM.UpdateOwner();
                return;
            }
        }

        private void btnDeleteOwner_Click(object sender, EventArgs e)
        {
            DataRow deleteOwnerRow =  DM.dtOwner.Rows[currencyManager.Position];
            DataRow[] VehicleOwnerRow = DM.dtVehicle.Select("OwnerID = " + txtOwnerID.Text);
            if (VehicleOwnerRow.Length == 0)
            {
                if  (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteOwnerRow.Delete();
            }
            else
            {
                return;
            }
        }
        else
        {
         MessageBox.Show ("You may only delete owners with no vehicles assigned to them", "Error");
        
        return;
        }
        DM.UpdateOwner();

        }

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrevious_Click_1(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                --currencyManager.Position;
            }
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

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

    }
}
