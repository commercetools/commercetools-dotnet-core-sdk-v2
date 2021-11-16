namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetTextChange : ISetTextChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public string PreviousValue { get; set;}
        
        public string NextValue { get; set;}
        public SetTextChange()
        { 
           this.Type = "SetTextChange";
        }
    }
}
