using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.StandalonePrices
{

    public partial class StagedStandalonePrice : IStagedStandalonePrice
    {
        public ITypedMoney Value { get; set; }

        public IDiscountedPrice Discounted { get; set; }
    }
}
