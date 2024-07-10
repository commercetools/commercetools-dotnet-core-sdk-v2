using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchFacetRangesFacetRange))]
    public partial interface IProductSearchFacetRangesFacetRange
    {
        Object From { get; set; }

        Object To { get; set; }

        string Key { get; set; }

    }
}
