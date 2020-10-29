using commercetools.Api.Models.Carts;
using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.DiscountCodeInfo))]
    public interface IDiscountCodeInfo 
    {
        IDiscountCodeReference DiscountCode { get; set;}
        
        string State { get; set;}
        
        DiscountCodeState StateAsEnum { get; }
    }
}
