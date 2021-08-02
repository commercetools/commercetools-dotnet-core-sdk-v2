using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.AddInterfaceInteractionChange))]
    public partial interface IAddInterfaceInteractionChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        ICustomFieldExpandedValue NextValue { get; set;}
    }
}
