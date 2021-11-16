using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.ChangeTargetChange))]
    public partial interface IChangeTargetChange : IChange
    {
        new string Change { get; set;}
        
        new string Type { get; set;}
        
        IChangeTargetChangeValue NextValue { get; set;}
        
        IChangeTargetChangeValue PreviousValue { get; set;}
    }
}
