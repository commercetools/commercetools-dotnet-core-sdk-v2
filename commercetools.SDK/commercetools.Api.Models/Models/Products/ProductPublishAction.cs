using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("publish")]
    public class ProductPublishAction : ProductUpdateAction
    {
        public string Scope { get; set;}
        
        public ProductPublishScope ScopeAsEnum => this.Scope.GetEnum<ProductPublishScope>();
    }
}
