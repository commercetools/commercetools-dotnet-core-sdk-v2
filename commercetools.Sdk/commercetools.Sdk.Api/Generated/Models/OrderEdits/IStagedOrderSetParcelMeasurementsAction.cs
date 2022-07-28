using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetParcelMeasurementsAction))]
    public partial interface IStagedOrderSetParcelMeasurementsAction : IStagedOrderUpdateAction
    {
        string ParcelId { get; set; }

        IParcelMeasurements Measurements { get; set; }

    }
}
