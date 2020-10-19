using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Subscriptions
{
    public partial class SubscriptionDraft 
    {
        public List<ChangeSubscription> Changes { get; set;}
        
        public Destination Destination { get; set;}
        
        public string Key { get; set;}
        
        public List<MessageSubscription> Messages { get; set;}
        
        public DeliveryFormat Format { get; set;}
    }
}
