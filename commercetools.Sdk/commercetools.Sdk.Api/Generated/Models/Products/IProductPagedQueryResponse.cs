using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductPagedQueryResponse))]
    public partial interface IProductPagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        IList<IProduct> Results { get; set; }
        IEnumerable<IProduct> ResultsEnumerable { set => Results = value.ToList(); }


    }
}
