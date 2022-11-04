using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;


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

        public List<IAttributeReference> Attributes { get; set; }

        public string Key { get; set; }
    }
}
