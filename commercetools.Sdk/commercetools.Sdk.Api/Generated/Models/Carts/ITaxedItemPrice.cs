using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.TaxedItemPrice))]
    public partial interface ITaxedItemPrice 
    {
        ITypedMoney TotalNet { get; set;}
        
        ITypedMoney TotalGross { get; set;}
    }
}
