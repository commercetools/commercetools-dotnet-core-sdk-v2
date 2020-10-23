using commercetools.Api.Generated.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Products
{
    public interface IRangeFacetResult : IFacetResult
    {
        List<IFacetResultRange> Ranges { get; set;}
    }
}
