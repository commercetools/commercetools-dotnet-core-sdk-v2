using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.RemovePaymentChange))]
    public partial interface IRemovePaymentChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        IPaymentInfo NextValue { get; set;}
        
        IPaymentInfo PreviousValue { get; set;}
    }
}
