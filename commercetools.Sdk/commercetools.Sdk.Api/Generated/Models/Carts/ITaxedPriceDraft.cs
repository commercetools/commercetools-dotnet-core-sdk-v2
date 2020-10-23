using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.TaxedPriceDraft))]
    public interface ITaxedPriceDraft 
    {
        ITypedMoneyDraft TotalNet { get; set;}
        
        ITypedMoneyDraft TotalGross { get; set;}
        
        List<ITaxPortionDraft> TaxPortions { get; set;}
    }
}
