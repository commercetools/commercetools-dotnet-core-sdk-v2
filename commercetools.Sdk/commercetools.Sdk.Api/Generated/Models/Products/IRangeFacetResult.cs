using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.RangeFacetResult))]
    public partial interface IRangeFacetResult : IFacetResult
    {
        List<IFacetResultRange> Ranges { get; set;}
    }
}
