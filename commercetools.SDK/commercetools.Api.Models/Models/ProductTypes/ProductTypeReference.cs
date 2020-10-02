using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("product-type")]
    public partial class ProductTypeReference : Reference
    {
        public ProductType Obj { get; set;}
        public ProductTypeReference()
        { 
           this.TypeId = "product-type";
        }
    }
}
