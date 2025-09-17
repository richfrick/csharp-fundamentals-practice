using System;
using CSharpFundamentalsSandbox.Katas.OOP.Polymorphism;

namespace CSharpFundamentalsSandbox
{
    internal class Program
    {
        private static void Helper(Action action)
        {
            try
            {
                action();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void Main(string[] args)
        {
            var oracleConnection1 = new OracleConnection("http.ORACLE-Connection.com", TimeSpan.FromMinutes(10));
            oracleConnection1.OpenConnection();
            oracleConnection1.CloseConnection();
            
            var oracleConnection = new OracleConnection(null, TimeSpan.FromMinutes(10));
            oracleConnection.OpenConnection();
            oracleConnection.CloseConnection();

            var sqlConnection1 = new SqlConnection("http.SQL-Connection.com", TimeSpan.FromMinutes(20));
            sqlConnection1.OpenConnection();
            sqlConnection1.CloseConnection();
            
            var sqlConnection0 = new SqlConnection(null, TimeSpan.FromMinutes(10));
            sqlConnection1.OpenConnection();
            sqlConnection1.CloseConnection();
            
            
        }
    }
}