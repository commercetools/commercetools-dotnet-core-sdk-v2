using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.RangeFacetResult))]
    public partial interface IRangeFacetResult : IFacetResult
    {
        List<IFacetRange> Ranges { get; set; }
    }
}
