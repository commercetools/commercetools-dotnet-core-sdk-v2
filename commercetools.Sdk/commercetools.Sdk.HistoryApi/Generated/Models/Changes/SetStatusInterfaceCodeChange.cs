namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetStatusInterfaceCodeChange : ISetStatusInterfaceCodeChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public string PreviousValue { get; set;}
        
        public string NextValue { get; set;}
        public SetStatusInterfaceCodeChange()
        { 
           this.Type = "SetStatusInterfaceCodeChange";
        }
    }
}
