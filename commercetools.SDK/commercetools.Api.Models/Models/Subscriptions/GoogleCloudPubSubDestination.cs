using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DiscriminatorValue("GoogleCloudPubSub")]
    public class GoogleCloudPubSubDestination : Destination
    {
        public string ProjectId { get; set;}
        
        public string Topic { get; set;}
    }
}
