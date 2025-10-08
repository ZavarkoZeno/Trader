using System;
using Mysql.Data.MySqlClient;

public class Class1
{
	public Class1()
	{
		public Connect()
	    {

			public MysqlConnection _connection;

		    private string _host;
	        private string _port;
	        private string _db;
	        private string _password;

	        private string _connectionString;

	        public Connect()
	        {
		         _host = "localhost";
		         _db = "trader";
		         _user = "root";
		         _password = "";

		         _connectionString = $"SERVER={_host};DATABASE={_db};UID={_user};PASSWORD={_password};SslMode=None";

		         _connection = new MysqlConnection(_connectionString);
	        }
        }
	}
}
