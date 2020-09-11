using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Types
{
    public class TypeDraft 
    {
        public string Key { get; set;}
        
        public LocalizedString Name { get; set;}
        
        public LocalizedString Description { get; set;}
        
        public List<ResourceTypeId> ResourceTypeIds { get; set;}
        
        public List<FieldDefinition> FieldDefinitions { get; set;}
    }
}
