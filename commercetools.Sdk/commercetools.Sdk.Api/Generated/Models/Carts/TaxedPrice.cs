using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Carts
{
    public partial class TaxedPrice : ITaxedPrice
    {
        public ITypedMoney TotalNet { get; set; }

        public ITypedMoney TotalGross { get; set; }

        public List<ITaxPortion> TaxPortions { get; set; }
    }
}
