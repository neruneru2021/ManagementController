using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementController.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> workers = new List<string>()
            {
                "SampleEntity1",
                "SampleEntity2",
                "SampleEntity3",
            };

            ConsoleWorker worker = new ConsoleWorker();

            worker.DoWork(workers);
        }
    }
}
