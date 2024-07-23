using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

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
