namespace commercetools.HistoryApi.Models.Changes
{
    public partial class ChangeIsActiveChange : IChangeIsActiveChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public bool PreviousValue { get; set;}
        
        public bool NextValue { get; set;}
        public ChangeIsActiveChange()
        { 
           this.Type = "ChangeIsActiveChange";
        }
    }
}
