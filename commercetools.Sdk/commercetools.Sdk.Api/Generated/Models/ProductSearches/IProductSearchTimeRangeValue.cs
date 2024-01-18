using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchTimeRangeValue))]
    public partial interface IProductSearchTimeRangeValue : IProductSearchQueryExpressionValue
    {
        TimeSpan? Gte { get; set; }

        TimeSpan? Gt { get; set; }

        TimeSpan? Lte { get; set; }

        TimeSpan? Lt { get; set; }

    }
}
