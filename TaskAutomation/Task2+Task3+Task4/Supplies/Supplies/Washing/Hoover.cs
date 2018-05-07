using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supplies
{    [Serializable]
    class Hoover : Washing
    {
        public string typeoffilter { get; set; }
        public Hoover(string Producer, int Power, string Size, string Year,string typeoffilter, string Noice) : base(Producer, Power, Year, Noice)
        {
            this.typeoffilter = typeoffilter;
        }
    }
}