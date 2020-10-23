using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Types
{
    public interface ITypeDraft 
    {
        string Key { get; set;}
        
        ILocalizedString Name { get; set;}
        
        ILocalizedString Description { get; set;}
        
        List<string> ResourceTypeIds { get; set;}
        
        List<ResourceTypeId> ResourceTypeIdsAsEnum { get; }
        
        List<IFieldDefinition> FieldDefinitions { get; set;}
    }
}
