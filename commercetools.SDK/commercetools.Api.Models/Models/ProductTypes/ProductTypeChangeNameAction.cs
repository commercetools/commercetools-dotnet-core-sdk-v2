using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("changeName")]
    public class ProductTypeChangeNameAction : ProductTypeUpdateAction
    {
        public string Name { get; set;}
    }
}
