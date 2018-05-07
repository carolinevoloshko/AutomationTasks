using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Supplies
{
	class JsonActions
	{
		public void SerializeToJson(List<ESupplies> List)
		{
			try
			{
				using (StreamWriter file = File.CreateText(@"C:\supply.json"))


					foreach (ESupplies i in List)
					{
						var result = JsonConvert.SerializeObject(i);

						string resultJson = result.ToString();
						{
							JsonSerializer serializer = new JsonSerializer();
							serializer.Serialize(file, i);
						}

						Console.WriteLine("Result of serialization to json:" + i + resultJson);
					}
			}

			catch (IOException e)
			{
				  Console.WriteLine("Result for not serialized to json" + e.Message);
			}
		}
		public void DeserializeFromJson(List<ESupplies> List, string jsonFile)
		{
			try
			{
				using (StreamReader file = File.OpenText(jsonFile))
				{

					Washingmashine newSupply = JsonConvert.DeserializeObject<Washingmashine>(File.ReadAllText(jsonFile));
					List.Add(newSupply);
					Console.WriteLine("This" + newSupply + "is added to ESuppliesList from JSON");
					foreach (ESupplies i in List)
					{
						Console.Write("The new list with new supply:" + i + ":" + i.Producer + "--" + i.Power + "--" + i.Year + "\n");
					}
				}
			}

			catch (IOException e)
			{
				Console.WriteLine("List ws not deserialized" + e.Message);
			}
			
			}
		}
	}


