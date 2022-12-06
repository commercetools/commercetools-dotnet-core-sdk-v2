using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.AttributeGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupDraft))]
    public partial interface IAttributeGroupDraft
    {
        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        IList<IAttributeReference> Attributes { get; set; }
        IEnumerable<IAttributeReference> AttributesEnumerable { set => Attributes = value.ToList(); }


        string Key { get; set; }

    }
}
