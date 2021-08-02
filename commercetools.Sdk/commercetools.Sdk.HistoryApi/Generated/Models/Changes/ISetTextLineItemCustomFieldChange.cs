using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetTextLineItemCustomFieldChange))]
    public partial interface ISetTextLineItemCustomFieldChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        string Name { get; set;}
        
        string CustomTypeId { get; set;}
        
        ITextLineItemValue TextLineItem { get; set;}
        
        Object NextValue { get; set;}
        
        Object PreviousValue { get; set;}
    }
}
