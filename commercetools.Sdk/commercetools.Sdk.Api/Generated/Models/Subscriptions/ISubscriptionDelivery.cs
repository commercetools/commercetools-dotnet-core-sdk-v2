using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [TypeDiscriminator(nameof(NotificationType))]
    [SubTypeDiscriminator("ResourceUpdated", typeof(commercetools.Api.Models.Subscriptions.ResourceUpdatedDelivery))]
    [SubTypeDiscriminator("Message", typeof(commercetools.Api.Models.Subscriptions.MessageDelivery))]
    [SubTypeDiscriminator("ResourceDeleted", typeof(commercetools.Api.Models.Subscriptions.ResourceDeletedDelivery))]
    [SubTypeDiscriminator("ResourceCreated", typeof(commercetools.Api.Models.Subscriptions.ResourceCreatedDelivery))]
    public partial interface ISubscriptionDelivery 
    {
        string ProjectKey { get; set;}
        
        string NotificationType { get; set;}
        
        IReference Resource { get; set;}
        
        IUserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set;}
    }
}
