using System;

namespace commercetools.Sdk.Api.Models.Variants
{

    public partial class VariantSetAttributeAction : IVariantSetAttributeAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }

        public bool? Staged { get; set; }
        public VariantSetAttributeAction()
        {
            this.Action = "setAttribute";
        }
    }
}
