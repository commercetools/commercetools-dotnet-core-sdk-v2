using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.ExternalTaxAmountDraft))]
    public partial interface IExternalTaxAmountDraft
    {
        IMoney TotalGross { get; set; }

        IExternalTaxRateDraft TaxRate { get; set; }
    }
}
