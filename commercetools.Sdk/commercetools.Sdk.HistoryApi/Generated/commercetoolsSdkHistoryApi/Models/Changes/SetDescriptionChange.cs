

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetDescriptionChange : ISetDescriptionChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string PreviousValue { get; set; }

        public string NextValue { get; set; }
        public SetDescriptionChange()
        {
            this.Type = "SetDescriptionChange";
        }
    }
}
