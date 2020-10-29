using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public partial class TaxedPriceDraft : ITaxedPriceDraft
    {
        public ITypedMoneyDraft TotalNet { get; set;}
        
        public ITypedMoneyDraft TotalGross { get; set;}
        
        public List<ITaxPortionDraft> TaxPortions { get; set;}
    }
}
