using commercetools.Sdk.Api.Models.AttributeGroups;
using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.AttributeGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupReference))]
    public partial interface IAttributeGroupReference : IReference
    {
        IAttributeGroup Obj { get; set; }

        new string Id { get; set; }

    }
}
