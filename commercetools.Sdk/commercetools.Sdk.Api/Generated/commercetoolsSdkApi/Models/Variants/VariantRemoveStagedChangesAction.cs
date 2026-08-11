

namespace commercetools.Sdk.Api.Models.Variants
{

    public partial class VariantRemoveStagedChangesAction : IVariantRemoveStagedChangesAction
    {
        public string Action { get; set; }
        public VariantRemoveStagedChangesAction()
        {
            this.Action = "removeStagedChanges";
        }
    }
}
