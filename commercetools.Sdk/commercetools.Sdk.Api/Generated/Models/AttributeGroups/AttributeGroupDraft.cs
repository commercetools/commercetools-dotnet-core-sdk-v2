using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.AttributeGroups
{

    public partial class AttributeGroupDraft : IAttributeGroupDraft
    {
        public ILocalizedString Name { get; set; }

        public ILocalizedString Description { get; set; }

        public IList<IAttributeReference> Attributes { get; set; }
        public IEnumerable<IAttributeReference> AttributesEnumerable { set => Attributes = value.ToList(); }


        public string Key { get; set; }
    }
}
