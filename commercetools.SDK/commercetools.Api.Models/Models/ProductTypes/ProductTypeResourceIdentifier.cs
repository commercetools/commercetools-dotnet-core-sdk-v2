using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("product-type")]
    public partial class ProductTypeResourceIdentifier : ResourceIdentifier
    {
        public ProductTypeResourceIdentifier()
        { 
           this.TypeId = "product-type";
        }
    }
}
