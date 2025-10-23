

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class RevertStagedChangesChange : IRevertStagedChangesChange
    {
        public string Type { get; set; }

        public string Change { get; set; }
        public RevertStagedChangesChange()
        {
            this.Type = "RevertStagedChangesChange";
        }
    }
}
