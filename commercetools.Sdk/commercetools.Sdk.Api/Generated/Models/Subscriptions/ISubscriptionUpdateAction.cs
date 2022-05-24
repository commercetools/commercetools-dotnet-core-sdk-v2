using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Subscriptions.SubscriptionUpdateAction))]
    [SubTypeDiscriminator("changeDestination", typeof(commercetools.Sdk.Api.Models.Subscriptions.SubscriptionChangeDestinationAction))]
    [SubTypeDiscriminator("setChanges", typeof(commercetools.Sdk.Api.Models.Subscriptions.SubscriptionSetChangesAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.Api.Models.Subscriptions.SubscriptionSetKeyAction))]
    [SubTypeDiscriminator("setMessages", typeof(commercetools.Sdk.Api.Models.Subscriptions.SubscriptionSetMessagesAction))]
    public partial interface ISubscriptionUpdateAction : commercetools.Sdk.Api.Models.IResourceUpdateAction<ISubscriptionUpdateAction>
    {
        new string Action { get; set; }
    }
}
