using System;
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

        static commercetools.Sdk.Api.Models.Subscriptions.SubscriptionChangeDestinationAction ChangeDestination(Action<commercetools.Sdk.Api.Models.Subscriptions.SubscriptionChangeDestinationAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Subscriptions.SubscriptionChangeDestinationAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Subscriptions.SubscriptionSetChangesAction SetChanges(Action<commercetools.Sdk.Api.Models.Subscriptions.SubscriptionSetChangesAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Subscriptions.SubscriptionSetChangesAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Subscriptions.SubscriptionSetKeyAction SetKey(Action<commercetools.Sdk.Api.Models.Subscriptions.SubscriptionSetKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Subscriptions.SubscriptionSetKeyAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Subscriptions.SubscriptionSetMessagesAction SetMessages(Action<commercetools.Sdk.Api.Models.Subscriptions.SubscriptionSetMessagesAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Subscriptions.SubscriptionSetMessagesAction();
            init?.Invoke(t);
            return t;
        }
    }
}
