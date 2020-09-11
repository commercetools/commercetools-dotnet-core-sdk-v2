using commercetools.Api.Models.Carts;
using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Carts
{
    public class DiscountCodeInfo 
    {
        public DiscountCodeReference DiscountCode { get; set;}
        
        public DiscountCodeState State { get; set;}
    }
}
