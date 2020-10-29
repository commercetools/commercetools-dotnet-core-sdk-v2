using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.TaxedPrice))]
    public interface ITaxedPrice 
    {
        ITypedMoney TotalNet { get; set;}
        
        ITypedMoney TotalGross { get; set;}
        
        List<ITaxPortion> TaxPortions { get; set;}
    }
}
