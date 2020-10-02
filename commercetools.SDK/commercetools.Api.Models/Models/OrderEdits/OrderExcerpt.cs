using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class OrderExcerpt 
    {
        public TypedMoney TotalPrice { get; set;}
        
        public TaxedPrice TaxedPrice { get; set;}
        
        public int Version { get; set;}
    }
}
