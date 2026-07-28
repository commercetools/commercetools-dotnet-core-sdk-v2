

namespace commercetools.Sdk.Api.Models.Variants
{

    public partial class VariantSetImageLabelAction : IVariantSetImageLabelAction
    {
        public string Action { get; set; }

        public string ImageUrl { get; set; }

        public string Label { get; set; }

        public bool? Staged { get; set; }
        public VariantSetImageLabelAction()
        {
            this.Action = "setImageLabel";
        }
    }
}
