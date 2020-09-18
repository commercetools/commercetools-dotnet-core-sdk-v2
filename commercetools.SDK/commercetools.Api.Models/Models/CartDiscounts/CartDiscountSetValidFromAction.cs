using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DiscriminatorValue("setValidFrom")]
    public class CartDiscountSetValidFromAction : CartDiscountUpdateAction
    {
        public DateTime ValidFrom { get; set;}
    }
}
