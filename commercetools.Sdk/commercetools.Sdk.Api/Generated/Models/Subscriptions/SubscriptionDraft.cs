using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    public  partial class SubscriptionDraft : ISubscriptionDraft
    {
        public List<IChangeSubscription> Changes { get; set;}
        
        public IDestination Destination { get; set;}
        
        public string Key { get; set;}
        
        public List<IMessageSubscription> Messages { get; set;}
        
        public IDeliveryFormat Format { get; set;}
    }
}
