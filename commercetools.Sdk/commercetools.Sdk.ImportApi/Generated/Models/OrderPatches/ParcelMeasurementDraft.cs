using commercetools.Sdk.ImportApi.Models.Orders;


namespace commercetools.Sdk.ImportApi.Models.OrderPatches
{
    public partial class ParcelMeasurementDraft : IParcelMeasurementDraft
    {
        public string ParcelId { get; set; }

        public IParcelMeasurements Measurements { get; set; }
    }
}
