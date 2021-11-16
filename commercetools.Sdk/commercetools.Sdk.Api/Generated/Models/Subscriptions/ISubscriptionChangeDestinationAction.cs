using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Subscriptions.SubscriptionChangeDestinationAction))]
    public partial interface ISubscriptionChangeDestinationAction : ISubscriptionUpdateAction
    {
        IDestination Destination { get; set;}
    }
}
