using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Types
{

    public partial class TypeDraft : ITypeDraft
    {
        public string Key { get; set; }

        public ILocalizedString Name { get; set; }

        public ILocalizedString Description { get; set; }

        public IList<IResourceTypeId> ResourceTypeIds { get; set; }
        public IEnumerable<IResourceTypeId> ResourceTypeIdsEnumerable { set => ResourceTypeIds = value.ToList(); }


        public IList<IFieldDefinition> FieldDefinitions { get; set; }
        public IEnumerable<IFieldDefinition> FieldDefinitionsEnumerable { set => FieldDefinitions = value.ToList(); }

    }
}
