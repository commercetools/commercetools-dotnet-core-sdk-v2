using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.TermFacetResult))]
    public partial interface ITermFacetResult : IFacetResult
    {
        ITermFacetResultType DataType { get; set; }

        long Missing { get; set; }

        long Total { get; set; }

        long Other { get; set; }

        IList<IFacetTerm> Terms { get; set; }

        IEnumerable<IFacetTerm> TermsEnumerable { set => Terms = value.ToList(); }

    }
}
