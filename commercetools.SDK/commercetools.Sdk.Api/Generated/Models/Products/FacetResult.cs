using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [Discriminator(nameof(Type))]
    public abstract partial class FacetResult 
    {
        public string Type { get; set;}
        
        [JsonIgnore]
        public FacetTypes TypeAsEnum => this.Type.GetEnum<FacetTypes>();
    }
}
