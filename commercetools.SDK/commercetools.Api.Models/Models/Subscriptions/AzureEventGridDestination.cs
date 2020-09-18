using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DiscriminatorValue("EventGrid")]
    public class AzureEventGridDestination : Destination
    {
        public string Uri { get; set;}
        
        public string AccessKey { get; set;}
    }
}
