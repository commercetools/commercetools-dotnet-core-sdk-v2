using commercetools.Sdk.Api.Models.ProductSearches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductPagedSearchResponse : IProductPagedSearchResponse
    {
        public long Total { get; set; }

        public int Offset { get; set; }

        public int Limit { get; set; }

        public IList<IProductSearchFacetResult> Facets { get; set; }
        public IEnumerable<IProductSearchFacetResult> FacetsEnumerable { set => Facets = value.ToList(); }


        public IList<IProductSearchResult> Results { get; set; }
        public IEnumerable<IProductSearchResult> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
