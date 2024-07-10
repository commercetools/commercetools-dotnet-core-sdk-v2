using commercetools.Sdk.Api.Models.ProductSelections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductSelections
{

    public partial class ProductSelectionPagedQueryResponse : IProductSelectionPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<IProductSelection> Results { get; set; }
        public IEnumerable<IProductSelection> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
