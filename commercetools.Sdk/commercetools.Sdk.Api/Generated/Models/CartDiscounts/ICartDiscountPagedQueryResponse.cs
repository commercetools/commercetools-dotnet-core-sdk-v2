using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountPagedQueryResponse))]
    public partial interface ICartDiscountPagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        IList<ICartDiscount> Results { get; set; }
        IEnumerable<ICartDiscount> ResultsEnumerable { set => Results = value.ToList(); }


    }
}
