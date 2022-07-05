using System;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductSetAttributeAction : IProductSetAttributeAction
    {
        public string Action { get; set; }

        public long? VariantId { get; set; }

        public string Sku { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }

        public bool? Staged { get; set; }
        public ProductSetAttributeAction()
        {
            this.Action = "setAttribute";
        }
    }
}
