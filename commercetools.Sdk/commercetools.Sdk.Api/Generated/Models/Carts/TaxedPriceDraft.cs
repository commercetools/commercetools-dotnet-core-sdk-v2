using commercetools.Api.Models.Common;
using System.Collections.Generic;


namespace commercetools.Api.Models.Carts
{
    public partial class TaxedPriceDraft : ITaxedPriceDraft
    {
        public IMoney TotalNet { get; set;}
        
        public IMoney TotalGross { get; set;}
        
        public List<ITaxPortionDraft> TaxPortions { get; set;}
    }
}
