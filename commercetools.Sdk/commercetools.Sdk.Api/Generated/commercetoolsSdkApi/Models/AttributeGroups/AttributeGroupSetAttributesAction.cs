using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.AttributeGroups
{

    public partial class AttributeGroupSetAttributesAction : IAttributeGroupSetAttributesAction
    {
        public string Action { get; set; }

        public IList<IAttributeReference> Attributes { get; set; }

        public IEnumerable<IAttributeReference> AttributesEnumerable { set => Attributes = value.ToList(); }
        public AttributeGroupSetAttributesAction()
        {
            this.Action = "setAttributes";
        }
    }
}
