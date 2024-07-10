using commercetools.Sdk.Api.Models.ProductSearches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchMatchingVariants))]
    public partial interface IProductSearchMatchingVariants
    {
        bool AllMatched { get; set; }

        IList<IProductSearchMatchingVariantEntry> MatchedVariants { get; set; }
        IEnumerable<IProductSearchMatchingVariantEntry> MatchedVariantsEnumerable { set => MatchedVariants = value.ToList(); }


    }
}
