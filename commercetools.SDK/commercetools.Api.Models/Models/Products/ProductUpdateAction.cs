using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [Discriminator(nameof(Action))]
    public abstract class ProductUpdateAction 
    {
        public string Action { get; set;}
    }
}
