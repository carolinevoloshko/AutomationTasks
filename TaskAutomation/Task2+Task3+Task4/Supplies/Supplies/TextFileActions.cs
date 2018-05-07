using System;
using System.IO;

namespace Supplies
{
	class TextFileActions
	{
		public void WriteToFile(string fileName, int P)
		{
			using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
			{
				if (File.Exists(fileName))
				{
					try
					{

						using (StreamWriter sw = new StreamWriter(fs))
						{
							sw.WriteLine("\n Total Power is : {0} ", P);
						
							Console.WriteLine("Total Power was saved to file2.txt");
						}
					}

					catch (IOException)
					{
						Console.WriteLine(fileName + "does not exists");
					}

				}
			}
		}
		public void ReadFromFile(string fileName)
		{

			if (File.Exists(fileName))
			{
				try
				{

					using (FileStream fr = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.None))
					using (StreamReader sr = new StreamReader(fr))
					{

						var result = sr.ReadToEnd().ToString();
						Console.WriteLine("The result from the file:" + result);
						
					}
				}

				catch (IOException)
				{
					Console.WriteLine(fileName + "does not exists");
				}
			}
		}
	}

				
}

	

					
					


	

