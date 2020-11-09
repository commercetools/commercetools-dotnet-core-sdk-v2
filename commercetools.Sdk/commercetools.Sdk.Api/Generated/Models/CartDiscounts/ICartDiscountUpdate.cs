using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.CartDiscounts.CartDiscountUpdate))]
    public partial interface ICartDiscountUpdate 
    {
        long Version { get; set;}
        
        List<ICartDiscountUpdateAction> Actions { get; set;}
    }
}
