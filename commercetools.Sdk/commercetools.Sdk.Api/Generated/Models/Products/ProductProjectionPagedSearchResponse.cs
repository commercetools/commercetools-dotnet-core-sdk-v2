using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductProjectionPagedSearchResponse : IProductProjectionPagedSearchResponse
    {
        public long Limit { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public long Offset { get; set; }

        public IList<IProductProjection> Results { get; set; }
        public IEnumerable<IProductProjection> ResultsEnumerable { set => Results = value.ToList(); }


        public IFacetResults Facets { get; set; }
    }
}
