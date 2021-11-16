using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Subscriptions.ResourceDeletedDelivery))]
    public partial interface IResourceDeletedDelivery : ISubscriptionDelivery
    {
        long Version { get; set;}
        
        DateTime ModifiedAt { get; set;}
        
        bool? DataErasure { get; set;}
    }
}
