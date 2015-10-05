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
    public partial class MainForm : Form
    {

        private DataModule DM;
        private VehicleForm frmVehicle;
        private OwnerForm frmOwner;
        private EquipmentForm frmEquipment;
        private ServiceForm frmService;
        private ServiceTypeForm frmServiceType;
        private ServiceTypeEquipmentForm frmServiceTypeEquipment;
        private InvoiceForm frmInvoice;

        public MainForm()
        {
            InitializeComponent();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            DM = new DataModule(); //create the data module and load the dataset
        }

        private void btnEquipment_Click(object sender, EventArgs e)
        {
            if (frmEquipment == null) 
            {
                frmEquipment = new EquipmentForm(DM, this);
            }
            frmEquipment.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            if (frmVehicle == null)
            {
                frmVehicle = new VehicleForm(DM, this);
            }
            frmVehicle.ShowDialog();
        }

        private void btnOwner_Click(object sender, EventArgs e)
        {
            if (frmOwner == null)
            {
                frmOwner = new OwnerForm(DM, this);

            }
            frmOwner.ShowDialog();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            if (frmService == null)
            {
                frmService  = new ServiceForm(DM, this);

            }
            frmService.ShowDialog();
        }

        private void btnServiceType_Click(object sender, EventArgs e)
        {
            if (frmServiceType == null)
            {
                frmServiceType = new ServiceTypeForm(DM, this);

            }
            frmServiceType.ShowDialog();
        }

        private void btnServiceTypeEquipment_Click(object sender, EventArgs e)
        {
            if (frmServiceTypeEquipment == null)
            {
                frmServiceTypeEquipment = new ServiceTypeEquipmentForm(DM, this);

            }
            frmServiceTypeEquipment.ShowDialog();
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            if (frmInvoice == null)
            {
                frmInvoice = new InvoiceForm(DM, this);

            }
            frmInvoice.ShowDialog();
        }
    }
}
