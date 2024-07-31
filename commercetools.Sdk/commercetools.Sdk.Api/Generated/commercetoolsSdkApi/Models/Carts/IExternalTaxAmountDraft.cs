using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.ExternalTaxAmountDraft))]
    public partial interface IExternalTaxAmountDraft
    {
        IMoney TotalGross { get; set; }

        IExternalTaxRateDraft TaxRate { get; set; }

    }
}
