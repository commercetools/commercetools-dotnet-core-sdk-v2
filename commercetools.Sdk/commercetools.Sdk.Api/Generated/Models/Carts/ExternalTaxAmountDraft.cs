using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class ExternalTaxAmountDraft : IExternalTaxAmountDraft
    {
        public IMoney TotalGross { get; set; }

        public IExternalTaxRateDraft TaxRate { get; set; }
    }
}
