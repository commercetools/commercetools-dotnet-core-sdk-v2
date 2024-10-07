using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.ResourceCreatedDeliveryPayload))]
    public partial interface IResourceCreatedDeliveryPayload : IDeliveryPayload
    {
        long Version { get; set; }

        DateTime ModifiedAt { get; set; }

    }
}
