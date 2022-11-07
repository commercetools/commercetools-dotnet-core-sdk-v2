using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
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

        List<IAttributeReference> Attributes { get; set; }

        string Key { get; set; }

    }
}
