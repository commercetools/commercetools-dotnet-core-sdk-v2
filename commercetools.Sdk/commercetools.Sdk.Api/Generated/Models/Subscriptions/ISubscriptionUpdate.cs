using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.SubscriptionUpdate))]
    public partial interface ISubscriptionUpdate
    {
        long Version { get; set; }

        List<ISubscriptionUpdateAction> Actions { get; set; }
    }
}
