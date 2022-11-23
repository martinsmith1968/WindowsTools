using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuickCalendar
{
	public partial class frmDatePicker : Form
	{
		static public DialogResult SelectDate(ref DateTime currentDate)
		{
			return SelectDate(ref currentDate, "Please select a Date...");
		}

		static public DialogResult SelectDate(ref DateTime currentDate, string message)
		{
			using (frmDatePicker frm = new frmDatePicker())
			{
				frm.lblDescription.Text = message;
				frm.dtpDateTime.Value = currentDate;
				frm.Owner = ActiveForm;
				DialogResult res = frm.ShowDialog();
				if (res == DialogResult.OK)
					currentDate = frm.dtpDateTime.Value;
				return res;
			}
		}

		private frmDatePicker()
		{
			InitializeComponent();
		}

		private void frmDatePicker_Load(object sender, EventArgs e)
		{
			// Setup Form
			lblDescription.BorderStyle = BorderStyle.None;
		}
	}
}
