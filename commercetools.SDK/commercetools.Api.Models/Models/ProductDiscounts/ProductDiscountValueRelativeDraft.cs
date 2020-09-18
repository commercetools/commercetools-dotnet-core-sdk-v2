using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DiscriminatorValue("relative")]
    public class ProductDiscountValueRelativeDraft : ProductDiscountValueDraft
    {
        public long Permyriad { get; set;}
    }
}
