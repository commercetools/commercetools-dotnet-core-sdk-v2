using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DiscriminatorValue("setChanges")]
    public partial class SubscriptionSetChangesAction : SubscriptionUpdateAction
    {
        public List<ChangeSubscription> Changes { get; set;}
        public SubscriptionSetChangesAction()
        { 
           this.Action = "setChanges";
        }
    }
}
