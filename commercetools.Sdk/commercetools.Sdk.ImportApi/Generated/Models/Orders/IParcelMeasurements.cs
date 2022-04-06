using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Orders.ParcelMeasurements))]
    public partial interface IParcelMeasurements
    {
        double? HeightInMillimeter { get; set; }

        double? LengthInMillimeter { get; set; }

        double? WidthInMillimeter { get; set; }

        double? WeightInGram { get; set; }
    }
}
