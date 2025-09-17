using System;

namespace CSharpFundamentalsSandbox.Katas.OOP.Polymorphism
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString, TimeSpan? timeout = null)
            : base(connectionString, timeout)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Oracle Connection Open");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Oracle Connection closed");
        }
    }
}