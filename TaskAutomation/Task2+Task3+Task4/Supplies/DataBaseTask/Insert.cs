using System;
using System.Data.SqlClient;

namespace DataBaseTask
{
	class Insert
	{
		public void InsertUser(SqlConnection connection)
		{
			try
			{
				using (SqlCommand cmd =
				new SqlCommand("INSERT INTO Customers (CustomerID, CompanyName, ContactName, Address, Region) VALUES (@CustomerID, @CompanyName, @ContactName, @Address, @Region)", connection))

				{
					cmd.Parameters.AddWithValue("@CustomerID", "AAAAP");
					cmd.Parameters.AddWithValue("@CompanyName", "EPAM");
					cmd.Parameters.AddWithValue("@ContactName", "Karolina Voloshko");
					cmd.Parameters.AddWithValue("@Address", "Sirenev Str. 1");
					cmd.Parameters.AddWithValue("@Region", "Minsk");

					int rows = cmd.ExecuteNonQuery();

					Console.WriteLine("Number of rows affected : {0}", rows);
				

				}
			}

			catch (SqlException ex)
			{
				Console.WriteLine("Command exception\n" + ex.Message);

			}
		}
	}

}

