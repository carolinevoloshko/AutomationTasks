using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supplies
{
	[Serializable]
	class Washing : ESupplies
    {
        public string Noice { get; set; }
        public Washing(string Producer, int Power, string Year, string Noice) : base(Producer, Power, Year)
        {
            this.Noice = Noice;
        }
        public override void Display()
        {
            {
                Console.WriteLine(Producer + Power + Year + Year + Noice);
            }
        }

    }
}