using NUnit.Framework;
using ServiceControllerAddOn;
using TestProject.SDK;

namespace Runners.Nunit
{
    public class GenericTests
    {
        private static string DevToken = "xYaVWOmylyN8y-4O0CZ0WLRR1k2XuW_Gzxi5qknIebU1";

        Runner _runner;

        [SetUp]
        public void SetUp()
        {
            _runner = RunnerFactory.Instance.Create(DevToken);
        }

        [TearDown]
        public void TearDown()
        {
            _runner.Dispose();
        }

        [Test]
        public void RunAction()
        {
            var action = new StopServiceAction();
            action.ServiceName = "CloseMe!!";
            action.WaitingTime = "now";

            // Run action
            _runner.Run(action);
        }
    }
}