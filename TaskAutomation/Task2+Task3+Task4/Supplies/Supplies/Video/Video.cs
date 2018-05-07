using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supplies
{
	[Serializable]
	public  class Video : ESupplies
    {
        public string Resolution { get; set; }
        public Video(string Producer, int Power, string Year, string Resolution) : base(Producer, Power, Year)
        {
            this.Resolution = Resolution;
        }
    }
}