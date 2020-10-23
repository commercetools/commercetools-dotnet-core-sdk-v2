using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public  partial class TaxedItemPrice : ITaxedItemPrice
    {
        public ITypedMoney TotalNet { get; set;}
        
        public ITypedMoney TotalGross { get; set;}
    }
}
