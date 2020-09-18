using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("addDiscountCode")]
    public class CartAddDiscountCodeAction : CartUpdateAction
    {
        public string Code { get; set;}
    }
}
