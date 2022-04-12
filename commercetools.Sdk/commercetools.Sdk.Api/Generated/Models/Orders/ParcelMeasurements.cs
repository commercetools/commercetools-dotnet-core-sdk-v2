namespace commercetools.Sdk.Api.Models.Orders
{
    public partial class ParcelMeasurements : IParcelMeasurements
    {
        public decimal? HeightInMillimeter { get; set; }

        public decimal? LengthInMillimeter { get; set; }

        public decimal? WidthInMillimeter { get; set; }

        public decimal? WeightInGram { get; set; }
    }
}
