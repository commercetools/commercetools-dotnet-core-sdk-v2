using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DiscriminatorValue("setValidUntil")]
    public class ProductDiscountSetValidUntilAction : ProductDiscountUpdateAction
    {
        public DateTime ValidUntil { get; set;}
    }
}
