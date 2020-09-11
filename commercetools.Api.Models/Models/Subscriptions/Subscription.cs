using commercetools.Api.Models.Common;
using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Subscriptions
{
    public class Subscription : BaseResource
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public DateTime LastModifiedAt { get; set;}
        
        public LastModifiedBy LastModifiedBy { get; set;}
        
        public CreatedBy CreatedBy { get; set;}
        
        public List<ChangeSubscription> Changes { get; set;}
        
        public Destination Destination { get; set;}
        
        public string Key { get; set;}
        
        public List<MessageSubscription> Messages { get; set;}
        
        public DeliveryFormat Format { get; set;}
        
        public SubscriptionHealthStatus Status { get; set;}
    }
}
