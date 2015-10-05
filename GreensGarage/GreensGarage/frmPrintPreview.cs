using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace GreensGarage
{
	/// <summary>
	/// Summary description for frmPrintPreview.
	/// </summary>
	public class FrmPrintPreview : System.Windows.Forms.Form
	{
		public System.Windows.Forms.PrintPreviewControl prPreview;
		public InvoiceForm frmMain;
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ToolBarButton tbClose;
		private System.Windows.Forms.ToolBarButton tbPrint;
		private System.Windows.Forms.ToolBarButton tbZoom;
		private System.Windows.Forms.ContextMenu ZoomSizes;
		private System.Windows.Forms.MenuItem pop150zoom;
		private System.Windows.Forms.MenuItem pop100zoom;
		private System.Windows.Forms.MenuItem pop75zoom;
		private System.Windows.Forms.ToolBarButton tbPageNext;
		private System.Windows.Forms.ToolBarButton tbPageBack;
		private System.Windows.Forms.Label lblPageNum;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmPrintPreview()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.prPreview = new System.Windows.Forms.PrintPreviewControl();
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.tbZoom = new System.Windows.Forms.ToolBarButton();
            this.ZoomSizes = new System.Windows.Forms.ContextMenu();
            this.pop150zoom = new System.Windows.Forms.MenuItem();
            this.pop100zoom = new System.Windows.Forms.MenuItem();
            this.pop75zoom = new System.Windows.Forms.MenuItem();
            this.tbPrint = new System.Windows.Forms.ToolBarButton();
            this.tbClose = new System.Windows.Forms.ToolBarButton();
            this.tbPageBack = new System.Windows.Forms.ToolBarButton();
            this.tbPageNext = new System.Windows.Forms.ToolBarButton();
            this.lblPageNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prPreview
            // 
            this.prPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prPreview.AutoZoom = false;
            this.prPreview.Location = new System.Drawing.Point(32, 72);
            this.prPreview.Name = "prPreview";
            this.prPreview.Size = new System.Drawing.Size(767, 384);
            this.prPreview.TabIndex = 0;
            this.prPreview.Zoom = 1D;
            this.prPreview.StartPageChanged += new System.EventHandler(this.prPreview_StartPageChanged);
            // 
            // toolBar1
            // 
            this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbZoom,
            this.tbPrint,
            this.tbClose,
            this.tbPageBack,
            this.tbPageNext});
            this.toolBar1.DropDownArrows = true;
            this.toolBar1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolBar1.Location = new System.Drawing.Point(0, 0);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new System.Drawing.Size(824, 56);
            this.toolBar1.TabIndex = 1;
            this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // tbZoom
            // 
            this.tbZoom.DropDownMenu = this.ZoomSizes;
            this.tbZoom.Name = "tbZoom";
            this.tbZoom.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
            this.tbZoom.Text = "Zoom";
            // 
            // ZoomSizes
            // 
            this.ZoomSizes.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.pop150zoom,
            this.pop100zoom,
            this.pop75zoom});
            // 
            // pop150zoom
            // 
            this.pop150zoom.Index = 0;
            this.pop150zoom.Text = "150%";
            this.pop150zoom.Click += new System.EventHandler(this.pop150zoom_Click);
            // 
            // pop100zoom
            // 
            this.pop100zoom.Index = 1;
            this.pop100zoom.Text = "100%";
            this.pop100zoom.Click += new System.EventHandler(this.pop100zoom_Click);
            // 
            // pop75zoom
            // 
            this.pop75zoom.Index = 2;
            this.pop75zoom.Text = "75%";
            this.pop75zoom.Click += new System.EventHandler(this.pop75zoom_Click);
            // 
            // tbPrint
            // 
            this.tbPrint.Name = "tbPrint";
            this.tbPrint.Text = "Print";
            // 
            // tbClose
            // 
            this.tbClose.Name = "tbClose";
            this.tbClose.Text = "Close";
            // 
            // tbPageBack
            // 
            this.tbPageBack.Name = "tbPageBack";
            this.tbPageBack.Text = "<<";
            // 
            // tbPageNext
            // 
            this.tbPageNext.Name = "tbPageNext";
            this.tbPageNext.Text = ">>";
            // 
            // lblPageNum
            // 
            this.lblPageNum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNum.Location = new System.Drawing.Point(520, 8);
            this.lblPageNum.Name = "lblPageNum";
            this.lblPageNum.Size = new System.Drawing.Size(96, 32);
            this.lblPageNum.TabIndex = 2;
            this.lblPageNum.Text = "Page:1";
            // 
            // FrmPrintPreview
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(824, 450);
            this.Controls.Add(this.prPreview);
            this.Controls.Add(this.lblPageNum);
            this.Controls.Add(this.toolBar1);
            this.Name = "FrmPrintPreview";
            this.Text = "frmPrintPreview";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion


		/// <summary> method:
		/// The ZoomSizes context menu is displayed when the Zoom
		/// button is clicked on the toolbar
		/// This code handles a click on the 150% menu option
		/// by altering the Zoom property of the preview control
		/// </summary>
		private void pop150zoom_Click(object sender, System.EventArgs e)
		{
			prPreview.Zoom = 1.5;
        }

		/// <summary> method:
		/// The ZoomSizes context menu is displayed when the Zoom
		/// button is clicked on the toolbar
		/// This code handles a click on the 100% menu option
		/// by altering the Zoom property of the preview control
		/// </summary>
		private void pop100zoom_Click(object sender, System.EventArgs e)
		{
			prPreview.Zoom = 1.0;
		}

		/// <summary> method: pop75zoom_Click
		/// The ZoomSizes context menu is displayed when the Zoom
		/// button is clicked on the toolbar
		/// This code handles a click on the 75% menu option
		/// by altering the Zoom property of the preview control
		/// </summary>
		private void pop75zoom_Click(object sender, System.EventArgs e)
		{
			prPreview.Zoom = 0.75;
		}

		/// <summary> method: toolBar1_ButtonClick
		/// handles clicks on toolbar buttons except the Zoom button
		/// uses the e.Button value to decide which 
		/// button was clicked
		/// </summary>
		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			if (e.Button == tbClose)
			{
				this.Close();
			}
			else if (e.Button == tbPrint)
			{
				prPreview.Document.Print();
			}
			else if (e.Button == tbPageNext)
			{
				prPreview.StartPage++;
			}
			else if (e.Button == tbPageBack)
			{
				prPreview.StartPage--;
			}
		}

		/// <summary> method: prPreview_StartPageChanged
		/// Change the page number displayed if the user
		/// shifts to another page
		/// </summary>
		private void prPreview_StartPageChanged(object sender, System.EventArgs e)
		{
			lblPageNum.Text = "Page:" + (prPreview.StartPage +1).ToString();
		}
	}
}
