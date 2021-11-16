using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.Subscriptions.SubscriptionUpdateAction))]
    [SubTypeDiscriminator("changeDestination", typeof(commercetools.Api.Models.Subscriptions.SubscriptionChangeDestinationAction))]
    [SubTypeDiscriminator("setChanges", typeof(commercetools.Api.Models.Subscriptions.SubscriptionSetChangesAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Api.Models.Subscriptions.SubscriptionSetKeyAction))]
    [SubTypeDiscriminator("setMessages", typeof(commercetools.Api.Models.Subscriptions.SubscriptionSetMessagesAction))]
    public partial interface ISubscriptionUpdateAction 
    {
        string Action { get; set;}
    }
}
