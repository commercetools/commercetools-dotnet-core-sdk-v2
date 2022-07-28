using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.SubscriptionSetChangesAction))]
    public partial interface ISubscriptionSetChangesAction : ISubscriptionUpdateAction
    {
        List<IChangeSubscription> Changes { get; set; }

    }
}
