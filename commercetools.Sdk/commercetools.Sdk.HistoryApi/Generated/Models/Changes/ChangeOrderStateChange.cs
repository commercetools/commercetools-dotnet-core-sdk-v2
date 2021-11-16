using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class ChangeOrderStateChange : IChangeOrderStateChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IOrderState NextValue { get; set; }

        public IOrderState PreviousValue { get; set; }
        public ChangeOrderStateChange()
        {
            this.Type = "ChangeOrderStateChange";
        }
    }
}
