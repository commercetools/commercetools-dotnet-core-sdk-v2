using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [TypeDiscriminator(nameof(NotificationType))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.Subscriptions.SubscriptionDelivery))]
    [SubTypeDiscriminator("Message", typeof(commercetools.Api.Models.Subscriptions.MessageDelivery))]
    [SubTypeDiscriminator("ResourceCreated", typeof(commercetools.Api.Models.Subscriptions.ResourceCreatedDelivery))]
    [SubTypeDiscriminator("ResourceDeleted", typeof(commercetools.Api.Models.Subscriptions.ResourceDeletedDelivery))]
    [SubTypeDiscriminator("ResourceUpdated", typeof(commercetools.Api.Models.Subscriptions.ResourceUpdatedDelivery))]
    public partial interface ISubscriptionDelivery 
    {
        string ProjectKey { get; set;}
        
        string NotificationType { get; set;}
        
        IReference Resource { get; set;}
        
        IUserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set;}
    }
}
