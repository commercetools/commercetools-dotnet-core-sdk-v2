using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.AttributeGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroup))]
    public partial interface IAttributeGroup : IBaseResource
    {
        new string Id { get; set; }

        new long Version { get; set; }

        new DateTime CreatedAt { get; set; }

        new DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

        ICreatedBy CreatedBy { get; set; }

        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        IList<IAttributeReference> Attributes { get; set; }
        IEnumerable<IAttributeReference> AttributesEnumerable { set => Attributes = value.ToList(); }


        string Key { get; set; }

    }
}
