using System;
using System.Text;

namespace abax
{
	abstract class Vehicle
	{
		public string RegNumber { get; set; }
		public int Effect { get; set; }
		public int Speed { get; set; }
		public string VehicleType { get; set; }


		public Vehicle(string regNumber, int effect, int speed, string vehicleType)
		{
			RegNumber = regNumber;
			Effect = effect;
			Speed = speed;
			VehicleType = vehicleType;
		}

		public virtual void Print()
		{
			var txt = new StringBuilder();
			txt.AppendLine(GetType().Name + ":");
			if (RegNumber != null) txt.AppendLine(RegNumber);
			if (Effect != 0) txt.AppendLine(Effect.ToString());
			if (Speed != 0) txt.AppendLine(Speed.ToString());
			if (VehicleType != null) txt.AppendLine(VehicleType);
			ExtraInfo(txt);
			Console.WriteLine(txt.ToString());
		}

		public abstract void ExtraInfo(StringBuilder txt);
	}
}
