using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public partial class DiscountedLineItemPortion 
    {
        public CartDiscountReference Discount { get; set;}
        
        public TypedMoney DiscountedAmount { get; set;}
    }
}
