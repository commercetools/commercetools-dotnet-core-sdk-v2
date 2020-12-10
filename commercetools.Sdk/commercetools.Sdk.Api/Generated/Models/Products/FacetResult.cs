using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public abstract partial class FacetResult : IFacetResult
    {
        public IFacetTypes Type { get; set;}
    }
}
