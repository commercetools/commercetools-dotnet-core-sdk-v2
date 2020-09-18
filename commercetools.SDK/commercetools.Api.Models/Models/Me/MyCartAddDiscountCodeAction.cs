using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("addDiscountCode")]
    public class MyCartAddDiscountCodeAction : MyCartUpdateAction
    {
        public string Code { get; set;}
    }
}
