using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.SubscriptionSetMessagesAction))]
    public partial interface ISubscriptionSetMessagesAction : ISubscriptionUpdateAction
    {
        List<IMessageSubscription> Messages { get; set; }
    }
}
