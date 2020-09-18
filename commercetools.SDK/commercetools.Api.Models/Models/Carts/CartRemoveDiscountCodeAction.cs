using commercetools.Api.Models.Carts;
using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("removeDiscountCode")]
    public class CartRemoveDiscountCodeAction : CartUpdateAction
    {
        public DiscountCodeReference DiscountCode { get; set;}
    }
}
