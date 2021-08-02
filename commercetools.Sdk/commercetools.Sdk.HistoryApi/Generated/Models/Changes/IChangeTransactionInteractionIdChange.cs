using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.ChangeTransactionInteractionIdChange))]
    public partial interface IChangeTransactionInteractionIdChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        ITransactionChangeValue Transaction { get; set;}
        
        string NextValue { get; set;}
        
        string PreviousValue { get; set;}
    }
}
