using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    public partial class CartDiscountUpdate 
    {
        public long Version { get; set;}
        
        public List<CartDiscountUpdateAction> Actions { get; set;}
    }
}
