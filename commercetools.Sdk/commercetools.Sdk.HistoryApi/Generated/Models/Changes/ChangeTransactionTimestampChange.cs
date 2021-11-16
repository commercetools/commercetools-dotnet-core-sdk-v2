using commercetools.HistoryApi.Models.ChangeValues;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class ChangeTransactionTimestampChange : IChangeTransactionTimestampChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ITransactionChangeValue Transaction { get; set; }

        public string NextValue { get; set; }

        public string PreviousValue { get; set; }
        public ChangeTransactionTimestampChange()
        {
            this.Type = "ChangeTransactionTimestampChange";
        }
    }
}
