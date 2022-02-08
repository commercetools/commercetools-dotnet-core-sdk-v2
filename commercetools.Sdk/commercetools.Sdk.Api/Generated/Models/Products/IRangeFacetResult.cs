using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.RangeFacetResult))]
    public partial interface IRangeFacetResult : IFacetResult
    {
        List<IFacetRange> Ranges { get; set; }
    }
}
