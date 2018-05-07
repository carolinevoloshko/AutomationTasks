using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supplies
{
	[Serializable]
	class Cooking : ESupplies
    {
        public string Size { get; set; }
        public Cooking(string Producer, int Power, string Year, string Size) : base(Producer, Power, Year)
        {
            this.Size = Size;
        }
    }
}

