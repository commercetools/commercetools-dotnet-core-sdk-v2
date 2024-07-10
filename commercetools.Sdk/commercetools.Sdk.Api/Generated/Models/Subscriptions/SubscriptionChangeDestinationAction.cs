using commercetools.Sdk.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Subscriptions
{

    public partial class SubscriptionChangeDestinationAction : ISubscriptionChangeDestinationAction
    {
        public string Action { get; set; }

        public IDestination Destination { get; set; }
        public SubscriptionChangeDestinationAction()
        {
            this.Action = "changeDestination";
        }
    }
}
