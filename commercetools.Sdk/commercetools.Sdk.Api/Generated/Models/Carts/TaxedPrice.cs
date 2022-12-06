using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class TaxedPrice : ITaxedPrice
    {
        public ITypedMoney TotalNet { get; set; }

        public ITypedMoney TotalGross { get; set; }

        public IList<ITaxPortion> TaxPortions { get; set; }
        public IEnumerable<ITaxPortion> TaxPortionsEnumerable { set => TaxPortions = value.ToList(); }


        public ITypedMoney TotalTax { get; set; }
    }
}
