using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public partial class DiscountedLineItemPriceForQuantity 
    {
        public double Quantity { get; set;}
        
        public DiscountedLineItemPrice DiscountedPrice { get; set;}
    }
}
