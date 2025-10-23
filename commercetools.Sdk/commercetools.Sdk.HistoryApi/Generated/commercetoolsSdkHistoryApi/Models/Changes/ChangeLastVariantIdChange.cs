

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeLastVariantIdChange : IChangeLastVariantIdChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public int PreviousValue { get; set; }

        public int NextValue { get; set; }
        public ChangeLastVariantIdChange()
        {
            this.Type = "ChangeLastVariantIdChange";
        }
    }
}
