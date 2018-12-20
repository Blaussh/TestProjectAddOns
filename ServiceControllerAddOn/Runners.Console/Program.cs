
using ServiceControllerAddOn;
using TestProject.SDK;

namespace Runners.Console
{
    class Program
    {
        private static string DevToken = "xYaVWOmylyN8y-4O0CZ0WLRR1k2XuW_Gzxi5qknIebU1";
        static void Main(string[] args)
        {
            using (Runner runner = RunnerFactory.Instance.Create(DevToken))
            {
                var action = new StopServiceAction();
                action.ServiceName = "CloseMe!!";
                action.WaitingTime = "now";

                runner.Run(action);
            }

            System.Console.ReadKey();
        }
    }
}
