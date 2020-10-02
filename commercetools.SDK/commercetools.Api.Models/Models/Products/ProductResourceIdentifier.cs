using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("product")]
    public partial class ProductResourceIdentifier : ResourceIdentifier
    {
        public ProductResourceIdentifier()
        { 
           this.TypeId = "product";
        }
    }
}
