

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeIncludedInStatisticsChange : IChangeIncludedInStatisticsChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public bool PreviousValue { get; set; }

        public bool NextValue { get; set; }
        public ChangeIncludedInStatisticsChange()
        {
            this.Type = "ChangeIncludedInStatisticsChange";
        }
    }
}
