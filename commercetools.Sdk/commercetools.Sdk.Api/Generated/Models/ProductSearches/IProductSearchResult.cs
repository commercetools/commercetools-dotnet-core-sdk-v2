using commercetools.Sdk.Api.Models.ProductSearches;
using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchResult))]
    public partial interface IProductSearchResult
    {
        string Id { get; set; }

        IProductProjection ProductProjection { get; set; }

        IProductSearchMatchingVariants MatchingVariants { get; set; }

    }
}
