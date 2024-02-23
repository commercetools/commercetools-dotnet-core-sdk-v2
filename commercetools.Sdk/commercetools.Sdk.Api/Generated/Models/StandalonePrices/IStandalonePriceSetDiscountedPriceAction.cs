using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.StandalonePrices
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetDiscountedPriceAction))]
    public partial interface IStandalonePriceSetDiscountedPriceAction : IStandalonePriceUpdateAction
    {
        IDiscountedPriceDraft Discounted { get; set; }

    }
}
