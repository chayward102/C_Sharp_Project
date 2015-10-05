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
    public partial class ServiceTypeEquipmentForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmEquipment;
        private CurrencyManager cmServiceType;
        private CurrencyManager cmServiceTypeEquipment;
        private CurrencyManager cmSSTE;
        private DataTable dt = new DataTable();
        private CurrencyManager cmDt;

        public ServiceTypeEquipmentForm(DataModule dm, MainForm mnu)
        
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            cmEquipment = (CurrencyManager)this.BindingContext[DM.DSGreen, "Equipment"];
            cmServiceType = (CurrencyManager)this.BindingContext[DM.DSGreen, "ServiceType"];
            cmServiceTypeEquipment = (CurrencyManager)this.BindingContext[DM.DSGreen,"ServiceTypeEquipment"];
            cmDt = (CurrencyManager)this.BindingContext[dt];
            cmSSTE = (CurrencyManager)this.BindingContext[DM.DSGreen, "ServiceType.InvestigatorAssignment"];
            BindControls();
        }

        public void BindControls() 
        {
            dgvEquipmentDetails.DataSource = DM.DSGreen;
            dgvEquipmentDetails.DataMember = "Equipment";
            
            dgvServiceType.DataSource = DM.DSGreen;
            dgvServiceType.DataMember = "ServiceType";

            dgvServiceTypeEquipment.DataSource = DM.DSGreen;
            dgvServiceTypeEquipment.DataMember = "ServiceType.SERVICE_TYPESERVICETYPEEQUIPMENT";

           //  lblEquipmentID.DataBindings.Add("Text", DM.DSGreen, "Equipment.EquipmentID");

            lblEquipment.DataBindings.Add("Text", DM.DSGreen, "Equipment.Description");
            lblServiceType.DataBindings.Add("Text", DM.DSGreen, "ServiceType.Description");

            //dgvServiceTypeEquipment.DataMember = "ServiceTypeEquipment";
        }

        

        private void btnAllocateEquip_Click(object sender, EventArgs e)
        {
            try
            {
                string equipmentID = DM.dtEquipment.Rows[cmEquipment.Position]["EquipmentID"].ToString();
                string serviceTypeID = DM.dtServiceType.Rows[cmServiceType.Position]["ServiceTypeID"].ToString();
                int row = 0;

                for (int i = 0; i < DM.dtServiceTypeEquipment.Rows.Count; i++)
                {

                    string eID = DM.dtServiceTypeEquipment.Rows[i]["EquipmentID"].ToString();
                    string sID = DM.dtServiceTypeEquipment.Rows[i]["ServiceTypeID"].ToString();
                    // loops though each row in service type and sees if its equal to the combination specified to delete
                    if (equipmentID == eID && serviceTypeID == sID)
                    {
                        MessageBox.Show("This item of equipment has already been allocated to this service type");
                        return;
                    }
                    else
                    {
                        DataRow newServiceTypeEquipment = DM.dtServiceTypeEquipment.NewRow();

                        newServiceTypeEquipment["ServiceTypeID"] = dgvServiceType["ServiceTypeID", cmServiceType.Position].Value;
                        newServiceTypeEquipment["EquipmentID"] = dgvEquipmentDetails["EquipmentID", cmEquipment.Position].Value;

                        DM.DSGreen.Tables["ServiceTypeEquipment"].Rows.Add(newServiceTypeEquipment); //add new row
                        DM.UpdateServiceTypeEquipment(); //update table
                        MessageBox.Show("Item of equipment allocated successfully");
                        return;
                    }

                }


            }

            catch (ConstraintException)
            {
                MessageBox.Show("This equipment has already been allocated to this visit.", "Error");
            }



        }

        private void btnRemoveEquip_Click(object sender, EventArgs e)
        {
           
             //(DM.dtServiceType.Rows[cmServiceType.Position])
            
                //Selected equipmentid and servicetype to delete               
                string equipmentID = DM.dtEquipment.Rows[cmEquipment.Position]["EquipmentID"].ToString();
                string serviceTypeID = DM.dtServiceType.Rows[cmServiceType.Position]["ServiceTypeID"].ToString();
                int row = 0;
                
                for(int i = 0; i<DM.dtServiceTypeEquipment.Rows.Count; i++)
                {
                    
                    string eID = DM.dtServiceTypeEquipment.Rows[i]["EquipmentID"].ToString();
                    string sID = DM.dtServiceTypeEquipment.Rows[i]["ServiceTypeID"].ToString();
                    // loops though each row in service type and sees if its equal to the combination specified to delete
                    if (equipmentID == eID && serviceTypeID == sID) 
                    {
                        row = i;
                    }

                }
                DataRow dr = DM.DSGreen.Tables["ServiceTypeEquipment"].Rows[row];
                dr.Delete();
                DM.UpdateServiceTypeEquipment();
            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (cmServiceType.Position > 0)
            {
                --cmServiceType.Position;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (cmServiceType.Position < cmServiceType.Count - 1)
            {
                ++cmServiceType.Position;
            }
        }

        }


    }


