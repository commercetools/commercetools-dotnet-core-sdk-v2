using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetLocalizedDescriptionChange : ISetLocalizedDescriptionChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public ILocalizedString PreviousValue { get; set;}
        
        public ILocalizedString NextValue { get; set;}
        public SetLocalizedDescriptionChange()
        { 
           this.Type = "SetLocalizedDescriptionChange";
        }
    }
}
