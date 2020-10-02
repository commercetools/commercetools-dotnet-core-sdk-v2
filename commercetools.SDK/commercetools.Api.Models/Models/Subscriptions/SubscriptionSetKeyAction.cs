using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DiscriminatorValue("setKey")]
    public partial class SubscriptionSetKeyAction : SubscriptionUpdateAction
    {
        public string Key { get; set;}
        public SubscriptionSetKeyAction()
        { 
           this.Action = "setKey";
        }
    }
}
