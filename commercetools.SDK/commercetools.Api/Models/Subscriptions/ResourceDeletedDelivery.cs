using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DiscriminatorValue("ResourceDeleted")]
    public partial class ResourceDeletedDelivery : SubscriptionDelivery
    {
        public long Version { get; set;}
        
        public DateTime ModifiedAt { get; set;}
        public ResourceDeletedDelivery()
        { 
           this.NotificationType = "ResourceDeleted";
        }
    }
}
