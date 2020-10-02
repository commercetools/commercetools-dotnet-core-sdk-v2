using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DiscriminatorValue("changeDestination")]
    public partial class SubscriptionChangeDestinationAction : SubscriptionUpdateAction
    {
        public Destination Destination { get; set;}
        public SubscriptionChangeDestinationAction()
        { 
           this.Action = "changeDestination";
        }
    }
}
