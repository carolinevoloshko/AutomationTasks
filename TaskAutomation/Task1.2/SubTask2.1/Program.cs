using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubTask2._1
{
	class Program
	{
		static void Main(string[] args)
		{
				List<string> names = new List<string>();
				names.Add("Darya");
				names.Add("Evgenyu");
				names.Add("Jaroslava");
				names.Add("Jack");

				names = names.OrderBy(s => s.Length).ToList();
			//Sort list or array by string length//
			Console.WriteLine("\nThe sorted list of words (by length):");
				foreach (var w in names)
				{
					Console.WriteLine("\n{0}", w);
				}
			Console.ReadLine();
		}	
	}
}
