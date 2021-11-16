using commercetools.Api.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Api.Models.Types.TypeDraft))]
    public partial interface ITypeDraft
    {
        string Key { get; set; }

        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        List<IResourceTypeId> ResourceTypeIds { get; set; }

        List<IFieldDefinition> FieldDefinitions { get; set; }
    }
}
