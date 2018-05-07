using System;
using System.Data.SqlClient;

namespace DataBaseTask
{
	class Update
	{
		public void UpdateUser(SqlConnection connection)
		{
			int rows = 0;
			using (SqlCommand cmd = new SqlCommand("UPDATE Customers SET CompanyName = @CompanyName WHERE CustomerID = @CustomerID", connection))
			{

				cmd.Parameters.AddWithValue("@CompanyName", "NEEPAM");
				cmd.Parameters.AddWithValue("@CustomerID", "ALFKI");
				rows = cmd.ExecuteNonQuery();
				Console.WriteLine("Number of rows updated:{0}", rows);
				if (rows == 0)
				{
					var error = new Exception("Could not update user");
					Console.WriteLine("User was not updated", error);
				}
				
			}
			}
		}

	}

	

