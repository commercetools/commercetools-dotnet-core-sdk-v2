using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetReturnPaymentStateChange))]
    public partial interface ISetReturnPaymentStateChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        IReturnPaymentState NextValue { get; set;}
        
        IReturnPaymentState PreviousValue { get; set;}
    }
}
