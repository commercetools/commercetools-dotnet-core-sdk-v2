using commercetools.HistoryApi.Models.Common;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetShippingMethodTaxAmountChange))]
    public partial interface ISetShippingMethodTaxAmountChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        ITaxMode TaxMode { get; set;}
        
        Object NextValue { get; set;}
        
        Object PreviousValue { get; set;}
    }
}
