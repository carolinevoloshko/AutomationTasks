using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataBaseTask
{
	class CallProcedure
	{
		public void ProcedureCall(SqlConnection connection,string city)
		{

			using (SqlCommand cmd = new SqlCommand("Customers By City", connection))
			{
				try
				{
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.Add(new SqlParameter("@param1",city));
					cmd.ExecuteNonQuery();
				}
				catch (SqlException ex)
				{
					Console.WriteLine("Procedure was not called", ex.InnerException, ex.Message, ex.Procedure);
				}

				finally
				{
					using (SqlDataReader rdr = cmd.ExecuteReader())
					{

						while (rdr.Read())
						{
							Console.WriteLine("CustomerID: {0} ContactName: {1} CompanyName: {2} City {3}", rdr["CustomerID"], rdr["ContactName"], rdr["CompanyName"], rdr["City"]);

						}

					}
				}
			}
			
		}
	}
}

