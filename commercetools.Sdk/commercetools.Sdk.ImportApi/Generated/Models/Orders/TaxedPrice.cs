using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.ImportApi.Models.Orders
{

    public partial class TaxedPrice : ITaxedPrice
    {
        public IMoney TotalNet { get; set; }

        public IMoney TotalGross { get; set; }

        public IList<ITaxPortion> TaxPortions { get; set; }
        public IEnumerable<ITaxPortion> TaxPortionsEnumerable { set => TaxPortions = value.ToList(); }

    }
}
