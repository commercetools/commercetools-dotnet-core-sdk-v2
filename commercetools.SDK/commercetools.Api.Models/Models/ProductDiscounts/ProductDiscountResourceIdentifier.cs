using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DiscriminatorValue("product-discount")]
    public partial class ProductDiscountResourceIdentifier : ResourceIdentifier
    {
        public ProductDiscountResourceIdentifier()
        { 
           this.TypeId = "product-discount";
        }
    }
}
