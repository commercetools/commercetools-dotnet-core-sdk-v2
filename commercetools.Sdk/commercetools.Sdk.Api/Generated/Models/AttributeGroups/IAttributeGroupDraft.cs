using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.AttributeGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupDraft))]
    public partial interface IAttributeGroupDraft
    {
        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        List<IAttributeReference> Attributes { get; set; }

        string Key { get; set; }

    }
}
