namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSetParcelMeasurementsAction : IOrderSetParcelMeasurementsAction
    {
        public string Action { get; set; }

        public string ParcelId { get; set; }

        public IParcelMeasurements Measurements { get; set; }
        public OrderSetParcelMeasurementsAction()
        {
            this.Action = "setParcelMeasurements";
        }
    }
}
