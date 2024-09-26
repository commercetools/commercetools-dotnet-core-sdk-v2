using System;

namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductTailoringSetAttributeAction : IProductTailoringSetAttributeAction
    {
        public string Action { get; set; }

        public long? VariantId { get; set; }

        public string Sku { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }

        public bool? Staged { get; set; }
        public ProductTailoringSetAttributeAction()
        {
            this.Action = "setAttribute";
        }
    }
}
