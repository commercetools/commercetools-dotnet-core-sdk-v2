using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    public class SubscriptionUpdate 
    {
        public long Version { get; set;}
        
        public List<SubscriptionUpdateAction> Actions { get; set;}
    }
}
