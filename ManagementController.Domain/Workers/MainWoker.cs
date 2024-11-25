using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementController.Domain.Workers
{
    /// <summary>
    /// 基底クラス
    /// </summary>
    public abstract class MainWoker
    {
        /// <summary>
        /// メイン処理
        /// </summary>
        public void DoWork()
        {
            MainWork();

            SubWork();
        }

        /// <summary>
        /// overrideメソッド
        /// 実装強制、絶対実行
        /// </summary>
        protected abstract void SubWork();

        /// <summary>
        /// 実装は任意、実装あった場合は実行
        /// </summary>
        protected virtual void SubWorkMore() { }

        private void MainWork()
        {
            System.Diagnostics.Debug.WriteLine("共通処理");
        }
    }
}
