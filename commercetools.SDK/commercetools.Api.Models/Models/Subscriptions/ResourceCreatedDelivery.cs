using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DiscriminatorValue("ResourceCreated")]
    public class ResourceCreatedDelivery : SubscriptionDelivery
    {
        public long Version { get; set;}
        
        public DateTime ModifiedAt { get; set;}
    }
}
