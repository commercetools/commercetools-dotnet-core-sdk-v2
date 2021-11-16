using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ParcelMeasurementsUpdatedMessage))]
    public partial interface IParcelMeasurementsUpdatedMessage : IMessage
    {
        string DeliveryId { get; set; }

        string ParcelId { get; set; }

        IParcelMeasurements Measurements { get; set; }
    }
}
