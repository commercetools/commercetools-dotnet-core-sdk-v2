using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class ChangeStateTypeChange : IChangeStateTypeChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public IStateType PreviousValue { get; set;}
        
        public IStateType NextValue { get; set;}
        public ChangeStateTypeChange()
        { 
           this.Type = "ChangeStateTypeChange";
        }
    }
}
