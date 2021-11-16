using commercetools.HistoryApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetStateRolesChange : ISetStateRolesChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public List<IStateRole> PreviousValue { get; set;}
        
        public List<IStateRole> NextValue { get; set;}
        public SetStateRolesChange()
        { 
           this.Type = "SetStateRolesChange";
        }
    }
}
