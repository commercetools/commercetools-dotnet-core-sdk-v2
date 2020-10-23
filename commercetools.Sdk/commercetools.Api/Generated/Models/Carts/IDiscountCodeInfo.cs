using commercetools.Api.Generated.Models.Carts;
using commercetools.Api.Generated.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Carts
{
    public interface IDiscountCodeInfo 
    {
        IDiscountCodeReference DiscountCode { get; set;}
        
        string State { get; set;}
        
        DiscountCodeState StateAsEnum { get; }
    }
}
