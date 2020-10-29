using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Api.Models.Types.TypeDraft))]
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
