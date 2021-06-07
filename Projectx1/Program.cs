using System;

namespace Projectx1
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker { FirstName = "Mehmet", LastName = "Tonğut", Id = 1 };
            ICheckPerson checkPerson = new CheckPersonManager();
            IWorkerService workerService = new WorkerManager(checkPerson );
            workerService.GetSalary(worker1);
            
            Console.Read();

        }
    }
}
