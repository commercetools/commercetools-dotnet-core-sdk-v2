using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.StandalonePrices
{

    public partial class StagedPriceDraft : IStagedPriceDraft
    {
        public ITypedMoneyDraft Value { get; set; }
    }
}
