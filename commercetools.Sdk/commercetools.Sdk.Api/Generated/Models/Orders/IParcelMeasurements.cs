using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.ParcelMeasurements))]
    public partial interface IParcelMeasurements
    {
        double? HeightInMillimeter { get; set; }

        double? LengthInMillimeter { get; set; }

        double? WidthInMillimeter { get; set; }

        double? WeightInGram { get; set; }
    }
}
