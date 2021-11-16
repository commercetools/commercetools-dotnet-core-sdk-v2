using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Api.Models.Common.DiscountedPriceDraft))]
    public partial interface IDiscountedPriceDraft 
    {
        IMoney Value { get; set;}
        
        IProductDiscountReference Discount { get; set;}
    }
}
