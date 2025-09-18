using System.Collections.Generic;

namespace CSharpFundamentalsSandbox.Katas.OOP.Interfaces___Polymorphism
{
    public interface IWorkflow
    {
        void Add(ITask task);
        IEnumerable<ITask> GetTasks();
    }
}