using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetStoresChange : ISetStoresChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public List<IReference> PreviousValue { get; set;}
        
        public List<IReference> NextValue { get; set;}
        public SetStoresChange()
        { 
           this.Type = "SetStoresChange";
        }
    }
}
