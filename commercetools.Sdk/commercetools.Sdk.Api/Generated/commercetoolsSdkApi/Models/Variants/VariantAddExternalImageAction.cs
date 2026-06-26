using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Variants
{

    public partial class VariantAddExternalImageAction : IVariantAddExternalImageAction
    {
        public string Action { get; set; }

        public IImage Image { get; set; }

        public bool? Staged { get; set; }
        public VariantAddExternalImageAction()
        {
            this.Action = "addExternalImage";
        }
    }
}
