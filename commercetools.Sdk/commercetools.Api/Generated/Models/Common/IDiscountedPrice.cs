using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Common
{
    public interface IDiscountedPrice 
    {
        IMoney Value { get; set;}
        
        IProductDiscountReference Discount { get; set;}
    }
}
