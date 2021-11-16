using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.ChangeAmountAuthorizedChange))]
    public partial interface IChangeAmountAuthorizedChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        IMoney PreviousValue { get; set;}
        
        IMoney NextValue { get; set;}
    }
}
