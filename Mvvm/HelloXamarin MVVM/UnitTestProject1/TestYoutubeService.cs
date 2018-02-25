using System;
using Data;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class TestYoutubeService : IYoutubeService
    {
        public const string ResultPassed = "Result passed";
        public const string ExceptionMessage = "There was an error";
        private bool _forceError;

        public Task<string> Refresh()
        {
            var tcs = new TaskCompletionSource<string>();
            if (_forceError)
            {
                tcs.SetException(new Exception(ExceptionMessage));
            }
            else
            {
                tcs.SetResult(ResultPassed);
            }
            return tcs.Task;
        }

        public TestYoutubeService(bool forceError = false)
        {
            _forceError = forceError;
        }

    }
}
