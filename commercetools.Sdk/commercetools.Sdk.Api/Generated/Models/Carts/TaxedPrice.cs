using commercetools.Api.Models.Common;
using System.Collections.Generic;


namespace commercetools.Api.Models.Carts
{
    public partial class TaxedPrice : ITaxedPrice
    {
        public ITypedMoney TotalNet { get; set;}
        
        public ITypedMoney TotalGross { get; set;}
        
        public List<ITaxPortion> TaxPortions { get; set;}
    }
}
