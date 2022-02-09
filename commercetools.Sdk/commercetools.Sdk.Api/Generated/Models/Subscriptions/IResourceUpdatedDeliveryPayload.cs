using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Subscriptions.ResourceUpdatedDeliveryPayload))]
    public partial interface IResourceUpdatedDeliveryPayload : IDeliveryPayload
    {
        long Version { get; set; }

        long OldVersion { get; set; }

        DateTime ModifiedAt { get; set; }
    }
}
