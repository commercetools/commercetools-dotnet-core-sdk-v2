using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DiscriminatorValue("absolute")]
    public class ProductDiscountValueAbsolute : ProductDiscountValue
    {
        public List<TypedMoney> Money { get; set;}
    }
}
