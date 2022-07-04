using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.ProductSelections
{
    public partial class ProductVariantSelectionExclusion : IProductVariantSelectionExclusion
    {
        public IProductVariantSelectionTypeEnum Type { get; set; }

        public List<string> Skus { get; set; }
        public ProductVariantSelectionExclusion()
        {
            this.Type = IProductVariantSelectionTypeEnum.FindEnum("exclusion");
        }
    }
}
