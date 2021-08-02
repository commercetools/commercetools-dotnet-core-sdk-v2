using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.ChangeTransactionStateChange))]
    public partial interface IChangeTransactionStateChange : IChange
    {
        new string Change { get; set;}
        
        new string Type { get; set;}
        
        ITransactionChangeValue Transaction { get; set;}
        
        ITransactionState NextValue { get; set;}
        
        ITransactionState PreviousValue { get; set;}
    }
}