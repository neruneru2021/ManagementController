using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementController.Domain.Workers
{
    /// <summary>
    /// 具象クラス1
    /// </summary>
    internal class SampleEntity1 : MainWoker
    {
        /// <summary>
        /// SampleEntity1の処理
        /// </summary>
        protected override void SubWork()
        {
            System.Diagnostics.Debug.WriteLine("SampleEntity1の個別処理");
        }
    }
}
