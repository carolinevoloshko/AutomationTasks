using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supplies
{[Serializable]
    class Stove : Cooking
    {
        public string Area;
        public Stove(string Producer, int Power, string Size, string Year, string Area) : base(Producer, Power, Year, Size)
        {
            this.Area = Area;
        }

        
    }
}