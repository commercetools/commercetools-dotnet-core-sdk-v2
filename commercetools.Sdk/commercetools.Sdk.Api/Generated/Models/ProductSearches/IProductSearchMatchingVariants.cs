using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

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
