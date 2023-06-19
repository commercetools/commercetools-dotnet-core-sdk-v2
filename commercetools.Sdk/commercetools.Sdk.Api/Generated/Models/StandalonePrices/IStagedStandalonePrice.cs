using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.StandalonePrices
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StandalonePrices.StagedStandalonePrice))]
    public partial interface IStagedStandalonePrice
    {
        ITypedMoney Value { get; set; }

        IDiscountedPrice Discounted { get; set; }

    }
}
