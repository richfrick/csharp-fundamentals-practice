using System;

namespace CSharpFundamentalsSandbox.Katas.OOP.Polymorphism
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString, TimeSpan? timeout = null) : base(connectionString, timeout)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Sql connection open");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Sql connection closed");
        }
    }
}