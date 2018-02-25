using HelloAndroid.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MainViewModel_TestRefresh_ShouldSucceed()
        {
            var service = new TestYoutubeService();
            var vm = new MainViewModel(service);

            vm.RefreshCommand.Execute(null);

            Assert.AreEqual(TestYoutubeService.ResultPassed, vm.Result);
        }

        [TestMethod]
        public void MainViewModel_TestRefreshFail_ShouldCopyExceptionMessageInResult()
        {
            var service = new TestYoutubeService(true);
            var vm = new MainViewModel(service);

            vm.RefreshCommand.Execute(null);

            Assert.AreEqual(TestYoutubeService.ExceptionMessage, vm.Result);
        }
    }
}
