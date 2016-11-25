using System.Collections.Generic;

namespace RestCache.Core.Contracts
{
    public class Response
    {
        public StatusCode StatusCode { get; }
        public KeyValuePair<string, string> Header { get; }
        public string Body { get; }

        public Response(StatusCode statusCode, KeyValuePair<string, string> header, string body)
        {
            StatusCode = statusCode;
            Header = header;
            Body = body;
        }
    }
}
