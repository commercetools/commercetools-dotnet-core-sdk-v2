using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Subscriptions.PlatformFormat))]
    public partial interface IPlatformFormat : IDeliveryFormat
    {
    }
}
