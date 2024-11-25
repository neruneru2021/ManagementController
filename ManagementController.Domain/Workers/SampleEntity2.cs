using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementController.Domain.Workers
{
    /// <summary>
    /// 具象クラス2
    /// </summary>
    internal class SampleEntity2 : MainWoker
    {
        /// <summary>
        /// SampleEntity2のSubWork()
        /// </summary>
        protected override void SubWork()
        {
            System.Diagnostics.Debug.WriteLine("SampleEntity2の個別処理");
        }

        /// <summary>
        /// SampleEntity2のSubWorkMore()
        /// </summary>
        protected override void SubWorkMore()
        {
            System.Diagnostics.Debug.WriteLine("SampleEntity2のもう一個の個別処理");
        }
    }
}
