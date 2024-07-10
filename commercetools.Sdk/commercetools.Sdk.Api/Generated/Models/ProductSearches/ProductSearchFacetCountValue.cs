using commercetools.Sdk.Api.Models.ProductSearches;
using commercetools.Sdk.Api.Models.Searches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchFacetCountValue : IProductSearchFacetCountValue
    {
        public string Name { get; set; }

        public IProductSearchFacetScopeEnum Scope { get; set; }

        public ISearchQuery Filter { get; set; }

        public IProductSearchFacetCountLevelEnum Level { get; set; }
    }
}
