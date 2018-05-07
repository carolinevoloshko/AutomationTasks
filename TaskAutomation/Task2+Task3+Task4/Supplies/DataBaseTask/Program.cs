using System;
using System.Text;


namespace DataBaseTask
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.GetEncoding(1251);

			while (true)
				try
				{
					{
						Console.WriteLine("Выберите действие:a - Select;b -Insert,c - Update,d- Delete, e - Call propcedure, x - выход");
						DataBaseActions dataBaseActions = new DataBaseActions();
						string str = Console.ReadLine();
						switch (str)
						{

							case "a":
								dataBaseActions.Select();
								break;
							case "b":
								dataBaseActions.Insert();
								break;
							case "c":
								dataBaseActions.Update(); 
								break;
							case "d":
								dataBaseActions.Delete();
								break;
							case "e":
								dataBaseActions.CallProcedure();
								break;
							case "x":
								Environment.Exit(0);
								break;
							default:
								Console.WriteLine("Неверный выбор. Пожалуйста,выберите a, b, c, d  or e");
								break;
						}

						if (!string.IsNullOrEmpty(str))
						{
							Console.WriteLine("Чтобы продолжить,нажмите Enter");
						}
						Console.ReadLine();
					}
				}


				catch (FormatException)
				{
					Console.WriteLine(" Неправильный ввод\n");

				}

		}
		
	}
}
