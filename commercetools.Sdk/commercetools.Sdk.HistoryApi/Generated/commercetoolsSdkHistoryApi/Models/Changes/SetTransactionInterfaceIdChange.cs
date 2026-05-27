using commercetools.Sdk.HistoryApi.Models.ChangeValues;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetTransactionInterfaceIdChange : ISetTransactionInterfaceIdChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ITransactionChangeValue Transaction { get; set; }

        public string PreviousValue { get; set; }

        public string NextValue { get; set; }
        public SetTransactionInterfaceIdChange()
        {
            this.Type = "SetTransactionInterfaceIdChange";
        }
    }
}
