using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementController.WinForm.ViewModels
{
    /// <summary>
    /// MainView用Model
    /// </summary>
    internal class MainViewModel : ViewModelBase
    {
        private string _sampleLabel = string.Empty;

        public string SampleLabel
        {
            get { return _sampleLabel; }
            set { SetProperty(ref _sampleLabel, value); }
        }

        internal void MainButtonExecute()
        {
            SampleLabel = "ボタンが押されました！";
        }
    }
}
