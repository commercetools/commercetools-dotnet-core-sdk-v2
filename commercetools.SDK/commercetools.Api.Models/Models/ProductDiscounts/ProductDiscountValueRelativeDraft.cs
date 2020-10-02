using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DiscriminatorValue("relative")]
    public partial class ProductDiscountValueRelativeDraft : ProductDiscountValueDraft
    {
        public long Permyriad { get; set;}
        public ProductDiscountValueRelativeDraft()
        { 
           this.Type = "relative";
        }
    }
}
