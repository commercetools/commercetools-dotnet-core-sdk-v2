using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.AttributeGroups
{

    public partial class AttributeGroupSetAttributesAction : IAttributeGroupSetAttributesAction
    {
        public string Action { get; set; }

        public List<IAttributeReference> Attributes { get; set; }
        public AttributeGroupSetAttributesAction()
        {
            this.Action = "setAttributes";
        }
    }
}
