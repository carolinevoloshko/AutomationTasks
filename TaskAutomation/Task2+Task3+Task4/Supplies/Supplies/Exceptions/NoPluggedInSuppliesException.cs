using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supplies.Exceptions
{
	class NoPluggedInSuppliesException:Exception    //for Collection class method - CountPower - if user doesn't not select some supply to plug in - this error should be catched 
	{
		public NoPluggedInSuppliesException()
		{

		}

		public NoPluggedInSuppliesException(string message)
				: base(message)
			{

		}

		public NoPluggedInSuppliesException(string message, Exception inner)
				: base(message, inner)
			{

		}
	}
}

