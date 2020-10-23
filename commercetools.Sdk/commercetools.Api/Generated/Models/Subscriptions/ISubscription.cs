using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Subscriptions
{
    public interface ISubscription : IBaseResource
    {
        string Id { get; set;}
        
        long Version { get; set;}
        
        DateTime CreatedAt { get; set;}
        
        DateTime LastModifiedAt { get; set;}
        
        ILastModifiedBy LastModifiedBy { get; set;}
        
        ICreatedBy CreatedBy { get; set;}
        
        List<IChangeSubscription> Changes { get; set;}
        
        IDestination Destination { get; set;}
        
        string Key { get; set;}
        
        List<IMessageSubscription> Messages { get; set;}
        
        IDeliveryFormat Format { get; set;}
        
        string Status { get; set;}
        
        SubscriptionHealthStatus StatusAsEnum { get; }
    }
}
