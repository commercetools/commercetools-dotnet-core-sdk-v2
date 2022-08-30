using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ParcelMeasurementsUpdatedMessagePayload))]
    public partial interface IParcelMeasurementsUpdatedMessagePayload : IOrderMessagePayload
    {
        string DeliveryId { get; set; }

        string ParcelId { get; set; }

        IParcelMeasurements Measurements { get; set; }

        string ShippingKey { get; set; }

    }
}
