using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace QuickCalendar
{
	public partial class AboutBox : Form
	{
		public AboutBox()
		{
			InitializeComponent();
		}

		private void PopulateApplicationDetails()
		{
			Assembly asm = Assembly.GetEntryAssembly();
			AssemblyName asmName = asm.GetName();

			ListViewItem itm = null;
			ColumnHeader hdr = null;

			lvwDetails.Columns.Clear();
			hdr = lvwDetails.Columns.Add("Assembly Name");
			hdr.Width = 150;
			hdr = lvwDetails.Columns.Add("Version");
			hdr.Width = 60;
			hdr = lvwDetails.Columns.Add("Path");
			hdr.Width = 150;

			// Icon
			if (Owner != null)
				picApplicationIcon.Image = Owner.Icon.ToBitmap();

			// Populate Details
			lblAppTitle.Text = asmName.Name;
			lblAppVersion.Text = string.Format("v{0}.{1}", asmName.Version.Major, asmName.Version.Minor);

			// Iterate Attributes
			foreach (Attribute att in asm.GetCustomAttributes(true))
			{
				if (att is AssemblyProductAttribute)
				{
					lblAppTitle.Text = (att as AssemblyProductAttribute).Product;
				}
				else if (att is AssemblyCopyrightAttribute)
				{
					lblCopyright.Text = (att as AssemblyCopyrightAttribute).Copyright;
				}
				else if (att is AssemblyDescriptionAttribute)
				{
					lblDescription.Text = (att as AssemblyDescriptionAttribute).Description;
				}
                else if (att is AssemblyTitleAttribute)
                {
                    Text = (att as AssemblyTitleAttribute).Title;
                }
			}

			lvwDetails.Items.Clear();
			/*
			foreach (AssemblyName subAsmName in asm.GetReferencedAssemblies())
			{
				itm = lvwDetails.Items.Add(subAsmName.Name);
				itm.SubItems.Add(subAsmName.Version.ToString());
				itm.SubItems.Add(subAsmName.CodeBase);
			}
			 * */
			foreach (Assembly a in AppDomain.CurrentDomain.GetAssemblies())
			{
				itm = lvwDetails.Items.Add(a.GetName().Name);
				itm.SubItems.Add(a.GetName().Version.ToString());
				itm.SubItems.Add(System.IO.Path.GetDirectoryName(a.Location));
			}
		}

		private void SizeFormToContent()
		{
			Height = (Height - ClientSize.Height)
					+ pnlButtonBar.Height
					+ (lblDescription.Top + lblDescription.Height)
					+ lblAppTitle.Top
					+ (lvwDetails.Visible ? lvwDetails.Height : 0)
					;
		}

		private void AboutBox_Load(object sender, EventArgs e)
		{
			// Center Button
			btnClose.Left = (btnClose.Parent.Width - btnClose.Width) / 2;
			btnClose.Top = (btnClose.Parent.Height - btnClose.Height) /2;

			// Hide Label Borders
			foreach (Control ctl in Controls)
			{
				Label lbl = ctl as Label;
				if (lbl != null)
					lbl.BorderStyle = BorderStyle.None;
			}

			SizeFormToContent();

			// Populate Form
			PopulateApplicationDetails();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void picApplicationIcon_DoubleClick(object sender, EventArgs e)
		{
			lvwDetails.Visible = !lvwDetails.Visible;
			SizeFormToContent();
		}
	}
}
