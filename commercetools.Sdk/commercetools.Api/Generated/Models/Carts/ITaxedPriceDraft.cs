using commercetools.Api.Generated.Models.Carts;
using commercetools.Api.Generated.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Carts
{
    public interface ITaxedPriceDraft 
    {
        ITypedMoneyDraft TotalNet { get; set;}
        
        ITypedMoneyDraft TotalGross { get; set;}
        
        List<ITaxPortionDraft> TaxPortions { get; set;}
    }
}
