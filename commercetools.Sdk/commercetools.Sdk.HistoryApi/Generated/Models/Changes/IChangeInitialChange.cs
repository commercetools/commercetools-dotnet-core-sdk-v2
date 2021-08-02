using commercetools.HistoryApi.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.ChangeInitialChange))]
    public partial interface IChangeInitialChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        bool PreviousValue { get; set;}
        
        bool NextValue { get; set;}
    }
}
