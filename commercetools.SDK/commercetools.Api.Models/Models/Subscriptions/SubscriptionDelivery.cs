using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [Discriminator(nameof(NotificationType))]
    public abstract class SubscriptionDelivery 
    {
        public string ProjectKey { get; set;}
        
        public string NotificationType { get; set;}
        
        public Reference Resource { get; set;}
        
        public UserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set;}
    }
}
