using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [Discriminator(nameof(Type))]
    public abstract class FacetResult 
    {
        public string Type { get; set;}
        
        public FacetTypes TypeAsEnum => this.Type.GetEnum<FacetTypes>();
    }
}
