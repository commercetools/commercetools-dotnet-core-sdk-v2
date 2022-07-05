using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class RemovePaymentChange : IRemovePaymentChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IPaymentInfo NextValue { get; set; }

        public IPaymentInfo PreviousValue { get; set; }
        public RemovePaymentChange()
        {
            this.Type = "RemovePaymentChange";
        }
    }
}
