using functions_dependency_injection_poc.DependencyInjection;
using functions_dependency_injection_poc.Services;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;

namespace functions_dependency_injection_poc
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static void Run(
            [QueueTrigger("events-to-update", Connection = "QueueConnectionString")]string myQueueItem,
            TraceWriter log,
            [Inject]ITestService testService)
        {
            // https://esade.queue.core.windows.net/events-to-update?st=2018-02-23T17%3A55%3A00Z&se=2018-02-24T17%3A55%3A00Z&sp=r&sv=2017-04-17&sig=UvR8NGqzRxJQXdIwSGnxMgrR4Xcws2vP%2Bz68OHLQ9a8%3D

            log.Info($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
