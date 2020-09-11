using commercetools.Api.Models.Common;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.States
{
    public class StateDraft 
    {
        public string Key { get; set;}
        
        public StateTypeEnum Type { get; set;}
        
        public LocalizedString Name { get; set;}
        
        public LocalizedString Description { get; set;}
        
        public bool Initial { get; set;}
        
        public List<StateRoleEnum> Roles { get; set;}
        
        public List<StateResourceIdentifier> Transitions { get; set;}
    }
}
