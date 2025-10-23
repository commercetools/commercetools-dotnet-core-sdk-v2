

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class RevertStagedVariantChangesChange : IRevertStagedVariantChangesChange
    {
        public string Type { get; set; }

        public string Change { get; set; }
        public RevertStagedVariantChangesChange()
        {
            this.Type = "RevertStagedVariantChangesChange";
        }
    }
}
