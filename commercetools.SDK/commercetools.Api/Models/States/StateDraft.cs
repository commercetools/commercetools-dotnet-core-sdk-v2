using commercetools.Api.Models.Common;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.States
{
    public partial class StateDraft 
    {
        public string Key { get; set;}
        
        public string Type { get; set;}
        
        [JsonIgnore]
        public StateTypeEnum TypeAsEnum => this.Type.GetEnum<StateTypeEnum>();
        
        public LocalizedString Name { get; set;}
        
        public LocalizedString Description { get; set;}
        
        public bool Initial { get; set;}
        
        public List<string> Roles { get; set;}
        
        [JsonIgnore]
        public List<StateRoleEnum> RolesAsEnum => this.Roles.GetEnum<StateRoleEnum>();
        
        public List<StateResourceIdentifier> Transitions { get; set;}
    }
}
