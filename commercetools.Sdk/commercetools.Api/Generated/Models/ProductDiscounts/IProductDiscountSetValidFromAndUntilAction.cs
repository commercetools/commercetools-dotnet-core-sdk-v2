using commercetools.Api.Generated.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.ProductDiscounts
{
    public interface IProductDiscountSetValidFromAndUntilAction : IProductDiscountUpdateAction
    {
        DateTime ValidFrom { get; set;}
        
        DateTime ValidUntil { get; set;}
    }
}
