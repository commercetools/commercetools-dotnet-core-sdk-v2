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
    public partial class ChangeTransactionStateChange : IChangeTransactionStateChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public ITransactionChangeValue Transaction { get; set;}
        
        public ITransactionState NextValue { get; set;}
        
        public ITransactionState PreviousValue { get; set;}
        public ChangeTransactionStateChange()
        { 
           this.Type = "ChangeTransactionStateChange";
        }
    }
}
