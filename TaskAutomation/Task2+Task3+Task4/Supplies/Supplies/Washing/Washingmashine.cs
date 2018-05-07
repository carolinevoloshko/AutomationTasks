using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supplies
{
	[Serializable]
	class Washingmashine : Washing

	{
        public string loadvolume { get; set; }
        public Washingmashine(string Producer, int Power, string Size, string Year, string loadvolume, string Noice) : base(Producer, Power, Year, Noice)
        {
            this.loadvolume = loadvolume;
        }
       
    }
}