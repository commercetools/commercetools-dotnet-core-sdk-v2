using commercetools.HistoryApi.Models.ChangeValues;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class ChangeTransactionInteractionIdChange : IChangeTransactionInteractionIdChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public ITransactionChangeValue Transaction { get; set;}
        
        public string NextValue { get; set;}
        
        public string PreviousValue { get; set;}
        public ChangeTransactionInteractionIdChange()
        { 
           this.Type = "ChangeTransactionInteractionIdChange";
        }
    }
}
