using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Supplies
{
	class BinaryFileActions  
	{
		public void Serialize(List<ESupplies>List)
		{
		
			FileStream fs = new FileStream("file.dat", FileMode.OpenOrCreate);
			BinaryFormatter bf = new BinaryFormatter();
			try
			{
				foreach (ESupplies i in List)
				{
					bf.Serialize(fs, i);
				}

				Console.WriteLine("List of object is serialized");

			}

			catch (IOException e)
			{
				Console.WriteLine("File was not serialized" + e.Message);
			}

			finally
			{
				fs.Close();
			}

		}
		public void Deserialize(List<ESupplies>List)
		{
			
			FileStream fs = new FileStream("file.dat", FileMode.Open, FileAccess.Read, FileShare.Read);
			BinaryFormatter bf = new BinaryFormatter();
			try
			{
				foreach (ESupplies i in List)
				{
					ESupplies collection = (ESupplies)bf.Deserialize(fs);
					Console.WriteLine("The list of deserialized objects:" + collection);
				}
			}
			catch (IOException e)
			
			{
				Console.WriteLine("file was not desiarized" + e.Message);
			}

			finally
			{
				fs.Close();
			}
			

		}
	}
}
