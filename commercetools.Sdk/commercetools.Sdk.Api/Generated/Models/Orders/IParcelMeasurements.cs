using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.ParcelMeasurements))]
    public partial interface IParcelMeasurements
    {
        decimal? HeightInMillimeter { get; set; }

        decimal? LengthInMillimeter { get; set; }

        decimal? WidthInMillimeter { get; set; }

        decimal? WeightInGram { get; set; }
    }
}
