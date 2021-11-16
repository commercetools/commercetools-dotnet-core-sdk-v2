using commercetools.Api.Models.Common;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.States
{
    [DeserializeAs(typeof(commercetools.Api.Models.States.State))]
    public partial interface IState : IBaseResource
    {
        new string Id { get; set;}
        
        new long Version { get; set;}
        
        new DateTime CreatedAt { get; set;}
        
        new DateTime LastModifiedAt { get; set;}
        
        ILastModifiedBy LastModifiedBy { get; set;}
        
        ICreatedBy CreatedBy { get; set;}
        
        string Key { get; set;}
        
        IStateTypeEnum Type { get; set;}
        
        ILocalizedString Name { get; set;}
        
        ILocalizedString Description { get; set;}
        
        bool Initial { get; set;}
        
        bool BuiltIn { get; set;}
        
        List<IStateRoleEnum> Roles { get; set;}
        
        List<IStateReference> Transitions { get; set;}
    }
}
