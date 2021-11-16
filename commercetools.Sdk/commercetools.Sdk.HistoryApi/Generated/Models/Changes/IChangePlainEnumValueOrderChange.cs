using commercetools.HistoryApi.Models.ChangeValues;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.ChangePlainEnumValueOrderChange))]
    public partial interface IChangePlainEnumValueOrderChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        string AttributeName { get; set;}
        
        List<IEnumValue> NextValue { get; set;}
        
        List<IEnumValue> PreviousValue { get; set;}
    }
}
