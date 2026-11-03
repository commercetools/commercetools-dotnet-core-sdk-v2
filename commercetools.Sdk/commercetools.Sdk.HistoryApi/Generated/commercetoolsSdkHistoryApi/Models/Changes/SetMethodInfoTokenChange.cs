

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetMethodInfoTokenChange : ISetMethodInfoTokenChange
    {
        public string Type { get; set; }

        public string Change { get; set; }
        public SetMethodInfoTokenChange()
        {
            this.Type = "SetMethodInfoTokenChange";
        }
    }
}
