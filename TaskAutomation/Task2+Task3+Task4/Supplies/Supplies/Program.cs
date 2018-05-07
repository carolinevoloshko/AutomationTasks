using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supplies
{
    class Program
    {
        static void Main(string[] args)
        {
			Collection myCollection = new Collection();
			
			while (true)
				try
				{
					{
						Console.WriteLine("Choose:a - Sorting;b -Find Supplies,c - Count Power, x - Exit");
						string str = Console.ReadLine();
						
						switch (str)
						{

							case "a":
								myCollection.Sorting();
								break;
							case "b":
								myCollection.FindSupplies();
								break;
							case "c":
								myCollection.CountPower();
								break;
							case "x":
								Environment.Exit(0);
								break;
							default:
								Console.WriteLine("Wrong input.Please choose a, b, c, d  or e");
								break;
						}

						if (!string.IsNullOrEmpty(str))
						{
							Console.WriteLine("To continue, click Enter");
						}
						Console.ReadLine();
					}
				}

				catch (FormatException)
				{
					Console.WriteLine("Error input,try again\n");

				}

		}




	}
        
}
    













