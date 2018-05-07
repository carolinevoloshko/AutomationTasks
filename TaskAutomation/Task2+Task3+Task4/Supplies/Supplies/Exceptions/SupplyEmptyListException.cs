using System;


namespace Supplies.Exceptions
{
	class SupplyEmptyListException: Exception //for Collection class method - Sorting - if collection is empty and the sorting could not be done- this error should be catched 
	{
	public  SupplyEmptyListException()
			{

			}

	public  SupplyEmptyListException(string message)
				: base(message)
			{

			}

	public  SupplyEmptyListException(string message, Exception inner)
				: base(message, inner)
			{

			}
	}
}