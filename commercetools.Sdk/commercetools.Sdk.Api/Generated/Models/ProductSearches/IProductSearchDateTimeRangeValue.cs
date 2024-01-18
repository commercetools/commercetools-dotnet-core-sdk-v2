using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchDateTimeRangeValue))]
    public partial interface IProductSearchDateTimeRangeValue : IProductSearchQueryExpressionValue
    {
        DateTime? Gte { get; set; }

        DateTime? Gt { get; set; }

        DateTime? Lte { get; set; }

        DateTime? Lt { get; set; }

    }
}
