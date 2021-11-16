using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.FacetResults))]
    public interface IFacetResults : IDictionary<string, IFacetResult>
    {
    }
}
