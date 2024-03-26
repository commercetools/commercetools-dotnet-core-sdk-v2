using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchMatchingVariants : IProductSearchMatchingVariants
    {
        public bool AllMatched { get; set; }

        public IList<IProductSearchMatchingVariantEntry> MatchedVariants { get; set; }
        public IEnumerable<IProductSearchMatchingVariantEntry> MatchedVariantsEnumerable { set => MatchedVariants = value.ToList(); }

    }
}
