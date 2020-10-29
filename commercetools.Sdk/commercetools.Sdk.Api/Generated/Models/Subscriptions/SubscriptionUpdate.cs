using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    public partial class SubscriptionUpdate : ISubscriptionUpdate
    {
        public long Version { get; set;}
        
        public List<ISubscriptionUpdateAction> Actions { get; set;}
    }
}
