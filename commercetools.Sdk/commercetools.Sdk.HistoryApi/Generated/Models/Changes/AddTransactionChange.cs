using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class AddTransactionChange : IAddTransactionChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public ITransaction NextValue { get; set;}
        public AddTransactionChange()
        { 
           this.Type = "AddTransactionChange";
        }
    }
}
