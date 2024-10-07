using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Types.TypeImport))]
    public partial interface ITypeImport : IImportResource
    {
        new string Key { get; set; }

        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        IList<IResourceTypeId> ResourceTypeIds { get; set; }

        IEnumerable<IResourceTypeId> ResourceTypeIdsEnumerable { set => ResourceTypeIds = value.ToList(); }

        IList<IFieldDefinition> FieldDefinitions { get; set; }

        IEnumerable<IFieldDefinition> FieldDefinitionsEnumerable { set => FieldDefinitions = value.ToList(); }

    }
}
