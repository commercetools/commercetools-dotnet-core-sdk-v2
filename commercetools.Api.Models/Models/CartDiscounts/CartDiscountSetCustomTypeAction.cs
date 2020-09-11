using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.CartDiscounts
{
    public class CartDiscountSetCustomTypeAction : CartDiscountUpdateAction
    {
        public TypeResourceIdentifier Type { get; set;}
        
        public Object Fields { get; set;}
    }
}
