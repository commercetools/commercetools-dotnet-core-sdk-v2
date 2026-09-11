

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class VariantStagedChangesRemovedMessagePayload : IVariantStagedChangesRemovedMessagePayload
    {
        public string Type { get; set; }
        public VariantStagedChangesRemovedMessagePayload()
        {
            this.Type = "VariantStagedChangesRemoved";
        }
    }
}
