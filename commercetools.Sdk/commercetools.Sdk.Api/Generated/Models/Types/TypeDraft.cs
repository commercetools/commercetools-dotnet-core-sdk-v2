using commercetools.Api.Models.Common;
using System.Collections.Generic;


namespace commercetools.Api.Models.Types
{
    public partial class TypeDraft : ITypeDraft
    {
        public string Key { get; set;}
        
        public ILocalizedString Name { get; set;}
        
        public ILocalizedString Description { get; set;}
        
        public List<IResourceTypeId> ResourceTypeIds { get; set;}
        
        public List<IFieldDefinition> FieldDefinitions { get; set;}
    }
}
