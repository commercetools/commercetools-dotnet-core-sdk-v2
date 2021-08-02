using commercetools.HistoryApi.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetMaxApplicationsChange : ISetMaxApplicationsChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public int PreviousValue { get; set;}
        
        public int NextValue { get; set;}
        public SetMaxApplicationsChange()
        { 
           this.Type = "SetMaxApplicationsChange";
        }
    }
}