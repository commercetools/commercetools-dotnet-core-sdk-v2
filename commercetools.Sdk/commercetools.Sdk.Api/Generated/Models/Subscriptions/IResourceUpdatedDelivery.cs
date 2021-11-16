using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Subscriptions.ResourceUpdatedDelivery))]
    public partial interface IResourceUpdatedDelivery : ISubscriptionDelivery
    {
        long Version { get; set;}
        
        long OldVersion { get; set;}
        
        DateTime ModifiedAt { get; set;}
    }
}
