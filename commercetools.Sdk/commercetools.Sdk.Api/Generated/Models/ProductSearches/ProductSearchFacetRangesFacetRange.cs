using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchFacetRangesFacetRange : IProductSearchFacetRangesFacetRange
    {
        public Object From { get; set; }

        public Object To { get; set; }

        public string Key { get; set; }
    }
}
