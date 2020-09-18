using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DiscriminatorValue("changeValue")]
    public class ProductDiscountChangeValueAction : ProductDiscountUpdateAction
    {
        public ProductDiscountValueDraft Value { get; set;}
    }
}
