using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
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
