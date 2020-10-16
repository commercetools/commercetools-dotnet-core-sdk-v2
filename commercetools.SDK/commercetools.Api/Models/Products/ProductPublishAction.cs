using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("publish")]
    public partial class ProductPublishAction : ProductUpdateAction
    {
        public string Scope { get; set;}
        
        [JsonIgnore]
        public ProductPublishScope ScopeAsEnum => this.Scope.GetEnum<ProductPublishScope>();
        public ProductPublishAction()
        { 
           this.Action = "publish";
        }
    }
}
