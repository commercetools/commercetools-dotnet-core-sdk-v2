namespace commercetools.ImportApi.Models.Orders
{
    public partial class ParcelMeasurements : IParcelMeasurements
    {
        public double? HeightInMillimeter { get; set;}
        
        public double? LengthInMillimeter { get; set;}
        
        public double? WidthInMillimeter { get; set;}
        
        public double? WeightInGram { get; set;}
    }
}
