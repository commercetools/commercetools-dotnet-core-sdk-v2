using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetCustomShippingMethodChange))]
    public partial interface ISetCustomShippingMethodChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        ICustomShippingMethodChangeValue NextValue { get; set;}
        
        ICustomShippingMethodChangeValue PreviousValue { get; set;}
    }
}
