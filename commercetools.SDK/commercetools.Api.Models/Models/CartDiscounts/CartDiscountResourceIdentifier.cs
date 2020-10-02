using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DiscriminatorValue("cart-discount")]
    public partial class CartDiscountResourceIdentifier : ResourceIdentifier
    {
        public CartDiscountResourceIdentifier()
        { 
           this.TypeId = "cart-discount";
        }
    }
}
