using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchFacetResult))]
    public partial interface IProductSearchFacetResult
    {
        IList<IProductSearchFacetResultExpression> Results { get; set; }
        IEnumerable<IProductSearchFacetResultExpression> ResultsEnumerable { set => Results = value.ToList(); }


    }
}
