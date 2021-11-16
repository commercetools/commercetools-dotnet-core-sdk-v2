using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Subscriptions.ResourceCreatedDelivery))]
    public partial interface IResourceCreatedDelivery : ISubscriptionDelivery
    {
        long Version { get; set;}
        
        DateTime ModifiedAt { get; set;}
    }
}
