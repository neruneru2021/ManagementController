using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementController.Domain.Workers
{
    /// <summary>
    /// 具象クラス3
    /// </summary>
    internal class SampleEntity3 : MainWoker
    {
        /// <summary>
        /// SampleEntity3のSubWork()
        /// </summary>
        protected override void SubWork()
        {
            System.Diagnostics.Debug.WriteLine("SampleEntity3の個別処理");
        }
    }
}
