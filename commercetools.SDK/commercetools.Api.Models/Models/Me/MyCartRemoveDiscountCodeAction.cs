using commercetools.Api.Models.DiscountCodes;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("removeDiscountCode")]
    public class MyCartRemoveDiscountCodeAction : MyCartUpdateAction
    {
        public DiscountCodeReference DiscountCode { get; set;}
    }
}
