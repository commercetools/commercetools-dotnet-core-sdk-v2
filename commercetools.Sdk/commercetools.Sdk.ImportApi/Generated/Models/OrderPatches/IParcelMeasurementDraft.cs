using commercetools.Sdk.ImportApi.Models.Orders;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.OrderPatches
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.OrderPatches.ParcelMeasurementDraft))]
    public partial interface IParcelMeasurementDraft
    {
        string ParcelId { get; set; }

        IParcelMeasurements Measurements { get; set; }

    }
}
