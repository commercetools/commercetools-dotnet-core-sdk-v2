using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.ChangeStateTypeChange))]
    public partial interface IChangeStateTypeChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        IStateType PreviousValue { get; set;}
        
        IStateType NextValue { get; set;}
    }
}
