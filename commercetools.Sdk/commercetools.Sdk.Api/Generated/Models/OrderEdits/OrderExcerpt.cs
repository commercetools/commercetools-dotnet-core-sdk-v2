using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public  partial class OrderExcerpt : IOrderExcerpt
    {
        public ITypedMoney TotalPrice { get; set;}
        
        public ITaxedPrice TaxedPrice { get; set;}
        
        public int Version { get; set;}
    }
}
