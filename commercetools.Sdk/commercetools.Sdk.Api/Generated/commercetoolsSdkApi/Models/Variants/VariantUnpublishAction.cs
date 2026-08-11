

namespace commercetools.Sdk.Api.Models.Variants
{

    public partial class VariantUnpublishAction : IVariantUnpublishAction
    {
        public string Action { get; set; }
        public VariantUnpublishAction()
        {
            this.Action = "unpublish";
        }
    }
}
