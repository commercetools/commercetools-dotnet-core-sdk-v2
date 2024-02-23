using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.FacetResults))]
    public interface IFacetResults : IDictionary<string, IFacetResult>
    {
    }
}
