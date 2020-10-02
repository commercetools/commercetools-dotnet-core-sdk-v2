using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DiscriminatorValue("cart-discount")]
    public partial class CartDiscountReference : Reference
    {
        public CartDiscount Obj { get; set;}
        public CartDiscountReference()
        { 
           this.TypeId = "cart-discount";
        }
    }
}
