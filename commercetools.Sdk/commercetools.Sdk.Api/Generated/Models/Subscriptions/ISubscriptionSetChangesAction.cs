using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Subscriptions.SubscriptionSetChangesAction))]
    public partial interface ISubscriptionSetChangesAction : ISubscriptionUpdateAction
    {
        List<IChangeSubscription> Changes { get; set; }
    }
}
