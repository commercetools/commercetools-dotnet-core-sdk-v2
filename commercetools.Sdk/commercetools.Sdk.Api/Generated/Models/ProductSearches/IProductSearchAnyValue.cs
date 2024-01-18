using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchAnyValue))]
    public partial interface IProductSearchAnyValue : IProductSearchQueryExpressionValue
    {
        Object Value { get; set; }

        string Language { get; set; }

        bool? CaseInsensitive { get; set; }

    }
}
