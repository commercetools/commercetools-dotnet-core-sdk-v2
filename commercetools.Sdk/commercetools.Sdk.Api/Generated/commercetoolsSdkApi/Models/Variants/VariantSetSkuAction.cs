

namespace commercetools.Sdk.Api.Models.Variants
{

    public partial class VariantSetSkuAction : IVariantSetSkuAction
    {
        public string Action { get; set; }

        public string Sku { get; set; }

        public bool? Staged { get; set; }
        public VariantSetSkuAction()
        {
            this.Action = "setSku";
        }
    }
}
