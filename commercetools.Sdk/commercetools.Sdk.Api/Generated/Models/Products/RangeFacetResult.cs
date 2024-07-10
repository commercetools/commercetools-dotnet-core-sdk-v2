using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class RangeFacetResult : IRangeFacetResult
    {
        public IFacetTypes Type { get; set; }

        public IList<IFacetRange> Ranges { get; set; }
        public IEnumerable<IFacetRange> RangesEnumerable { set => Ranges = value.ToList(); }

        public RangeFacetResult()
        {
            this.Type = IFacetTypes.FindEnum("range");
        }
    }
}
