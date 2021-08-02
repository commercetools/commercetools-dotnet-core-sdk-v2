using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class ChangeValueChange : IChangeValueChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public IChangeValueChangeValue NextValue { get; set;}
        
        public IChangeValueChangeValue PreviousValue { get; set;}
        public ChangeValueChange()
        { 
           this.Type = "ChangeValueChange";
        }
    }
}
