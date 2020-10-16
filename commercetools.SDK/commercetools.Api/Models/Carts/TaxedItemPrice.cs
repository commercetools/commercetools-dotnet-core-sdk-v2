using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Carts
{
    public partial class TaxedItemPrice 
    {
        public TypedMoney TotalNet { get; set;}
        
        public TypedMoney TotalGross { get; set;}
    }
}
