using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.ProductSelections
{

    public partial class ProductVariantSelectionInclusion : IProductVariantSelectionInclusion
    {
        public IProductVariantSelectionTypeEnum Type { get; set; }

        public List<string> Skus { get; set; }
        public ProductVariantSelectionInclusion()
        {
            this.Type = IProductVariantSelectionTypeEnum.FindEnum("inclusion");
        }
    }
}
