using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.ParcelMeasurements))]
    public partial interface IParcelMeasurements
    {
        double? HeightInMillimeter { get; set; }

        double? LengthInMillimeter { get; set; }

        double? WidthInMillimeter { get; set; }

        double? WeightInGram { get; set; }
    }
}
