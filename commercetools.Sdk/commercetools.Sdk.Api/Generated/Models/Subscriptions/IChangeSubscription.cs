using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Subscriptions.ChangeSubscription))]
    public partial interface IChangeSubscription
    {
        string ResourceTypeId { get; set; }
    }
}
