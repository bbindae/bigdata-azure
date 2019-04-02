using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigDataPoc.Api.Analytics
{
    public interface IEventSender
    {
        Task SendEventsAsync(JObject @event, string userSessionId);
    }
}
