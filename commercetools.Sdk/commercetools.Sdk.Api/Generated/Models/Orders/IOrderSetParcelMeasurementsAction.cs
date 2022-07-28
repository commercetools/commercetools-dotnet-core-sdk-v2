using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSetParcelMeasurementsAction))]
    public partial interface IOrderSetParcelMeasurementsAction : IOrderUpdateAction
    {
        string ParcelId { get; set; }

        IParcelMeasurements Measurements { get; set; }

    }
}
