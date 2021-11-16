using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.ChangeTextLineItemQuantityChange))]
    public partial interface IChangeTextLineItemQuantityChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        ITextLineItemValue TextLineItem { get; set;}
        
        int PreviousValue { get; set;}
        
        int NextValue { get; set;}
    }
}
