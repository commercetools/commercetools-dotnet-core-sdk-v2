using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Subscriptions
{
    public class AzureEventGridDestination : Destination
    {
        public string Uri { get; set;}
        
        public string AccessKey { get; set;}
    }
}
