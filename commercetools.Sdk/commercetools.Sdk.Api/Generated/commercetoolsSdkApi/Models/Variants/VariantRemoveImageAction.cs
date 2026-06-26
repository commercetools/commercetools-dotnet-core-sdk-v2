

namespace commercetools.Sdk.Api.Models.Variants
{

    public partial class VariantRemoveImageAction : IVariantRemoveImageAction
    {
        public string Action { get; set; }

        public string ImageUrl { get; set; }

        public bool? Staged { get; set; }
        public VariantRemoveImageAction()
        {
            this.Action = "removeImage";
        }
    }
}
