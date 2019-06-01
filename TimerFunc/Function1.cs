using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace TimerFunc
{
    public static class TimerFunc
    {
        private const string Timer = "%functions:TimerFunc:timer%";

        [FunctionName("TimerFunc")]
        public static void Run([TimerTrigger(Timer, RunOnStartup = true)]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
