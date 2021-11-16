namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetStatusInterfaceTextChange : ISetStatusInterfaceTextChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public string PreviousValue { get; set;}
        
        public string NextValue { get; set;}
        public SetStatusInterfaceTextChange()
        { 
           this.Type = "SetStatusInterfaceTextChange";
        }
    }
}
