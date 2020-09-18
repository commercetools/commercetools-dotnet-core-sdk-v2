using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DiscriminatorValue("setValidFromAndUntil")]
    public class ProductDiscountSetValidFromAndUntilAction : ProductDiscountUpdateAction
    {
        public DateTime ValidFrom { get; set;}
        
        public DateTime ValidUntil { get; set;}
    }
}
