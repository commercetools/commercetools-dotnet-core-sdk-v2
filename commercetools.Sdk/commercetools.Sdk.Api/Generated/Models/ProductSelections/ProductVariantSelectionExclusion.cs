using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.ProductSelections
{

    public partial class ProductVariantSelectionExclusion : IProductVariantSelectionExclusion
    {
        public IProductVariantSelectionTypeEnum Type { get; set; }

        public IList<string> Skus { get; set; }
        public IEnumerable<string> SkusEnumerable { set => Skus = value.ToList(); }

        public ProductVariantSelectionExclusion()
        {
            this.Type = IProductVariantSelectionTypeEnum.FindEnum("exclusion");
        }
    }
}
