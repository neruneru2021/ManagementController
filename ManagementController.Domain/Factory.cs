using ManagementController.Domain.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementController.Domain
{
    public static class Factory
    {
        public static MainWoker Create(string workerName)
        {
            switch (workerName)
            {
                case nameof(SampleEntity1):
                    return new SampleEntity1();
                case nameof(SampleEntity2):
                    return new SampleEntity2();
                case nameof(SampleEntity3):
                    return new SampleEntity3();
                default:
                    throw new Exception();
            }
        }
    }
}
