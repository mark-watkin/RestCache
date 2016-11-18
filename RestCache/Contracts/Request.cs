using System.Collections.Generic;

namespace RestCache.Core.Contracts
{
    public class Request
    {
        public HttpVerb Verb { get; }
        public KeyValuePair<string, string> Header { get; }
        public LinkedList<string> Resource { get; }

        public Request(HttpVerb verb, KeyValuePair<string, string> header, LinkedList<string> resource)
        {
            Verb = verb;
            Header = header;
            Resource = resource;
        }
    }
}
