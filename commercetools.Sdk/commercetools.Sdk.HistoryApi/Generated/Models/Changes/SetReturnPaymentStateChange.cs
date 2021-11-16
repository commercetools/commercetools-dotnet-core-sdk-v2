using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetReturnPaymentStateChange : ISetReturnPaymentStateChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public IReturnPaymentState NextValue { get; set;}
        
        public IReturnPaymentState PreviousValue { get; set;}
        public SetReturnPaymentStateChange()
        { 
           this.Type = "SetReturnPaymentStateChange";
        }
    }
}
