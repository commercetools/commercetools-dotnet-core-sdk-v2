using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetDefaultBillingAddressChange))]
    public partial interface ISetDefaultBillingAddressChange : IChange
    {
        new string Change { get; set;}
        
        new string Type { get; set;}
        
        IAddress NextValue { get; set;}
        
        IAddress PreviousValue { get; set;}
    }
}
