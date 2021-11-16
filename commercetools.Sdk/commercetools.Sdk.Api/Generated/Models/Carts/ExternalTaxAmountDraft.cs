using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Carts
{
    public partial class ExternalTaxAmountDraft : IExternalTaxAmountDraft
    {
        public IMoney TotalGross { get; set;}
        
        public IExternalTaxRateDraft TaxRate { get; set;}
    }
}
