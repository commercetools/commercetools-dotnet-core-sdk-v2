using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchFullTextValue))]
    public partial interface IProductSearchFullTextValue : IProductSearchQueryExpressionValue
    {
        Object Value { get; set; }

        string Language { get; set; }

        IProductSearchMatchType MustMatch { get; set; }

    }
}
