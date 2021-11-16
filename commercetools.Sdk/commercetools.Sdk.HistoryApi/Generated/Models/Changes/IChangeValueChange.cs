using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.ChangeValueChange))]
    public partial interface IChangeValueChange : IChange
    {
        new string Change { get; set;}
        
        new string Type { get; set;}
        
        IChangeValueChangeValue NextValue { get; set;}
        
        IChangeValueChangeValue PreviousValue { get; set;}
    }
}
