using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Subscriptions
{
    public class MessageDelivery : SubscriptionDelivery
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public DateTime LastModifiedAt { get; set;}
        
        public long SequenceNumber { get; set;}
        
        public long ResourceVersion { get; set;}
        
        public PayloadNotIncluded PayloadNotIncluded { get; set;}
    }
}
