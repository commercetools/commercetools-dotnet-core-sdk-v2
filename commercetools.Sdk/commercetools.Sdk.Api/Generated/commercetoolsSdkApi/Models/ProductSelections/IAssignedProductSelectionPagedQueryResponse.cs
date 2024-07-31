using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.AssignedProductSelectionPagedQueryResponse))]
    public partial interface IAssignedProductSelectionPagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        IList<IAssignedProductSelection> Results { get; set; }

        IEnumerable<IAssignedProductSelection> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
