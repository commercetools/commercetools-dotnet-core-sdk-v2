using commercetools.Api.Generated.Models.Carts;
using commercetools.Api.Generated.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Carts
{
    public interface ITaxedPrice 
    {
        ITypedMoney TotalNet { get; set;}
        
        ITypedMoney TotalGross { get; set;}
        
        List<ITaxPortion> TaxPortions { get; set;}
    }
}
