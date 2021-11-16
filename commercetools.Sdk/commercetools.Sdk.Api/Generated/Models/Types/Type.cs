using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;


namespace commercetools.Api.Models.Types
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

        public List<IResourceTypeId> ResourceTypeIds { get; set; }

        public List<IFieldDefinition> FieldDefinitions { get; set; }
    }
}
