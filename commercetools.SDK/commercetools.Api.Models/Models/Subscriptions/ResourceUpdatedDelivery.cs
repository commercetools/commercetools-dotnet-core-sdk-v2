using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DiscriminatorValue("ResourceUpdated")]
    public partial class ResourceUpdatedDelivery : SubscriptionDelivery
    {
        public long Version { get; set;}
        
        public long OldVersion { get; set;}
        
        public DateTime ModifiedAt { get; set;}
        public ResourceUpdatedDelivery()
        { 
           this.NotificationType = "ResourceUpdated";
        }
    }
}
