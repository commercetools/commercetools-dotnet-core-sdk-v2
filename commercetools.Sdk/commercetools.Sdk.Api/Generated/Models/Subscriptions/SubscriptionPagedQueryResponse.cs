using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    public partial class SubscriptionPagedQueryResponse : ISubscriptionPagedQueryResponse
    {
        public long Limit { get; set;}
        
        public long Count { get; set;}
        
        public long? Total { get; set;}
        
        public long Offset { get; set;}
        
        public List<ISubscription> Results { get; set;}
    }
}
