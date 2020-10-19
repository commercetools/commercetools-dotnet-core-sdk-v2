using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Carts
{
    public partial class TaxedPriceDraft 
    {
        public TypedMoneyDraft TotalNet { get; set;}
        
        public TypedMoneyDraft TotalGross { get; set;}
        
        public List<TaxPortionDraft> TaxPortions { get; set;}
    }
}
