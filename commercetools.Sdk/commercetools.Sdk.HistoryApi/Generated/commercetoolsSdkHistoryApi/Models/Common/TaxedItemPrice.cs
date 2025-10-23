using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class TaxedItemPrice : ITaxedItemPrice
    {
        public ICentPrecisionMoney TotalNet { get; set; }

        public ICentPrecisionMoney TotalGross { get; set; }

        public IList<ITaxPortion> TaxPortions { get; set; }

        public IEnumerable<ITaxPortion> TaxPortionsEnumerable { set => TaxPortions = value.ToList(); }

        public ICentPrecisionMoney TotalTax { get; set; }
    }
}
