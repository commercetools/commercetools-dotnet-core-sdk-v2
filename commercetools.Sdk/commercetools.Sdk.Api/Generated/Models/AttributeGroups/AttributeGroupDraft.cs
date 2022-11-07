using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.AttributeGroups
{

    public partial class AttributeGroupDraft : IAttributeGroupDraft
    {
        public ILocalizedString Name { get; set; }

        public ILocalizedString Description { get; set; }

        public List<IAttributeReference> Attributes { get; set; }

        public string Key { get; set; }
    }
}
