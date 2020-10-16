using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [Discriminator(nameof(NotificationType))]
    public abstract partial class SubscriptionDelivery 
    {
        public string ProjectKey { get; set;}
        
        public string NotificationType { get; set;}
        
        public Reference Resource { get; set;}
        
        public UserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set;}
    }
}
