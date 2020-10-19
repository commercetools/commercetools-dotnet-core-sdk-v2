using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("setAttributeInAllVariants")]
    public partial class ProductSetAttributeInAllVariantsAction : ProductUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
        
        public bool Staged { get; set;}
        public ProductSetAttributeInAllVariantsAction()
        { 
           this.Action = "setAttributeInAllVariants";
        }
    }
}
