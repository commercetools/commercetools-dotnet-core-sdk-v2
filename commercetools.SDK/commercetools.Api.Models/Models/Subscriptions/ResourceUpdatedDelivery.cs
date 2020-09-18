using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DiscriminatorValue("ResourceUpdated")]
    public class ResourceUpdatedDelivery : SubscriptionDelivery
    {
        public long Version { get; set;}
        
        public long OldVersion { get; set;}
        
        public DateTime ModifiedAt { get; set;}
    }
}
