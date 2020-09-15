using System.Text;

namespace abax
{
	class Car : Vehicle
	{
		public string Color { get; set; }

		public Car(string regNumber, int effect, int speed, string vehicleType, string color) : base(regNumber, effect, speed, vehicleType)
		{
			Color = color;
		}

		public override void ExtraInfo(StringBuilder txt)
		{
			if (Color != null) txt.AppendLine(Color);
		}
	}
}
