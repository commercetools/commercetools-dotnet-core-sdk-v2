using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Subscriptions
{
    public partial class SubscriptionUpdate 
    {
        public long Version { get; set;}
        
        public List<SubscriptionUpdateAction> Actions { get; set;}
    }
}
