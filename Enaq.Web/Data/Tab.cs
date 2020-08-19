using System;

namespace Enaq.Web.Data
{
    public class Tab: Record
    {
        public Uri Url { get; set; }
        
        public Request Request { get; set; }
        
        public Response Response { get; set; }
    }
}