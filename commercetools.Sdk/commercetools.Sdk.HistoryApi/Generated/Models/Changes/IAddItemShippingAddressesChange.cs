using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.AddItemShippingAddressesChange))]
    public partial interface IAddItemShippingAddressesChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        IAddress NextValue { get; set;}
        
        IAddress PreviousValue { get; set;}
    }
}
