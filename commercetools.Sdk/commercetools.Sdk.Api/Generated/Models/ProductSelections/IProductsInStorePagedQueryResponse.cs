using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductSelections.ProductsInStorePagedQueryResponse))]
    public partial interface IProductsInStorePagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        List<IProductSelectionAssignment> Results { get; set; }
    }
}
