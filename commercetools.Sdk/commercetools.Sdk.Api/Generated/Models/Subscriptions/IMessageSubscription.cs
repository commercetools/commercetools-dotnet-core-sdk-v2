using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.MessageSubscription))]
    public partial interface IMessageSubscription
    {
        IMessageSubscriptionResourceTypeId ResourceTypeId { get; set; }

        List<string> Types { get; set; }

    }
}
