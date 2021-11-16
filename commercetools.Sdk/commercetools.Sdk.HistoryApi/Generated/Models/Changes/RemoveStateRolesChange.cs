using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class RemoveStateRolesChange : IRemoveStateRolesChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public List<IStateRole> PreviousValue { get; set;}
        
        public List<IStateRole> NextValue { get; set;}
        public RemoveStateRolesChange()
        { 
           this.Type = "RemoveStateRolesChange";
        }
    }
}
