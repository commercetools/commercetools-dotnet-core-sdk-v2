using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DiscriminatorValue("setDescription")]
    public class ProductDiscountSetDescriptionAction : ProductDiscountUpdateAction
    {
        public LocalizedString Description { get; set;}
    }
}
