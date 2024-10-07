using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class TaxedPriceDraft : ITaxedPriceDraft
    {
        public IMoney TotalNet { get; set; }

        public IMoney TotalGross { get; set; }

        public IList<ITaxPortionDraft> TaxPortions { get; set; }

        public IEnumerable<ITaxPortionDraft> TaxPortionsEnumerable { set => TaxPortions = value.ToList(); }

        public ITypedMoneyDraft TotalTax { get; set; }
    }
}
