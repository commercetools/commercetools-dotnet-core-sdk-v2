using commercetools.Sdk.Api.Models.AttributeGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.AttributeGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupSetAttributesAction))]
    public partial interface IAttributeGroupSetAttributesAction : IAttributeGroupUpdateAction
    {
        IList<IAttributeReference> Attributes { get; set; }
        IEnumerable<IAttributeReference> AttributesEnumerable { set => Attributes = value.ToList(); }


    }
}
