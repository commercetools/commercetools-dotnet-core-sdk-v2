using commercetools.Api.Models.Common;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.States
{
    public partial class State : IState
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public DateTime LastModifiedAt { get; set;}
        
        public ILastModifiedBy LastModifiedBy { get; set;}
        
        public ICreatedBy CreatedBy { get; set;}
        
        public string Key { get; set;}
        
        public string Type { get; set;}
        
        [JsonIgnore]
        public StateTypeEnum TypeAsEnum => this.Type.GetEnum<StateTypeEnum>();
        
        public ILocalizedString Name { get; set;}
        
        public ILocalizedString Description { get; set;}
        
        public bool Initial { get; set;}
        
        public bool BuiltIn { get; set;}
        
        public List<string> Roles { get; set;}
        
        [JsonIgnore]
        public List<StateRoleEnum> RolesAsEnum => this.Roles.GetEnum<StateRoleEnum>();
        
        public List<IStateReference> Transitions { get; set;}
    }
}
