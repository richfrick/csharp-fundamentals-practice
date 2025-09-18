using CSharpFundamentalsSandbox.Katas.OOP.Interfaces___Polymorphism;

namespace CSharpFundamentalsSandbox
{
    internal class Program
    {
        // private static void Helper(Action action)
        // {
        //     try
        //     {
        //         action();
        //     }
        //     catch (Exception e)
        //     {
        //         Console.WriteLine(e);
        //     }
        // }

        public static void Main(string[] args)
        {
            //POLYMORPHISM
            // var oracleConnection = new OracleConnection("http.ORACLE-Connection.com", TimeSpan.FromMinutes(5));
            //
            // var dbCommand = new DbCommand(oracleConnection, "SEL * FROM DB_TEST");
            // dbCommand.Execute();
            //
            // var sqlConnection = new OracleConnection("http.SQL-Connection.com");
            //
            // var dbCommand1 = new DbCommand(sqlConnection, "SEL * FROM DB_TEST");
            // dbCommand1.Execute();

            var workflow = new TicketWorkflow();

            workflow.Add(new CreateTicket());
            workflow.Add(new MoveToInProgress());
            workflow.Add(new ReadyForQa());

            var workflowEngine = new WorkflowEngine();
            workflowEngine.Run(workflow);
        }
    }
}