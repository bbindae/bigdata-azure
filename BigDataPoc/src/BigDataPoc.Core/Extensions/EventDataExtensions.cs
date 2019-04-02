using Microsoft.Azure.EventHubs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigDataPoc.Core.Extensions
{
    public static class EventDataExtensions
    {
        public static string GetEventName(this EventData eventData)
        {
            return (string)GetPropertyValue(eventData, "eventName");
        }

        public static void SetEventName(this EventData eventData, string eventName)
        {
            SetPropertyValue(eventData, "eventName", eventName);
        }

        private static object GetPropertyValue(EventData eventData, string propertyName, object defaultValue = null)
        {
            object value = defaultValue;

            if (eventData.Properties != null && eventData.Properties.ContainsKey(propertyName))
            {
                value = eventData.Properties[propertyName];
            }

            return value;
        }

        private static void SetPropertyValue(EventData eventData, string propertyName, object value)
        {
            eventData.Properties[propertyName] = value;
        }
    }
}
