using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Orders.ParcelMeasurements))]
    public partial interface IParcelMeasurements
    {
        decimal? HeightInMillimeter { get; set; }

        decimal? LengthInMillimeter { get; set; }

        decimal? WidthInMillimeter { get; set; }

        decimal? WeightInGram { get; set; }

    }
}
