using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Subscriptions
{
    public class GoogleCloudPubSubDestination : Destination
    {
        public string ProjectId { get; set;}
        
        public string Topic { get; set;}
    }
}
