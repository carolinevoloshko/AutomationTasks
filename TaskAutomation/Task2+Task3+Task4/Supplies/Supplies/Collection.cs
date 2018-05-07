using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Supplies.Exceptions;

namespace Supplies
{
	[Serializable]
	class Collection

	{
		public List<ESupplies> ESuppliesList = new List<ESupplies>()
		{
		new Washingmashine("Bosch",800, "Small","2010", "200kg","Loud"),
	    new TV("Sony",2000,"2016","2000x3000","New"),
		new TV ("Samsung",3000,"2010","3000x1800","Old"),
	    new Hoover("LG",3000,"Big","2013","water","Loud"),
	    new Hoover("Sony",3000,"Big","2014","water","Loud"),
		new Stove( "PR", 300, "Big", "2010", "Ceramic" ),

		 };

		public void Sorting()
		{
			Console.WriteLine("\nBefore sort:");

			foreach (ESupplies i in ESuppliesList)

			{
				Console.WriteLine(i.Producer + "\t" + i.Power);
			}
			try
			{
				var sortedList = ESuppliesList.OrderBy(item => item.Power);

				if (sortedList.Count() == 0)

				{
					throw new SupplyEmptyListException("List is empty");

				}

				Console.WriteLine("\n---------After sorting by power-----------:");
				foreach (var i in sortedList)

				{
					Console.Write(i.Producer + "--" + i.Power + "\n");
				}

			}
			catch (SupplyEmptyListException e)
			{
				Console.WriteLine("List was not sorted\n" + e.Message);
			}
		}

		public void FindSupplies()

		{
			string S;
			string K;

			Console.WriteLine("\n------Please input the Producer by which you want to find a supplie?-----------");
			S = Console.ReadLine().ToString();
			Console.WriteLine("\n-----------Please input the Year by which you want to find a supplie?----------");
			K = Console.ReadLine().ToString();
			try
			{
				var test = ESuppliesList.FindAll(x => (x.Producer.Contains(S) && (x.Year.Contains(K))));
				if (test.Count() == 0)
				{
					throw new SupplySearchException("Supply was not found");
				}
				else
				{
					foreach (var i in test)

					{
						Console.Write("\n----------The search result is: {0},{1},{2}-----------", i.Producer, i.Year, i.Power);
					}
				}
			}

			catch (SupplySearchException e)
			{
				Console.WriteLine("Supply can't be found by such parameters\n" + e.Message);
			}
		}

		public void CountPower()

		{

			string s2 = "ok";
			int P = 0;

			Console.WriteLine("\n===Please choose what supplies do you want to plug in  :=====");
			
				foreach (ESupplies item in ESuppliesList)
				{
				try
				{
					Console.WriteLine("\n If you want to plug in {0} please type 'ok'", item.Producer);

					string s1 = Console.ReadLine().ToString();
					if (s1 == s2)
					{
						P = P + item.Power;
						Console.WriteLine("Supply was plugged in and the  power: {0}", P);
					}
					if (s1 == "" && s1 != s2)
					{
						throw new NoPluggedInSuppliesException("No supplies were plugged in");

					}
				}

				catch (NoPluggedInSuppliesException e)
				{
					Console.WriteLine("Power can't be counted,supply was not plugged in\n" + e.Message);
				}

			}
			
			Console.WriteLine("\n Total Power is : {0} ", P);

				while (true)
					try
					{

						Console.WriteLine("\nChoose action:\nWrite To text file (a) ;Show text file (b) ,Serialize to binary file (c),\n Deserialize from binary file (d), Serialize to json (e) ,Deserealise from json (f), Exit (x)");
						string str = Console.ReadLine();
						TextFileActions textFileActions = new TextFileActions();
						BinaryFileActions binaryFileActions = new BinaryFileActions();
						JsonActions jsonActions = new JsonActions();
						var list = ESuppliesList;

						switch (str)
						{

							case "a":
								textFileActions.WriteToFile("c:/file2.txt", P);
								break;
							case "b":
								textFileActions.ReadFromFile("c:/file2.txt");
								break;
							case "c":
								binaryFileActions.Serialize(list);
								break;
							case "d":
								binaryFileActions.Deserialize(list);
								break;
							case "e":
								jsonActions.SerializeToJson(list);
								break;
							case "f":
								jsonActions.DeserializeFromJson(list, "C:/Users/Karolina_Voloshko/newsupply.json");
								break;
							case "x":
								Environment.Exit(0);
								break;
							default:
								Console.WriteLine("Error input.Please choose a, b, c, d  or e");
								break;
						}
					

						if (!string.IsNullOrEmpty(str))
						{
							Console.WriteLine("To continue click Enter");
						}
						Console.ReadLine();
					}
					catch (FormatException)
					{
						Console.WriteLine("Wrong input,try again\n");

					}


			}
		}
	}




				

				

		

				

				
					

		
		
	



	
		


	














		
	
	

			

		
	





		

	



