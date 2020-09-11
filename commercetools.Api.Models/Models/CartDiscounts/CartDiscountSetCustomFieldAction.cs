using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.CartDiscounts
{
    public class CartDiscountSetCustomFieldAction : CartDiscountUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
    }
}
