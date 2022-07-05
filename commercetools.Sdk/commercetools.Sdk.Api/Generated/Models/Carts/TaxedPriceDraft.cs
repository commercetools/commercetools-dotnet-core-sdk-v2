using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class TaxedPriceDraft : ITaxedPriceDraft
    {
        public IMoney TotalNet { get; set; }

        public IMoney TotalGross { get; set; }

        public List<ITaxPortionDraft> TaxPortions { get; set; }
    }
}
