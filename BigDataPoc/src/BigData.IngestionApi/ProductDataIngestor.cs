using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Microsoft.Azure.EventHubs;
using System.Text;

namespace BigData.IngestionApi
{
    public static class ProductDataIngestor
    {

        private const string eventHubConnectionString = "Endpoint=sb://lpdatacapture.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=JDPkizejrYM4l6169pYWkYAIL8YVUtw7GYlRyWMXrLk=";
        private const string eventHubName = "product-capture";

        [FunctionName("product")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            //[EventHub("", Connection ="")] out string outputEvent,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string name = req.Query["name"];

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            log.LogInformation(requestBody);


            dynamic data = JsonConvert.DeserializeObject(requestBody);
            name = name ?? data?.name;

            // Send a event to the event hub
            var connStrBuilder = new EventHubsConnectionStringBuilder(eventHubConnectionString)
            {
                EntityPath = eventHubName
            };

            var eventHubClient = EventHubClient.CreateFromConnectionString(connStrBuilder.ToString());
            await eventHubClient.SendAsync(new EventData(Encoding.UTF8.GetBytes(requestBody)));

            return name != null
                ? (ActionResult)new OkObjectResult($"Hello, {name}")
                : new BadRequestObjectResult("Please pass a name on the query string or in the request body");
        }
    }
}
