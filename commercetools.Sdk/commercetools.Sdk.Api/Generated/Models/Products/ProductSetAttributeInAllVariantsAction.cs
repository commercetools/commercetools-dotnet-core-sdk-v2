using System;


namespace commercetools.Sdk.Api.Models.Products
{
    public partial class ProductSetAttributeInAllVariantsAction : IProductSetAttributeInAllVariantsAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }

        public bool? Staged { get; set; }
        public ProductSetAttributeInAllVariantsAction()
        {
            this.Action = "setAttributeInAllVariants";
        }
    }
}
