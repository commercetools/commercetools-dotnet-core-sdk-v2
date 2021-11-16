using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetDefaultShippingAddressChange))]
    public partial interface ISetDefaultShippingAddressChange : IChange
    {
        new string Change { get; set;}
        
        new string Type { get; set;}
        
        IAddress NextValue { get; set;}
        
        IAddress PreviousValue { get; set;}
    }
}
