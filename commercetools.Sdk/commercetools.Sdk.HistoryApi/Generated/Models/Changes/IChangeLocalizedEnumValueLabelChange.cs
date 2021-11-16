using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.ChangeLocalizedEnumValueLabelChange))]
    public partial interface IChangeLocalizedEnumValueLabelChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        string FieldName { get; set;}
        
        string AttributeName { get; set;}
        
        string ValueKey { get; set;}
        
        ILocalizedString PreviousValue { get; set;}
        
        ILocalizedString NextValue { get; set;}
    }
}
