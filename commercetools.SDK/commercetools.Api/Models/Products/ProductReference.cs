using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("product")]
    public partial class ProductReference : Reference
    {
        public Product Obj { get; set;}
        public ProductReference()
        { 
           this.TypeId = "product";
        }
    }
}
