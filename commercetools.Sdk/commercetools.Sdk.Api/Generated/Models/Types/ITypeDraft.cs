using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.TypeDraft))]
    public partial interface ITypeDraft
    {
        string Key { get; set; }

        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        IList<IResourceTypeId> ResourceTypeIds { get; set; }
        IEnumerable<IResourceTypeId> ResourceTypeIdsEnumerable { set => ResourceTypeIds = value.ToList(); }


        IList<IFieldDefinition> FieldDefinitions { get; set; }
        IEnumerable<IFieldDefinition> FieldDefinitionsEnumerable { set => FieldDefinitions = value.ToList(); }


    }
}
