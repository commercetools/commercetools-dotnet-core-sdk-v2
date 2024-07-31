using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountPagedQueryResponse))]
    public partial interface IProductDiscountPagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        IList<IProductDiscount> Results { get; set; }

        IEnumerable<IProductDiscount> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
