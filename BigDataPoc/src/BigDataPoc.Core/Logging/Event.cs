using System.Collections.Generic;

namespace BigDataPoc.Core.Logging
{
    public class Event
    {
        public string Name { get; private set; }
        public Dictionary<string, object> Facets { get; private set; }
        public Event(string name, IEnumerable<Facet> facets)
        {
            Name = name;

            // flatten the facets
            Facets = new Dictionary<string, object>();
            foreach(var f in facets)
            {
                Facets.Add(f.Name, f.Value);
            }
        }
    }
}
