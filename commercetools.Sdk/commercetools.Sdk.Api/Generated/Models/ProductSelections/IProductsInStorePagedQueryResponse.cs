using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductsInStorePagedQueryResponse))]
    public partial interface IProductsInStorePagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        IList<IProductSelectionAssignment> Results { get; set; }
        IEnumerable<IProductSelectionAssignment> ResultsEnumerable { set => Results = value.ToList(); }


    }
}
