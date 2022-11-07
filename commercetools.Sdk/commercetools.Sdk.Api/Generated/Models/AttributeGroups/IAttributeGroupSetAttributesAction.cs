using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.AttributeGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupSetAttributesAction))]
    public partial interface IAttributeGroupSetAttributesAction : IAttributeGroupUpdateAction
    {
        List<IAttributeReference> Attributes { get; set; }

    }
}
