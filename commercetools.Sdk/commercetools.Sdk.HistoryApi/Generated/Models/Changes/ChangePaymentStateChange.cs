using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangePaymentStateChange : IChangePaymentStateChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IPaymentState NextValue { get; set; }

        public IPaymentState PreviousValue { get; set; }
        public ChangePaymentStateChange()
        {
            this.Type = "ChangePaymentStateChange";
        }
    }
}
