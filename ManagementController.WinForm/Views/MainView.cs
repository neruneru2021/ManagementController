using ManagementController.WinForm.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementController.WinForm
{
    /// <summary>
    /// メイン画面
    /// </summary>
    public partial class MainView : Form
    {
        private MainViewModel _viewModel = new MainViewModel();

        /// <summary>
        /// メイン画面コンストラクタ
        /// </summary>
        public MainView()
        {
            InitializeComponent();
            SampleLabel.DataBindings.Add(nameof(SampleLabel.Text), _viewModel, nameof(_viewModel.SampleLabel));
            MainButton.Click += (_, __) => _viewModel.MainButtonExecute();
        }
    }
}
