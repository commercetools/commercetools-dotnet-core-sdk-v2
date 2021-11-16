using commercetools.ImportApi.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.OrderPatches
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.OrderPatches.ParcelMeasurementDraft))]
    public partial interface IParcelMeasurementDraft
    {
        string ParcelId { get; set; }

        IParcelMeasurements Measurements { get; set; }
    }
}
