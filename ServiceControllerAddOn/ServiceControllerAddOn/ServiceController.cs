using System;
using TestProject.SDK;
using TestProject.SDK.Addons.Actions;
using TestProject.SDK.Addons.Helpers;
using TestProject.SDK.Common.Attributes;
using TestProject.SDK.Common.Enums;

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

        public ExecutionResult Execute(GenericAddonHelper helper)
        {
            Result = $"We are stopping {ServiceName} and waiting {WaitingTime}";
            helper.Reporter.Result = $"Attention! {Result}";

            return ExecutionResult.Passed;
        }
    }
}
