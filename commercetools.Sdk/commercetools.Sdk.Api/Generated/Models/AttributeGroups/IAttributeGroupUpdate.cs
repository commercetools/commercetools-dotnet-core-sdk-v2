using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.AttributeGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupUpdate))]
    public partial interface IAttributeGroupUpdate
    {
        long Version { get; set; }

        List<IAttributeGroupUpdateAction> Actions { get; set; }

    }
}
