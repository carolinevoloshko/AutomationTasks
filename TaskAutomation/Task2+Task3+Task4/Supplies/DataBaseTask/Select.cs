using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;


namespace DataBaseTask
{
	 class Select
	{
		public void SelectUsers(SqlConnection connection)
		{
			DbCommand cmd = new SqlCommand();
			Console.WriteLine("Command object -->" + cmd.GetType().Name);
			cmd.Connection = connection;
			cmd.CommandText = "Select top 3 * From Contacts";
			var contacts = new DataTable();
			try
			{
				using (var dr = cmd.ExecuteReader())
					contacts.Load(dr);
				foreach (DataRow row in contacts.Rows)
				{
					Console.WriteLine("-> ContactID: {0}, CompanyNme {1}, Customer name : {2}, Adress : {3}\n",
						row["ContactID"],
						row["CompanyName"],
						row["ContactName"],
						row["Address"]);
				}
			}
			catch (SqlException ex)
			{
				Console.WriteLine("Rows weren't loaded\n" + ex.Message);
			}
		}
	}

}
	

