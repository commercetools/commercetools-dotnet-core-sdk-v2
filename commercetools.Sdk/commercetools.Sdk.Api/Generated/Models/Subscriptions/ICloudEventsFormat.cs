using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.CloudEventsFormat))]
    public partial interface ICloudEventsFormat : IDeliveryFormat
    {
        string CloudEventsVersion { get; set; }

    }
}
