using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuickCalendar
{
	public partial class frmPreferences : Form
	{
		public frmPreferences()
		{
			InitializeComponent();
		}

		private void LoadStaticData()
		{
			PopulateListBoxFromEnum(cboCalendar_FirstDayOfWeek, typeof(Day));
		}

		private void LoadSettings()
		{
			chkCalendar_ShowToday.Checked = Properties.Settings.Default.Calendar_ShowToday;
			chkCalendar_ShowTodayCircle.Checked = Properties.Settings.Default.Calendar_ShowTodayCircle;
			chkCalendar_ShowWeekNumbers.Checked = Properties.Settings.Default.Calendar_ShowWeekNumbers;
			cboCalendar_FirstDayOfWeek.SelectedItem = Properties.Settings.Default.Calendar_FirstDayOfWeek;
		}

		private bool SaveSettings()
		{
			try
			{
				Properties.Settings.Default.Calendar_ShowToday = chkCalendar_ShowToday.Checked;
				Properties.Settings.Default.Calendar_ShowTodayCircle = chkCalendar_ShowTodayCircle.Checked;
				Properties.Settings.Default.Calendar_ShowWeekNumbers = chkCalendar_ShowWeekNumbers.Checked;
				Properties.Settings.Default.Calendar_FirstDayOfWeek = (Day)cboCalendar_FirstDayOfWeek.SelectedItem;

				Properties.Settings.Default.Save();

				return true;
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex.Message, "Debug");
				return false;
			}
		}

		private void PopulateListBoxFromEnum(ComboBox cbo, Type type)
		{
			cbo.Items.Clear();
			foreach(object o in Enum.GetValues(type))
			{
				cbo.Items.Add(o);
			}
		}

		private void frmPreferences_Load(object sender, EventArgs e)
		{
			LoadStaticData();
			LoadSettings();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (SaveSettings())
				DialogResult = DialogResult.OK;
		}
	}
}
