using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.SubscriptionSetKeyAction))]
    public partial interface ISubscriptionSetKeyAction : ISubscriptionUpdateAction
    {
        string Key { get; set; }

    }
}
