using System.Collections.Generic;

namespace CSharpFundamentalsSandbox.Katas.OOP.Interfaces___Polymorphism
{
    public class TicketWorkflow : IWorkflow
    {
        private readonly IList<ITask> _taskList;

        public TicketWorkflow()
        {
            _taskList = new List<ITask>();
        }

        public void Add(ITask task)
        {
            _taskList.Add(task);
        }

        public IEnumerable<ITask> GetTasks()
        {
            return _taskList;
        }
    }
}