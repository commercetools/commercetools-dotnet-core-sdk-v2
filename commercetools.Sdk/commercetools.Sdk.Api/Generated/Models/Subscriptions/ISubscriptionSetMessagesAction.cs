using commercetools.Sdk.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.SubscriptionSetMessagesAction))]
    public partial interface ISubscriptionSetMessagesAction : ISubscriptionUpdateAction
    {
        IList<IMessageSubscription> Messages { get; set; }
        IEnumerable<IMessageSubscription> MessagesEnumerable { set => Messages = value.ToList(); }


    }
}
