using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Subscriptions.SubscriptionSetKeyAction))]
    public partial interface ISubscriptionSetKeyAction : ISubscriptionUpdateAction
    {
        string Key { get; set; }
    }
}
