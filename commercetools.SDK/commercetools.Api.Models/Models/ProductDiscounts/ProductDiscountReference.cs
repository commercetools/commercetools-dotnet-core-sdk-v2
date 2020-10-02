using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DiscriminatorValue("product-discount")]
    public partial class ProductDiscountReference : Reference
    {
        public ProductDiscount Obj { get; set;}
        public ProductDiscountReference()
        { 
           this.TypeId = "product-discount";
        }
    }
}
