using System;
using System.Windows.Forms;

using GeographyLibrary;
using TemporalLibrary;

namespace TimeTravel
{
	public partial class Form1 : Form
	{
		private int _sqwimble;
		private bool _isAssumingForm;
		private bool _isDeterministic;
		private readonly CustomDate _date;
		private readonly Coordinate _coordinate;

		public Form1()
		{
			InitializeComponent();
			_sqwimble = Sqwimble.Value;
			_isAssumingForm = false;
			_isDeterministic = false;
			_date = new CustomDate();
			_coordinate = new Coordinate();
		}

		private void DateD_ValueChanged(object sender, EventArgs e)
		{
			_date.Day = (int)DateD.Value;
		}

		private void DateM_ValueChanged(object sender, EventArgs e)
		{
			_date.Month = (int)DateM.Value;
		}

		private void DateY_ValueChanged(object sender, EventArgs e)
		{
			_date.Year = (int)DateY.Value;
		}

		private void CheckAssumeForm_CheckedChanged(object sender, EventArgs e)
		{
			_isAssumingForm = CheckAssumeForm.Checked;
		}

		private void CheckDeterministic_CheckedChanged(object sender, EventArgs e)
		{
			_isDeterministic = CheckDeterministic.Checked;
		}

		private void ButtonStart_Click(object sender, EventArgs e)
		{
			label1.Text = $"Traveling to {_date.AsString} at {_coordinate.AsString}";
			label1.Visible = true;
		}

		private void Sqwimble_Scroll(object sender, EventArgs e)
		{
			_sqwimble = Sqwimble.Value;
		}

		private void LocationLat_TextChanged(object sender, EventArgs e)
		{
			if (int.TryParse(LocationLat.Text, out int x)) _coordinate.Latitude = x;
		}

		private void LocationLong_TextChanged(object sender, EventArgs e)
		{
			if (!int.TryParse(LocationLong.Text, out int x)) _coordinate.Longitude = x;
		}
	}
}
