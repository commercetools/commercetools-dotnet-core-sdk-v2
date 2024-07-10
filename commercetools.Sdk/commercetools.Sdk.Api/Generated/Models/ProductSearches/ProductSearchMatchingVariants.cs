using commercetools.Sdk.Api.Models.ProductSearches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchMatchingVariants : IProductSearchMatchingVariants
    {
        public bool AllMatched { get; set; }

        public IList<IProductSearchMatchingVariantEntry> MatchedVariants { get; set; }
        public IEnumerable<IProductSearchMatchingVariantEntry> MatchedVariantsEnumerable { set => MatchedVariants = value.ToList(); }

    }
}
