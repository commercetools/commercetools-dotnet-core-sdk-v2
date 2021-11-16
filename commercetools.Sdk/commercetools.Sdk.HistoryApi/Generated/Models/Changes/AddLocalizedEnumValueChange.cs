using commercetools.HistoryApi.Models.ChangeValues;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class AddLocalizedEnumValueChange : IAddLocalizedEnumValueChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public string FieldName { get; set;}
        
        public string AttributeName { get; set;}
        
        public ILocalizedEnumValue NextValue { get; set;}
        public AddLocalizedEnumValueChange()
        { 
           this.Type = "AddLocalizedEnumValueChange";
        }
    }
}
