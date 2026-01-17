using System;

namespace TemporalLibrary
{
	public class CustomDate
	{
		private int _day;
		private int _month;

		public int Day
		{
			get => _day;
			set
			{
				if (value < 1 || value > 31) throw new ArgumentOutOfRangeException("value");
				_day = value;
			}
		}

		public int Month
		{
			get => _month;
			set
			{
				if (value < 1 || value > 12) throw new ArgumentOutOfRangeException("value");
				_month = value;
			}
		}

		public int Year { get; set; }

		public CustomDate()
		{
			_day = 1;
			_month = 1;
			Year = 1;
		}

		public string AsString { get => new DateTime(Year, Month, Day).ToShortDateString(); }
	}
}
