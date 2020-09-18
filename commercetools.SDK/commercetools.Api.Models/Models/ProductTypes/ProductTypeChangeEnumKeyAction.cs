using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("changeEnumKey")]
    public class ProductTypeChangeEnumKeyAction : ProductTypeUpdateAction
    {
        public string AttributeName { get; set;}
        
        public string Key { get; set;}
        
        public string NewKey { get; set;}
    }
}
