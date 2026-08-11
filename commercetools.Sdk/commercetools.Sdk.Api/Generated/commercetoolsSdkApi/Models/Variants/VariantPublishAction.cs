

namespace commercetools.Sdk.Api.Models.Variants
{

    public partial class VariantPublishAction : IVariantPublishAction
    {
        public string Action { get; set; }
        public VariantPublishAction()
        {
            this.Action = "publish";
        }
    }
}
