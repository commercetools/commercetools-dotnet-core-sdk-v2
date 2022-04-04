using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.ExternalTaxAmountDraft))]
    public partial interface IExternalTaxAmountDraft
    {
        IMoney TotalGross { get; set; }

        IExternalTaxRateDraft TaxRate { get; set; }
    }
}
