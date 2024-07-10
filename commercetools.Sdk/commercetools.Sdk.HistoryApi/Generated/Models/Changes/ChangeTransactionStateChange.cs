using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeTransactionStateChange : IChangeTransactionStateChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ITransactionState PreviousValue { get; set; }

        public ITransactionState NextValue { get; set; }

        public ITransactionChangeValue Transaction { get; set; }
        public ChangeTransactionStateChange()
        {
            this.Type = "ChangeTransactionStateChange";
        }
    }
}
