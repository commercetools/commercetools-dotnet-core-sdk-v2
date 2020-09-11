using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Subscriptions
{
    public class ResourceCreatedDelivery : SubscriptionDelivery
    {
        public long Version { get; set;}
        
        public DateTime ModifiedAt { get; set;}
    }
}
