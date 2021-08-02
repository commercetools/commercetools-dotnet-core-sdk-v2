using commercetools.HistoryApi.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class UnknownChange : IUnknownChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public Object PreviousValue { get; set;}
        
        public Object NextValue { get; set;}
        public UnknownChange()
        { 
           this.Type = "UnknownChange";
        }
    }
}