using System;

namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductTailoringSetAttributeInAllVariantsAction : IProductTailoringSetAttributeInAllVariantsAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }

        public bool? Staged { get; set; }
        public ProductTailoringSetAttributeInAllVariantsAction()
        {
            this.Action = "setAttributeInAllVariants";
        }
    }
}
