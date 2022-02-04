using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductSelections.AssignedProductSelectionPagedQueryResponse))]
    public partial interface IAssignedProductSelectionPagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        List<IAssignedProductSelection> Results { get; set; }
    }
}
