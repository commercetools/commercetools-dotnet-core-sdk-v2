using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DiscriminatorValue("shipping")]
    public partial class CartDiscountShippingCostTarget : CartDiscountTarget
    {
        public CartDiscountShippingCostTarget()
        { 
           this.Type = "shipping";
        }
    }
}
