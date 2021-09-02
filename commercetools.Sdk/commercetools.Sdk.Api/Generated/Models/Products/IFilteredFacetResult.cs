using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.FilteredFacetResult))]
    public partial interface IFilteredFacetResult : IFacetResult
    {
        long Count { get; set; }

        long? ProductCount { get; set; }
    }
}
