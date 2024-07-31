using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.ParcelMeasurements))]
    public partial interface IParcelMeasurements
    {
        int? HeightInMillimeter { get; set; }

        int? LengthInMillimeter { get; set; }

        int? WidthInMillimeter { get; set; }

        int? WeightInGram { get; set; }

    }
}
