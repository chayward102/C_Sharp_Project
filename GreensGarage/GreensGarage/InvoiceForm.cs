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

    public partial class InvoiceForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private int amountOfServicePrinted, pagesAmountExpected;
        private DataRow[] serviceForPrint;

        public InvoiceForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
        }

        private void btnDisplayReport_Click(object sender, EventArgs e)
        {
            CurrencyManager cmVehicle;
            CurrencyManager cmOwner;
            CurrencyManager cmService;
            CurrencyManager cmEquipment;
            CurrencyManager cmServiceType;

            string serviceText = "";
            double serviceTotal = 0;


            cmVehicle = (CurrencyManager)this.BindingContext[DM.DSGreen, "Vehicle"];
            cmOwner = (CurrencyManager)this.BindingContext[DM.DSGreen, "OWNER"];
            cmService = (CurrencyManager)this.BindingContext[DM.DSGreen, "SERVICE"];
            cmEquipment = (CurrencyManager)this.BindingContext[DM.DSGreen, "Equipment"];
            //create cmServiceType
            //use cmServiceType to 
            cmServiceType = (CurrencyManager)this.BindingContext[DM.DSGreen, "ServiceType"];

            txtInvoices.Text = "";

            foreach (DataRow drService in DM.dtService.Rows)
            {
                string serviceStatus = drService["Status"].ToString();
                if (serviceStatus.Equals("Pending") == true)
                {
                    Console.Write("\r\n1");

                    //gets the vehicle record matching the vehicleid from the service record 
                    //take the first record in the SERVICE table
                    //convert it to int 
                    int aVehicleID = Convert.ToInt32(drService["VehicleID"].ToString());
                    //Console.WriteLine();
                    //txtInvoices.Text += aVehicleID;



                    //take that int and find it in vehicleView(vehicle table?)
                    //save its location in variable cmVehicle.Position
                    cmVehicle.Position = DM.vehicleView.Find(aVehicleID);
                    //Console.WriteLine(cmVehicle.Position);
                    // txtInvoices.Text += "xxx"+cmVehicle.Position;
                    //drVehicle now equals the row of the position where the first Vehicle id
                    //from the service table was found

                    //service table with vechileID 1st row ----- Then vehicleID in Vehicle table-----Then ownerID 
                    DataRow drVehicle = DM.dtVehicle.Rows[cmVehicle.Position];

                    int anOwnerID = Convert.ToInt32(drVehicle["OwnerID"].ToString());
                    cmOwner.Position = DM.ownerView.Find(aVehicleID);
                    DataRow drOwner = DM.dtOwner.Rows[cmOwner.Position];

                    // go from service table to servicetype using servicetypeID 
                    //finds servicetypeid in  row of service
                    int aServiceTypeID = Convert.ToInt32(drService["ServiceTypeID"].ToString());
                    //Searches for that id in service type and assigns its positon to cmServiceType
                    cmServiceType.Position = DM.serviceTypeView.Find(aServiceTypeID);

                    DataRow drServiceType = DM.dtServiceType.Rows[cmServiceType.Position];


                    // serviceTotal += Convert.ToDouble(drServiceType["Rate"]);

                    //Find Gross
                    int Hours = Convert.ToInt32(drService["Hours"].ToString());
                    int HourlyRate = Convert.ToInt32(drServiceType["HourlyRate"].ToString());
                    int Gross = Hours * HourlyRate;

                    serviceText += "Owner ID: " + drOwner["OwnerID"] + "\r\n";
                    serviceText += "Owner Name: " + drOwner["LastName"] + ", " + drOwner["FirstName"] + "\r\n";
                    serviceText += "Address: " + drOwner["StreetAddress"] + drOwner["Suburb"] + "\r\n";
                    serviceText += "Vehicle Name: " + drVehicle["Make"] + "  " + drVehicle["Model"] + "\r\n";
                    serviceText += "Vehicle ID: " + drService["VehicleID"] + "r\n";
                    serviceText += "Service Type: " + drServiceType["Description"] + "\r\n";
                    serviceText += "Service Date: " + drService["ServiceDate"] + "\r\n";
                    serviceText += "Hourly Rate: " + drServiceType["HourlyRate"] + "\r\n";
                    serviceText += "Service Hours: " + drService["Hours"] + "\r\n";

                    

                    //all items of equipment used 

                    Console.WriteLine("WWWWWW");


                    //drEquipments  """s"""
                    DataRow[] drEquipments = drServiceType.GetChildRows(DM.dtServiceType.ChildRelations["SERVICE_TYPESERVICETYPEEQUIPMENT"]);



                    if (1 > 0)
                    //come back to this....Some time
                    {
                        Console.Write("\r\n2");
                        //If the Service has Service Type Equipment THEN
                        txtInvoices.Text += serviceText;
                        foreach (DataRow drTypeServiceTypeEquipment in drEquipments)
                        {


                            string equipmentText = "";
                            int aEquipmentID = Convert.ToInt32(drTypeServiceTypeEquipment["EquipmentID"].ToString());
                            cmEquipment.Position = DM.equipmentView.Find(aEquipmentID);
                            DataRow drEquipment = DM.dtEquipment.Rows[cmEquipment.Position];

                            equipmentText = "Equipment Used: " + drEquipment["Description"] + "\r\n"; ;
                            txtInvoices.Text += equipmentText;
                            Console.WriteLine(equipmentText);

                        }


                    }
                    //put gross due here and right justified  
                    Console.Write("\r\n3");
                    txtInvoices.Text += "\t\t\t\t\t\t\t\t\t\t\t\t\tGross Due: $" + Convert.ToString(Gross) + "\r\n";
                    txtInvoices.Text += "\r\n\r\n\r\n\r\n";
                    txtInvoices.Text += "-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
                    txtInvoices.Text += "\r\n\r\n\r\n\r\n";
                    serviceText = "";
                }
            }
        }

        private void printReport_Click(object sender, EventArgs e)
        {
            FrmPrintPreview frmPreview = new FrmPrintPreview();
            frmPreview.frmMain = this;
            frmPreview.prPreview.Zoom = 1.0;
            frmPreview.prPreview.Document = prDoc;


            amountOfServicePrinted = 0;
            string strFilter = "Status = 'Pending'";
            string strSort = "ServiceTypeID";
            //how many pages to print 
            serviceForPrint = DM.DSGreen.Tables["SERVICE"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            pagesAmountExpected = serviceForPrint.Length;
            frmPreview.ShowDialog();

        }

        //Question why do i get  gross appearing numerous times
        //how do I get more pages 
        private void prDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            //Graphics g = e1.Graphics;
            System.Drawing.Image documentImg;
            // location of the image
            Bitmap bmp = Properties.Resources.GreenGarage_logo;
            Image logoImage = bmp;
            
                      
            

            DataRow drService = serviceForPrint[amountOfServicePrinted];

            CurrencyManager cmVehicle;
            CurrencyManager cmOwner;
            CurrencyManager cmService;
            CurrencyManager cmEquipment;
            CurrencyManager cmServiceType;

            
            cmVehicle = (CurrencyManager)this.BindingContext[DM.DSGreen, "Vehicle"];
            cmOwner = (CurrencyManager)this.BindingContext[DM.DSGreen, "OWNER"];
            cmService = (CurrencyManager)this.BindingContext[DM.DSGreen, "SERVICE"];
            cmEquipment = (CurrencyManager)this.BindingContext[DM.DSGreen, "Equipment"];
            cmServiceType = (CurrencyManager)this.BindingContext[DM.DSGreen, "ServiceType"];

            Brush brush = new SolidBrush(Color.Black);
            Pen blackPen = new Pen(Color.Black, 3);

            

            // Create points that define line.
            

            //set the font and boundaries

            int linesSoFarHeading = 0;
            Font textFont = new Font("Arial", 10, FontStyle.Regular);
            Font textFontCenter = new Font("Arial", 30, FontStyle.Regular);
            Font totalSubtotal = new Font("Arial", 10, FontStyle.Bold);
            Font headingFont = new Font("Arial", 10, FontStyle.Bold);

            //margins
            int leftMargin = e.MarginBounds.Left-75;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;
            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;

            //DB connection
            int aVehicleID = Convert.ToInt32(drService["VehicleID"].ToString());
            cmVehicle.Position = DM.vehicleView.Find(aVehicleID);
            DataRow drVehicle = DM.dtVehicle.Rows[cmVehicle.Position];

            int anOwnerID = Convert.ToInt32(drVehicle["OwnerID"].ToString());
            cmOwner.Position = DM.ownerView.Find(aVehicleID);
            DataRow drOwner = DM.dtOwner.Rows[cmOwner.Position];

            int aServiceTypeID = Convert.ToInt32(drService["ServiceTypeID"].ToString());
            cmServiceType.Position = DM.serviceTypeView.Find(aServiceTypeID);
            DataRow drServiceType = DM.dtServiceType.Rows[cmServiceType.Position];
            
            //Calculation
            int Hours = Convert.ToInt32(drService["Hours"].ToString());
            int HourlyRate = Convert.ToInt32(drServiceType["HourlyRate"].ToString());
            int Gross = Hours * HourlyRate;

            //Logo
            g.DrawImage(logoImage, new Point(200, 20));
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;
            //Headers
            g.DrawString("Service Invoice GreensGarage", textFontCenter, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++; linesSoFarHeading++; linesSoFarHeading++;
            g.DrawString( "Customer Name: " + drOwner["LastName"] + "  , " + drOwner["FirstName"], textFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString("CustomerID: " + drOwner["OwnerID"], textFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString("Date Serviced: "  +  ((DateTime)drService["ServiceDate"]).ToShortDateString(), textFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString("Address: " + drOwner["StreetAddress"] + drOwner["Suburb"], textFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;
            // Create pen.
           // Point point1 = new Point(leftMargin+50, linesSoFarHeading * textFont.Height);
           // Point point2 = new Point(rightMargin +65, linesSoFarHeading * textFont.Height);
            g.DrawLine(blackPen, new Point(leftMargin + 50, linesSoFarHeading * textFont.Height), new Point(rightMargin, linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
           

            g.DrawString("_________________________________________________________________________________________", textFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                                            
            linesSoFarHeading++;
            g.DrawString("_________________________________________________________________________________________", textFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));

            g.DrawString("Service Type ", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            g.DrawString("Hourly Rate ", headingFont, brush, leftMargin + headingLeftMargin + 200, topMargin + (linesSoFarHeading * textFont.Height));
            g.DrawString("Service Hours ", headingFont, brush, leftMargin + headingLeftMargin + 400, topMargin + (linesSoFarHeading * textFont.Height));
            g.DrawString("Gross Due ", headingFont, brush, leftMargin + headingLeftMargin + 600, topMargin + (linesSoFarHeading * textFont.Height));

            linesSoFarHeading++;
            g.DrawString(""+drServiceType["Description"], textFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            g.DrawString("" + drServiceType["HourlyRate"], textFont, brush, leftMargin + headingLeftMargin + 200, topMargin + (linesSoFarHeading * textFont.Height));
            g.DrawString("" + drService["Hours"], textFont, brush, leftMargin + headingLeftMargin + 400, topMargin + (linesSoFarHeading * textFont.Height));
            g.DrawString("$" + Convert.ToString(Gross), textFont, brush, leftMargin + headingLeftMargin + 600, topMargin + (linesSoFarHeading * textFont.Height));




            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;

            g.DrawString("Vehicle Details", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString("Vehicle Name: " + drVehicle["Make"] + "  " + drVehicle["Model"], textFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString("Vehicle ID: " + drService["VehicleID"], textFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;
            g.DrawString("Service Details", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;            
            g.DrawString("Service Date: " + drService["ServiceDate"], textFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;
            g.DrawString("Equipment Details", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            
            
            
            
            DataRow[] drEquipments = drServiceType.GetChildRows(DM.dtServiceType.ChildRelations["SERVICE_TYPESERVICETYPEEQUIPMENT"]);
            
           
            {
                Console.Write("\r\n2");
                //If the Service has Service Type Equipment THEN
                
                
                foreach (DataRow drTypeServiceTypeEquipment in drEquipments)
                {

                    
                    

                    
                    int aEquipmentID = Convert.ToInt32(drTypeServiceTypeEquipment["EquipmentID"].ToString());
                    cmEquipment.Position = DM.equipmentView.Find(aEquipmentID);
                    DataRow drEquipment = DM.dtEquipment.Rows[cmEquipment.Position];

                    linesSoFarHeading++;
                    g.DrawString("Equipment Used: " + drEquipment["Description"], textFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    

                    

                }
                linesSoFarHeading++;
                
                
                amountOfServicePrinted++;

                if (!(amountOfServicePrinted == pagesAmountExpected))
                {
                    e.HasMorePages = true;
                }
                
            }

            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

    }

}