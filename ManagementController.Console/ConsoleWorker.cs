using ManagementController.Domain;
using ManagementController.Domain.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementController.Console
{
    internal class ConsoleWorker
    {
        internal void DoWork(List<string> WorkerNames)
        {
            foreach (var workerName in WorkerNames)
            {
                MainWoker worker = Factory.Create(workerName);

                worker.DoWork();
            }
        }
    }
}
