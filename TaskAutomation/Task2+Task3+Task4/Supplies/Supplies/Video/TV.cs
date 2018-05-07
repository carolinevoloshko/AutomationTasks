using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supplies
{
	[Serializable]
	public class TV : Video

    {
      
        
        public TV(string Producer, int Power, string Year, string Resolution, string IsNew) : base(Producer, Power, Year, Resolution)
        {
            this.IsNew = IsNew;
        }
        public string IsNew { get; set; }
        public override void Display()
        {
            {
                Console.WriteLine(Producer + Power + Year + Resolution + IsNew);
            }
        }
    }
}