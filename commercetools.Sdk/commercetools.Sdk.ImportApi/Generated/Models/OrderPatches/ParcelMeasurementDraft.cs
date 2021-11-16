using commercetools.ImportApi.Models.Orders;


namespace commercetools.ImportApi.Models.OrderPatches
{
    public partial class ParcelMeasurementDraft : IParcelMeasurementDraft
    {
        public string ParcelId { get; set; }

        public IParcelMeasurements Measurements { get; set; }
    }
}
