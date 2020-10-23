using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    public  partial class SubscriptionSetChangesAction : ISubscriptionSetChangesAction
    {
        public string Action { get; set;}
        
        public List<IChangeSubscription> Changes { get; set;}
        public SubscriptionSetChangesAction()
        { 
           this.Action = "setChanges";
        }
    }
}
