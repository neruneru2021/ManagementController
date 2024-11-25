using ManagementController.WinForm;
using ManagementController.WinForm.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ManagementControllerTest.Test.WinForm
{
    /// <summary>
    /// MainViewModel用単体テスト
    /// </summary>
    [TestClass]
    public class MainViewModelTest
    {
        /// <summary>
        /// シナリオテスト
        /// </summary>
        [TestMethod]
        public void シナリオテスト()
        {
            MainViewModel viewModel = new MainViewModel();
            viewModel.SampleLabel = "Test";
            Assert.AreEqual("Test", viewModel.SampleLabel);
        }
    }
}
