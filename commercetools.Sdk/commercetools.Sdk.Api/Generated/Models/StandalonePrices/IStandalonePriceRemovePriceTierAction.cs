using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.StandalonePrices
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceRemovePriceTierAction))]
    public partial interface IStandalonePriceRemovePriceTierAction : IStandalonePriceUpdateAction
    {
        long TierMinimumQuantity { get; set; }

    }
}
