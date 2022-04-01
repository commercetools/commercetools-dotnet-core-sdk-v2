using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.ResourceDeletedDeliveryPayload))]
    public partial interface IResourceDeletedDeliveryPayload : IDeliveryPayload
    {
        long Version { get; set; }

        DateTime ModifiedAt { get; set; }

        bool? DataErasure { get; set; }
    }
}
