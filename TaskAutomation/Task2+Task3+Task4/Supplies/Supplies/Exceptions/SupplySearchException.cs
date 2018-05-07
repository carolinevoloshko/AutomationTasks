using System;

namespace Supplies
{
	public  class SupplySearchException: Exception
	{

		public SupplySearchException() //for Collection class method - Find Supplies - if the search parameters selected by user are not matching the list's object parameters - this error should be catched 
		{
			
		}

		public SupplySearchException(string message) 
			: base(message)
		{
			
		}

		public SupplySearchException(string message, Exception inner)
			: base(message, inner)
		{
			
		}
	}
}



