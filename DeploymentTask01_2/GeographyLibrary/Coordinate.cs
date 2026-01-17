using System;

namespace GeographyLibrary
{
	public class Coordinate
	{
		public double Longitude { get; set; }
		public double Latitude { get; set; }

		public Coordinate()
		{
			Longitude = 0.0;
			Latitude = 0.0;
		}

		public Coordinate(double longitude, double latitude)
		{
			Longitude = longitude;
			Latitude = latitude;
		}

		public void Move(Direction direction, double distanceDegree)
		{
			// In case of diagonal move
			double delta = distanceDegree / Math.Sqrt(2);

			switch (direction)
			{
				case Direction.East:
					Longitude += distanceDegree;
					break;
				case Direction.West:
					Longitude -= distanceDegree;
					break;
				case Direction.North:
					Latitude += distanceDegree;
					break;
				case Direction.South:
					Latitude -= distanceDegree;
					break;
				case Direction.NorthEast:
					Latitude += delta;
					Longitude += delta;
					break;
				case Direction.NorthWest:
					Latitude += delta;
					Longitude -= delta;
					break;
				case Direction.SouthEast:
					Latitude -= delta;
					Longitude += delta;
					break;
				case Direction.SouthWest:
					Latitude -= delta;
					Longitude -= delta;
					break;
				default:
					break;
			}
		}

		public string AsString
		{
			get
			{
				char longi = Longitude <= 0 ? 'W' : 'E';
				char lati = Latitude <= 0 ? 'S' : 'N';
				return $"{Math.Abs(Longitude)}\u00B0{longi}, {Math.Abs(Latitude)}\u00B0{lati}";
			}
		}
	}
}
