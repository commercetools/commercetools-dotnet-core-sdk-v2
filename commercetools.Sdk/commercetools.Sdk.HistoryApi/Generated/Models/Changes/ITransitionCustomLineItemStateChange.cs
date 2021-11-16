using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.TransitionCustomLineItemStateChange))]
    public partial interface ITransitionCustomLineItemStateChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        string LineItemId { get; set;}
        
        string StateId { get; set;}
        
        List<IItemState> NextValue { get; set;}
        
        List<IItemState> PreviousValue { get; set;}
    }
}
