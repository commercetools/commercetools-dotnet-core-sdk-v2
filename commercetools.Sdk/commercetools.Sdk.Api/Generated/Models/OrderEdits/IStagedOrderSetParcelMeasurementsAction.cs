using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetParcelMeasurementsAction))]
    public partial interface IStagedOrderSetParcelMeasurementsAction : IStagedOrderUpdateAction
    {
        string ParcelId { get; set; }

        IParcelMeasurements Measurements { get; set; }
    }
}
