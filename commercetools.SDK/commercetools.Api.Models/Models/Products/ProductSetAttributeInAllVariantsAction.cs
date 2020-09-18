using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("setAttributeInAllVariants")]
    public class ProductSetAttributeInAllVariantsAction : ProductUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
        
        public bool Staged { get; set;}
    }
}
