using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Types
{

    public partial class Type : IType
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public string Key { get; set; }

        public ILocalizedString Name { get; set; }

        public ILocalizedString Description { get; set; }

        public IList<IResourceTypeId> ResourceTypeIds { get; set; }

        public IEnumerable<IResourceTypeId> ResourceTypeIdsEnumerable { set => ResourceTypeIds = value.ToList(); }

        public IList<IFieldDefinition> FieldDefinitions { get; set; }

        public IEnumerable<IFieldDefinition> FieldDefinitionsEnumerable { set => FieldDefinitions = value.ToList(); }
    }
}
