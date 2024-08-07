using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetParcelMeasurementsAction))]
    public partial interface IStagedOrderSetParcelMeasurementsAction : IStagedOrderUpdateAction
    {
        string ParcelId { get; set; }

        string ParcelKey { get; set; }

        IParcelMeasurements Measurements { get; set; }

    }
}
