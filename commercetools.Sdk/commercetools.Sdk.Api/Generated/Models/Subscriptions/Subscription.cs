using commercetools.Api.Models.Common;
using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    public partial class Subscription : ISubscription
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public DateTime LastModifiedAt { get; set;}
        
        public ILastModifiedBy LastModifiedBy { get; set;}
        
        public ICreatedBy CreatedBy { get; set;}
        
        public List<IChangeSubscription> Changes { get; set;}
        
        public IDestination Destination { get; set;}
        
        public string Key { get; set;}
        
        public List<IMessageSubscription> Messages { get; set;}
        
        public IDeliveryFormat Format { get; set;}
        
        public ISubscriptionHealthStatus Status { get; set;}
    }
}
