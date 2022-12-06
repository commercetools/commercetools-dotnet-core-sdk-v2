using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.ProductSelections
{

    public partial class ProductVariantSelectionInclusion : IProductVariantSelectionInclusion
    {
        public IProductVariantSelectionTypeEnum Type { get; set; }

        public IList<string> Skus { get; set; }
        public IEnumerable<string> SkusEnumerable { set => Skus = value.ToList(); }

        public ProductVariantSelectionInclusion()
        {
            this.Type = IProductVariantSelectionTypeEnum.FindEnum("inclusion");
        }
    }
}
