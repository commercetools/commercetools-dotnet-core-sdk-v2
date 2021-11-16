using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.AddLocalizedEnumValueChange))]
    public partial interface IAddLocalizedEnumValueChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        string FieldName { get; set;}
        
        string AttributeName { get; set;}
        
        ILocalizedEnumValue NextValue { get; set;}
    }
}
