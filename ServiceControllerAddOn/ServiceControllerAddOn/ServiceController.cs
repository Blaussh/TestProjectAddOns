using System;
using TestProject.SDK;
using TestProject.SDK.Addons.Actions;
using TestProject.SDK.Addons.Helpers;
using TestProject.SDK.Common.Attributes;
using TestProject.SDK.Common.Enums;
using System.ServiceProcess;
namespace ServiceControllerAddOn
{
    [Action(Name = "Stop Service", Description = "Stops a windows service of your choice")]
    public class StopServiceAction : IGenericAction
    {

        [Parameter]
        public string ServiceName;

        [Parameter]
        public string WaitingTime;

        [Parameter(Description = "Stop result", Direction = ParameterDirection.Output)]
        public string Result;

        public enum ServiceCustomCommands
        {
            StopWorker = 128,
            RestartWorker,
            CheckWorker
        }

        public ExecutionResult Execute(GenericAddonHelper helper)
        {
            ServiceController service = new ServiceController("AlgoAnalyzer");
            Result = $"We are stopping {ServiceName} and waiting {WaitingTime} - {service.Status}";
            service.Stop();
            helper.Reporter.Result = $"Attention! {Result}";

            return ExecutionResult.Passed;
        }
    }
}
