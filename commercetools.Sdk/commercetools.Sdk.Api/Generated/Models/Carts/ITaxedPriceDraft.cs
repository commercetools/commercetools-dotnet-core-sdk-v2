using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.TaxedPriceDraft))]
    public partial interface ITaxedPriceDraft
    {
        IMoney TotalNet { get; set; }

        IMoney TotalGross { get; set; }

        List<ITaxPortionDraft> TaxPortions { get; set; }
    }
}
