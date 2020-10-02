using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    public partial class Type : BaseResource
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public DateTime LastModifiedAt { get; set;}
        
        public LastModifiedBy LastModifiedBy { get; set;}
        
        public CreatedBy CreatedBy { get; set;}
        
        public string Key { get; set;}
        
        public LocalizedString Name { get; set;}
        
        public LocalizedString Description { get; set;}
        
        public List<string> ResourceTypeIds { get; set;}
        
        [JsonIgnore]
        public List<ResourceTypeId> ResourceTypeIdsAsEnum => this.ResourceTypeIds.GetEnum<ResourceTypeId>();
        
        public List<FieldDefinition> FieldDefinitions { get; set;}
    }
}
