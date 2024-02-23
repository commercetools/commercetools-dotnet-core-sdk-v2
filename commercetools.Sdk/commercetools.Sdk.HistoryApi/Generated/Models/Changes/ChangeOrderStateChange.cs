using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeOrderStateChange : IChangeOrderStateChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IOrderState PreviousValue { get; set; }

        public IOrderState NextValue { get; set; }
        public ChangeOrderStateChange()
        {
            this.Type = "ChangeOrderStateChange";
        }
    }
}
