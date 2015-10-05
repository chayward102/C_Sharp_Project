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
    public partial class VehicleForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmOwner;

        public VehicleForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            LoadOwners();
            


        }

        private void LoadOwners()
        {
            cmbOwnerAdd.DataSource = DM.DSGreen;
            cmbOwnerAdd.DisplayMember = "Owner.OwnerID";
            cmbOwnerAdd.ValueMember = "Owner.OwnerID";
            cmbOwnerAdd.SelectedIndex = -1;
            cmbOwnerAdd.SelectedText = "select";
        }

        public void BindControls()
        {

            lstVehicle.DataSource = DM.DSGreen;
            lstVehicle.DisplayMember = "Vehicle.PlateNumber";
            lstVehicle.ValueMember = "Vehicle.PlateNumber";

            //currencyManager 
            currencyManager = (CurrencyManager)this.BindingContext[DM.DSGreen, "Vehicle"];
            cmOwner = (CurrencyManager)this.BindingContext[DM.DSGreen, "Owner"];

            //Binding txt to read only display
            txtOwnerID.DataBindings.Add("Text", DM.DSGreen, "Vehicle.OwnerID");
            txtVehicleID.DataBindings.Add("Text", DM.DSGreen, "Vehicle.VehicleID");
            txtPlateNumber.DataBindings.Add("Text", DM.DSGreen, "Vehicle.PlateNumber");
            txtMake.DataBindings.Add("Text", DM.DSGreen, "Vehicle.Make");
            txtModel.DataBindings.Add("Text", DM.DSGreen, "Vehicle.Model");

            //Binding txt to modify panel
            txtOwnerIDUpdate.DataBindings.Add("Text", DM.DSGreen, "Vehicle.OwnerID");
            txtVehicleIDUpdate.DataBindings.Add("Text", DM.DSGreen, "Vehicle.VehicleID");
            txtPlateNumberUpdate.DataBindings.Add("Text", DM.DSGreen, "Vehicle.PlateNumber");
            txtMakeUpdate.DataBindings.Add("Text", DM.DSGreen, "Vehicle.Make");
            txtModelUpdate.DataBindings.Add("Text", DM.DSGreen, "Vehicle.Model");


        }
        //click method is the way we can link the second table to the main 
        //note we must have curreny manager  created and initialised as above
        //
        private void lstVehicles_Click(object sender, EventArgs e)
        {
            //going from vehicle to owner table
            int aOwnerID = Convert.ToInt32(txtOwnerID.Text);
            cmOwner.Position = DM.ownerView.Find(aOwnerID);
            DataRow drOwner = DM.dtOwner.Rows[cmOwner.Position];
            txtFirstName.Text = drOwner["FirstName"].ToString();
            txtLastName.Text = drOwner["LastName"].ToString();

            int aOwnerID2 = Convert.ToInt32(txtOwnerID.Text);
            cmOwner.Position = DM.ownerView.Find(aOwnerID);
            DataRow drOwner2 = DM.dtOwner.Rows[cmOwner.Position];
            txtFirstNameUpdate.Text = drOwner["FirstName"].ToString();
            txtLastNameUpdate.Text = drOwner["LastName"].ToString();
        }

        //Update button in main Frame creates panel
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            panelUpdate.Visible = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = false;
        }
        //removes update panel
        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            panelUpdate.Visible = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnAdd.Enabled = true;
        }
        //changes to DB happen here
        private void btnUpdateSave_Click(object sender, EventArgs e)
        {
            DataRow updateVehicleRow = DM.dtVehicle.NewRow();
            if (txtFirstNameUpdate.Text == "")
            {
                MessageBox.Show("You must type in a valid first name");
                return;
            }
            else if (txtLastNameUpdate.Text == "")
            {
                MessageBox.Show("You must type in a valid last name");
                return;
            }
            else if (txtMakeUpdate.Text == "")
            {
                MessageBox.Show("You must enter in a valid make");
                return;
            }
            else if (txtModelUpdate.Text == "")
            {
                MessageBox.Show("You must enter in a valid model");
                return;
            }
            else if (txtPlateNumberUpdate.Text == "")
            {
                MessageBox.Show("You must enter in a valid number plate");
                return;
            }
            else
            {

                updateVehicleRow["Make"] = txtMakeUpdate.Text;
                updateVehicleRow["Model"] = txtModelUpdate.Text;
                updateVehicleRow["PlateNumber"] = txtPlateNumberUpdate.Text;
                updateVehicleRow["OwnerID"] = txtOwnerIDUpdate.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateVehicle();
                MessageBox.Show("vehicle updated succesfully");
            }
        }

        //btn add in main is clicked
        private void btnAdd_Click(object sender, EventArgs e)
        {
            panelSave.Visible = true;
            btnDelete.Enabled = false;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;

        }
        //hides add panel
        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            panelSave.Visible = false;
            btnDelete.Enabled = true;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
        }

        //Enter New record to DB
        //two tables affected 
        //1) Vehicle
        //2) Owner
        private void btnSaveAdd_Click(object sender, EventArgs e)
        {
            DataRow newVehicleRow = DM.dtVehicle.NewRow();
            if (txtFirstNameAdd.Text == "")
            {
                MessageBox.Show("You must type in a valid first name");
                return;
            }
            else if (txtLastNameAdd.Text == "")
            {
                MessageBox.Show("You must type in a valid last name");
                return;
            }
            else if (txtMakeAdd.Text == "")
            {
                MessageBox.Show("You must enter in a valid make");
                return;
            }
            else if (txtModelAdd.Text == "")
            {
                MessageBox.Show("You must enter in a valid model");
                return;
            }
            else if (txtPlateNumberAdd.Text == "")
            {
                MessageBox.Show("You must enter in a valid number plate");
                return;
            }
            else
            {
                //builds the new row the details

                newVehicleRow["Make"] = txtMakeAdd.Text;
                newVehicleRow["Model"] = txtModelAdd.Text;
                newVehicleRow["PlateNumber"] = txtPlateNumberAdd.Text;
                newVehicleRow["OwnerID"] = cmbOwnerAdd.SelectedValue;

                //adds the new row to the correct table 
                DM.dtVehicle.Rows.Add(newVehicleRow);
                DM.UpdateVehicle();
                txtPlateNumberAdd.Clear();
                txtMakeAdd.Clear();
                txtModelAdd.Clear();
                MessageBox.Show("You have added a new vehicle");
                return;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow deleteVehicleRow = DM.dtVehicle.Rows[currencyManager.Position];
            DataRow[] ServiceRow = DM.dtService.Select("VehicleID = " + txtVehicleID.Text);

            if (ServiceRow.Length == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteVehicleRow.Delete();
                }
                else
                {
                    MessageBox.Show("You may only delete vehicles that do not have services");
                    return;
                }

            }
            else
            {
                MessageBox.Show("You may only delete Vehicles that does not have a service allocated to ", "Error");
                return;

            }
            //Update
            DM.UpdateVehicle();


        }
        /*
         * •	If the user clicks on the Delete Vehicle button and the selected vehicle has no services then the user is asked to confirm the deletion – if the user confirms the deletion then the vehicle record is deleted from the database and the message “Vehicle deleted successfully” is displayed.
•	If the user clicks on the Delete Vehicle button and the selected vehicle has services then the error message “You may only delete vehicles that do not have services” is displayed.
•	If the user clicks on the Return button then focus is returned to the Main Menu.


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
            MessageBox.Show("You may only delete Equipment that is not allocated to ", "Error");
            return;

        }
        //Update
        DM.UpdateEquipment();
         * */



        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                --currencyManager.Position;
            }
        }






    }

        
    }
