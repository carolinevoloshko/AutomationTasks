using System;
using System.Data.SqlClient;

namespace DataBaseTask
{
	class Delete
	{
		public void DeleteUser(SqlConnection connection)
		{
			
				using (SqlCommand cmd = new SqlCommand("DELETE FROM Customers WHERE CustomerID = @CustomerID", connection))
				{
					cmd.Parameters.AddWithValue("@CustomerID", "AAAAP");
					int rows = cmd.ExecuteNonQuery();
					Console.WriteLine("Number of rows affected : {0}", rows);

					if (rows == 0)
					{
						var error = new Exception("Could not delete user");
						Console.WriteLine("User was not deleted", error);
					}
				}
		}
	}
}
