using System;

namespace Supplies
{
	[Serializable]
	public abstract class ESupplies
	{
		public string Producer
		{ get; set; }
		public int Power
		{ get; set; }
		public string Year
		{ get; set; }

		public ESupplies(string Producer, int Power, string Year)
		{
			this.Producer = Producer;
			this.Power = Power;
			this.Year = Year;

		}


		public virtual void Display()
		{
			{
				Console.WriteLine(Producer + Power + Year);
			}
		}
		public virtual void DisplaySorted()
		{
			Console.WriteLine(Producer + Power);
		}
		public virtual void IsPlugged()
		{
			Console.WriteLine(Producer + Power + "is plugged");
		}

	}

		
	
}




	
	