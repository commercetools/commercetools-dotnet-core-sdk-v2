using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.States
{
    public interface IState : IBaseResource
    {
        string Id { get; set;}
        
        long Version { get; set;}
        
        DateTime CreatedAt { get; set;}
        
        DateTime LastModifiedAt { get; set;}
        
        ILastModifiedBy LastModifiedBy { get; set;}
        
        ICreatedBy CreatedBy { get; set;}
        
        string Key { get; set;}
        
        string Type { get; set;}
        
        StateTypeEnum TypeAsEnum { get; }
        
        ILocalizedString Name { get; set;}
        
        ILocalizedString Description { get; set;}
        
        bool Initial { get; set;}
        
        bool BuiltIn { get; set;}
        
        List<string> Roles { get; set;}
        
        List<StateRoleEnum> RolesAsEnum { get; }
        
        List<IStateReference> Transitions { get; set;}
    }
}
