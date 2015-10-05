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
    public partial class ServiceForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmVehicle;
        private CurrencyManager cmServiceType;
        private CurrencyManager cmOwner;
        
    
        public ServiceForm(DataModule dm,MainForm mnu)
        {
            
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            LoadVehicles();
            LoadServiceType();
            panelAdd.Left = 608;
            panelAdd.Top = 12;
            panelDelete.Left = 608;
            panelDelete.Top = 12; 
            panelUpdate.Left = 608;
            panelUpdate.Top = 12;
                



        }

        private void LoadVehicles()
        {

            cmbVehicle.DataSource = DM.DSGreen;
            cmbVehicle.DisplayMember = "Vehicle.FirstName";
            //value member is what is on our end
            cmbVehicle.ValueMember = "Vehicle.VehicleID";
            cmbVehicle.SelectedIndex = -1;
            cmbVehicle.Text = "Please select VehicleID";

        }

        private void LoadServiceType()
        {
            cmbServiceType.DataSource = DM.DSGreen;
            cmbServiceType.DisplayMember = "ServiceType.Description";
            cmbServiceType.ValueMember = "ServiceType.ServiceTypeID";
            cmbServiceType.SelectedIndex = -1;
            cmbServiceType.Text = "Please select service";
        }

        
        
        public void BindControls() 
        {
            //binds dgv to SERVICE table
            dgvService.DataSource = DM.DSGreen;
            dgvService.DataMember = "Service";
            //currency manager
            
            cmVehicle = (CurrencyManager)this.BindingContext[DM.DSGreen, "VEHICLE"];
            cmOwner = (CurrencyManager)this.BindingContext[DM.DSGreen, "OWNER"];
            //cmService = (CurrencyManager)this.BindingContext[DM.DSGreen, "SERVICE"];
           // cmEquipment = (CurrencyManager)this.BindingContext[DM.DSGreen, "Equipment"];
            cmServiceType = (CurrencyManager)this.BindingContext[DM.DSGreen, "SERVICETYPE"];
            currencyManager = (CurrencyManager)this.BindingContext[DM.DSGreen, "SERVICE"];

        }



        private void dgvService_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //this will display the First id in the grid view
            int rowindex = dgvService.CurrentCell.RowIndex;
            int columnindex= dgvService.CurrentCell.ColumnIndex;

            string a = dgvService.Rows[rowindex].Cells[0].Value.ToString();
            string b = dgvService.Rows[rowindex].Cells[1].Value.ToString();

            //vairables which I will search for in the DB
            // each peice of data i need to fetch has its own method 
            int vehicleID = Int32.Parse(a);
            int serviceTypeID = Int32.Parse(b);
            //Owner details
            txtPlateNumber.Text = findPlateNumber(vehicleID);
            txtOwnerName.Text = findOwnerName(vehicleID);
            //Service details
            txtServiceDescription.Text = findServiceDescription(serviceTypeID);
            txtHourlyRate.Text = findHourlyRate(serviceTypeID);
        }

        //Finds ownerName in OWNER table 
        //input is vehicleid from SERVICE table
        //Searches VEHICLE table for ownerID that matches the one selected in VEHICLE table
        //finds ownerID in Vehicle table that matches VehicleID
        //finds first and last name 
        private string findOwnerName(int ID)
        {
            //going from service table to vehicle table
            cmVehicle.Position = DM.serviceTypeView.Find(ID);
            DataRow drVehicle = DM.dtVehicle.Rows[cmVehicle.Position];
            string strOwnerID = drVehicle["OwnerID"].ToString();
            int vehicleID = Int32.Parse(strOwnerID);

            //going from vehicle table to owner table
            cmOwner.Position = DM.vehicleView.Find(vehicleID);
            DataRow drOwner = DM.dtOwner.Rows[cmOwner.Position];
            string firstName = drOwner["firstName"].ToString();
            string lastName = drOwner["lastName"].ToString();
            return firstName + " " + lastName;
        }

        
        
        private string findServiceDescription(int ID)
        {
            cmServiceType.Position = DM.serviceTypeView.Find(ID);
            DataRow drServiceType = DM.dtServiceType.Rows[cmServiceType.Position];
            return drServiceType["Description"].ToString();
        }

        //Finds HourlyRate in SERVICETYPE table
        private string findHourlyRate(int ID)
        {
            cmServiceType.Position = DM.serviceTypeView.Find(ID);
            DataRow drServiceType = DM.dtServiceType.Rows[cmServiceType.Position];
            return drServiceType["HourlyRate"].ToString();
        }
        //finds the plate number int SERVICETYPE table
        private string findPlateNumber(int ID) {

            //going from service table to vehicle table
            cmVehicle.Position = DM.vehicleView.Find(ID);
            DataRow drVehicle = DM.dtVehicle.Rows[cmVehicle.Position];
            return drVehicle["PlateNumber"].ToString();
            //ERROR!! after using this method dgv jumps arround when clicked does not stay where it should
            //Fixed was using "SERVICE" table in currency manager rather than "SERVICETYPE"
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = true;
            panelDelete.Visible = false;
            panelUpdate.Visible = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            panelDelete.Visible = true;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (cmbServiceType.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select a service type", "Error");
                return;
            }
            else if (cmbVehicle.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select a vehicle", "Error");
                return;
            }
            else if (txtHours.Text == "")
            {
                MessageBox.Show("Please Select a service type", "Error");
            }
            else
            {
                //need to add condition 
                DataRow newServiceRow = DM.dtService.NewRow();
                //validation
                newServiceRow["VehicleID"] = cmbVehicle.SelectedValue;
                newServiceRow["ServiceTypeID"] = 1;
                newServiceRow["Hours"] = txtHours.Text;
                newServiceRow["ServiceDate"] = dpDate.Value.Date;
                newServiceRow["Status"] = "Pending";
                DM.dtService.Rows.Add(newServiceRow);
                MessageBox.Show("Service added successfully", "Success");
                DM.UpdateService();

                //reset values
                txtHours.Clear();
                cmbServiceType.SelectedIndex = -1;
                cmbServiceType.SelectedText = "Please enter a serviceID";
                cmbVehicle.SelectedIndex = -1;
                cmbVehicle.SelectedText = "Please select VehicleID";
            }
            


        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //selected service has a status of pending then
            //this will display the First id in the grid view
            int rowindex = dgvService.CurrentCell.RowIndex;
            int columnindex= dgvService.CurrentCell.ColumnIndex;

            string a = dgvService.Rows[rowindex].Cells[4].Value.ToString();
            if (a == "Pending" || a == "pending")
            {
                MessageBox.Show("Error Cannot update Customer is still pending","Error");
                return;
            }
            else
            {
                //Need to disable dgv from being selected once into
                panelUpdate.Visible = true;
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                loadVehicleIDForUpdate();
                LoadServiceTypeIDForUpdate();
                dgvService.Enabled = false;
                panelDelete.Visible = false;
               
            }

        }

        private void LoadServiceTypeIDForUpdate()
        {
            int rowindex = dgvService.CurrentCell.RowIndex;
            int columnindex = dgvService.CurrentCell.ColumnIndex;
            string a = dgvService.Rows[rowindex].Cells[1].Value.ToString();
            txtUpdateServiceTypeID.Text = a;
        }

        private void loadVehicleIDForUpdate()
        {
            int rowindex = dgvService.CurrentCell.RowIndex;
            int columnindex = dgvService.CurrentCell.ColumnIndex;
            string a = dgvService.Rows[rowindex].Cells[0].Value.ToString();
            txtUpdateVehicleID.Text = a;
        }

        private void btnUpdateSave_Click(object sender, EventArgs e)
        {
            //This is saying the current row to be updated is the one selected by the currencyManagers position right now in service row.
            if (txtUpdateHours.Text == "")
            {
                MessageBox.Show("Must enter a valid number for hours");
                return;
            }
            else
            {
                DataRow updateServiceRow = DM.dtService.Rows[currencyManager.Position];

                updateServiceRow["Hours"] = txtUpdateHours.Text;
                updateServiceRow["ServiceDate"] = dpDate.Value.Date;

                DM.UpdateService();
                MessageBox.Show("Service Updated Successfully", "Success");
                currencyManager.EndCurrentEdit();

                txtUpdateHours.Clear();
                panelUpdate.Visible = false;
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                dgvService.Enabled = true;
            }

        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            panelUpdate.Visible = false;
            btnAdd.Enabled = true ;
            btnDelete.Enabled = true;
            dgvService.Enabled = true;
            panelDelete.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DataRow deleteServiceRow = DM.dtService.Rows[currencyManager.Position];
            


            int rowindex = dgvService.CurrentCell.RowIndex;
            int columnindex= dgvService.CurrentCell.ColumnIndex;

            string a = dgvService.Rows[rowindex].Cells[4].Value.ToString();
            if (a == "Pending" || a == "pending")
            {
                MessageBox.Show("You may only delete paid services", "Error");
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                deleteServiceRow.Delete();
                MessageBox.Show("Record deleted successfully", "Success");
            }
            else
            {
                return;
            }

            

            
            

            //You may only delete paid services
            //Service deleted successfully
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            DataRow changeStatusServiceRow = DM.dtService.Rows[currencyManager.Position];

            int rowindex = dgvService.CurrentCell.RowIndex;
            int columnindex= dgvService.CurrentCell.ColumnIndex;

            string a = dgvService.Rows[rowindex].Cells[4].Value.ToString();
            if (a == "Pending" || a == "pending")
            {
                if (MessageBox.Show("Are you sure you want to change status to paid?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    changeStatusServiceRow["Status"] = "Paid";
                    DM.UpdateService();
                    MessageBox.Show("Customer paid", "Success");

                }
            }
            else
            {
                MessageBox.Show("The Service is already paid");
                return;
            }

                
            
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
        

       
       
    }
}
