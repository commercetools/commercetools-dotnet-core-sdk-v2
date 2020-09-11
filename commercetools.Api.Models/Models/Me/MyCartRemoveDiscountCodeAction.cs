using commercetools.Api.Models.DiscountCodes;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Me
{
    public class MyCartRemoveDiscountCodeAction : MyCartUpdateAction
    {
        public DiscountCodeReference DiscountCode { get; set;}
    }
}
