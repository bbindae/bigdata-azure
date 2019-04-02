using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.EventHubs;
using Newtonsoft.Json.Linq;

namespace BigDataPoc.Api.Analytics.EventHubs
{
    public class EventHubEventSender : IEventSender
    {
        // TODO: Move them to appSettings.json
        private const string EventHubConnectionString = "Endpoint=sb://lpdatacapture.servicebus.windows.net/;SharedAccessKeyName=api-sender;SharedAccessKey=CWEEcUBjkckluWIea+Vc/a8bmffUGvytQkMvRgUY6lM=";
        private const string EventHubName = "product-events";
        private EventHubsConnectionStringBuilder connectionBuilder;

        // TODO: Add a logger

        public EventHubEventSender()
        {
            connectionBuilder = new EventHubsConnectionStringBuilder(EventHubConnectionString)
            {
                EntityPath = EventHubName
            };
        }

        public async Task SendEventsAsync(JObject @event, string userSessionId)
        {
            var eventHubClient = EventHubClient.CreateFromConnectionString(connectionBuilder.ToString());
            var json = @event.ToString(Newtonsoft.Json.Formatting.None);

            // Without Setting PafrtitionId, it will be Round-Robin
            var eventData = new EventData(Encoding.UTF8.GetBytes(json));
            
            
            await eventHubClient.SendAsync(new EventData(Encoding.UTF8.GetBytes(json)));
        }
    }
}
