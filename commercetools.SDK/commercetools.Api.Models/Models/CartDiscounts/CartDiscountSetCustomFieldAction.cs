using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DiscriminatorValue("setCustomField")]
    public class CartDiscountSetCustomFieldAction : CartDiscountUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
    }
}
