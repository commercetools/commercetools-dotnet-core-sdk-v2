using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Subscriptions.DeliveryPlatformFormat))]
    public partial interface IDeliveryPlatformFormat : IDeliveryFormat
    {
    }
}
