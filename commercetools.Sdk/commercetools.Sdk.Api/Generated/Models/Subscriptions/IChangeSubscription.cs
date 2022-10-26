using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.ChangeSubscription))]
    public partial interface IChangeSubscription
    {
        IChangeSubscriptionResourceTypeId ResourceTypeId { get; set; }

    }
}
