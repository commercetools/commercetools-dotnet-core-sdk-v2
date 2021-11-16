using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Subscriptions.DeliveryCloudEventsFormat))]
    public partial interface IDeliveryCloudEventsFormat : IDeliveryFormat
    {
        string CloudEventsVersion { get; set;}
    }
}
