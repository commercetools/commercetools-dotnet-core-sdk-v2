using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.AttributeGroups
{

    public partial class AttributeGroup : IAttributeGroup
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public ILocalizedString Name { get; set; }

        public ILocalizedString Description { get; set; }

        public IList<IAttributeReference> Attributes { get; set; }

        public IEnumerable<IAttributeReference> AttributesEnumerable { set => Attributes = value.ToList(); }

        public string Key { get; set; }
    }
}
