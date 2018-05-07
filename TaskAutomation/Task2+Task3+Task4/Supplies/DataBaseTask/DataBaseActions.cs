using System;
using System.Configuration;
using System.Data.SqlClient;

namespace DataBaseTask
{
	class DataBaseActions
	{
		public void Select()
		{
			try
			{
				using (var cn = new SqlConnection())
				{
					string connectionString = ConfigurationManager.AppSettings["cnStr"];
					Console.WriteLine("Connection object --> " + cn.GetType().Name);
					cn.ConnectionString = connectionString;
					cn.Open();

					Select select = new Select();
					select.SelectUsers(cn);
				}
			}

			catch (SystemException ex)
			{
				Console.WriteLine("Connection failed\n" + ex.Message);
			}

		}

		public void Insert()
		{
			try
			{
				using (var cn = new SqlConnection())
				{
					string connectionString = ConfigurationManager.AppSettings["cnStr"];
					Console.WriteLine("Connection object --> " + cn.GetType().Name);
					cn.ConnectionString = connectionString;
					cn.Open();
					Insert insert = new Insert();
					insert.InsertUser(cn);
				}

			}

			catch (SystemException ex)
			{
				Console.WriteLine("Connection failed\n" + ex.Message);
			}

		}

		public void Update()
		{
			try
			{
				using (var cn = new SqlConnection())
				{
					string connectionString = ConfigurationManager.AppSettings["cnStr"];
					Console.WriteLine("Connection object --> " + cn.GetType().Name);
					cn.ConnectionString = connectionString;
					cn.Open();
					Update update = new Update();
					update.UpdateUser(cn);
				}
			}
			catch (SqlException ex)
			{
				Console.WriteLine("Connection failed\n" + ex.Message);
			}
		}

		public void Delete()
		{
			try
			{
				using (var cn = new SqlConnection())
				{
					string connectionString = ConfigurationManager.AppSettings["cnStr"];
					Console.WriteLine("Connection object --> " + cn.GetType().Name);
					cn.ConnectionString = connectionString;
					cn.Open();
					Delete delete = new Delete();
					delete.DeleteUser(cn);
				}
			}

			catch (SystemException ex)
			{
				Console.WriteLine("Connection failed\n" + ex.Message);
			}
		}


		public void CallProcedure()
		{

			try
			{
				using (var cn = new SqlConnection())
				{
					string connectionString = ConfigurationManager.AppSettings["cnStr"];
					Console.WriteLine("Connection object --> " + cn.GetType().Name);
					cn.ConnectionString = connectionString;
					cn.Open();
					CallProcedure callprocedure = new CallProcedure();
					callprocedure.ProcedureCall(cn,"London");
				}
			}

			catch (SystemException ex)
			{
				Console.WriteLine("Connection failed\n" + ex.Message);
			}
		}
	}
}
	
	
