using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.RangeFacetResult))]
    public partial interface IRangeFacetResult : IFacetResult
    {
        IList<IFacetRange> Ranges { get; set; }
        IEnumerable<IFacetRange> RangesEnumerable { set => Ranges = value.ToList(); }


    }
}
