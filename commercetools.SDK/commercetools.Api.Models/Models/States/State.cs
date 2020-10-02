using commercetools.Api.Models.Common;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.States
{
    public partial class State : BaseResource
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public DateTime LastModifiedAt { get; set;}
        
        public LastModifiedBy LastModifiedBy { get; set;}
        
        public CreatedBy CreatedBy { get; set;}
        
        public string Key { get; set;}
        
        public string Type { get; set;}
        
        [JsonIgnore]
        public StateTypeEnum TypeAsEnum => this.Type.GetEnum<StateTypeEnum>();
        
        public LocalizedString Name { get; set;}
        
        public LocalizedString Description { get; set;}
        
        public bool Initial { get; set;}
        
        public bool BuiltIn { get; set;}
        
        public List<string> Roles { get; set;}
        
        [JsonIgnore]
        public List<StateRoleEnum> RolesAsEnum => this.Roles.GetEnum<StateRoleEnum>();
        
        public List<StateReference> Transitions { get; set;}
    }
}
