using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionProductPagedQueryResponse))]
    public partial interface IProductSelectionProductPagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        IList<IAssignedProductReference> Results { get; set; }

        IEnumerable<IAssignedProductReference> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
