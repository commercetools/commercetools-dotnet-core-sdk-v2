using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DiscriminatorValue("changeTarget")]
    public class CartDiscountChangeTargetAction : CartDiscountUpdateAction
    {
        public CartDiscountTarget Target { get; set;}
    }
}
