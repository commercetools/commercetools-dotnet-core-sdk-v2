using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    public  partial class TypeDraft : ITypeDraft
    {
        public string Key { get; set;}
        
        public ILocalizedString Name { get; set;}
        
        public ILocalizedString Description { get; set;}
        
        public List<string> ResourceTypeIds { get; set;}
        
        [JsonIgnore]
        public List<ResourceTypeId> ResourceTypeIdsAsEnum => this.ResourceTypeIds.GetEnum<ResourceTypeId>();
        
        public List<IFieldDefinition> FieldDefinitions { get; set;}
    }
}
