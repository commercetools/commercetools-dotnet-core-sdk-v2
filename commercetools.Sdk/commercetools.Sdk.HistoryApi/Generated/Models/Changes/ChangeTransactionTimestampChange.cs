using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class ChangeTransactionTimestampChange : IChangeTransactionTimestampChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public ITransactionChangeValue Transaction { get; set;}
        
        public string NextValue { get; set;}
        
        public string PreviousValue { get; set;}
        public ChangeTransactionTimestampChange()
        { 
           this.Type = "ChangeTransactionTimestampChange";
        }
    }
}
