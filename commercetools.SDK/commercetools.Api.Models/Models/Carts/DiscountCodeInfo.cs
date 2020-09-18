using commercetools.Api.Models.Carts;
using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public class DiscountCodeInfo 
    {
        public DiscountCodeReference DiscountCode { get; set;}
        
        public string State { get; set;}
        
        public DiscountCodeState StateAsEnum => this.State.GetEnum<DiscountCodeState>();
    }
}
