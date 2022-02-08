using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Subscriptions.CloudEventsFormat))]
    public partial interface ICloudEventsFormat : IDeliveryFormat
    {
        string CloudEventsVersion { get; set; }
    }
}
