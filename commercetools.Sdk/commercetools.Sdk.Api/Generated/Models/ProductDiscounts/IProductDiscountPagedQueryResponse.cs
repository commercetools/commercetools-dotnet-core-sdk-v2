using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountPagedQueryResponse))]
    public partial interface IProductDiscountPagedQueryResponse
    {
        long Limit { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        long Offset { get; set; }

        List<IProductDiscount> Results { get; set; }
    }
}
