using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("setKey")]
    public class ProductSetKeyAction : ProductUpdateAction
    {
        public string Key { get; set;}
    }
}
