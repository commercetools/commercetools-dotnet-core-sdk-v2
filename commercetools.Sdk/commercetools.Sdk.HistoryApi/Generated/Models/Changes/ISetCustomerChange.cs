using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetCustomerChange))]
    public partial interface ISetCustomerChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        IReference PreviousValue { get; set;}
        
        IReference NextValue { get; set;}
    }
}
