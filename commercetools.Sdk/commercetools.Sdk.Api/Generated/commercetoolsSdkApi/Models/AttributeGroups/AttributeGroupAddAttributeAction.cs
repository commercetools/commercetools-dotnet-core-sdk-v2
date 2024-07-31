

namespace commercetools.Sdk.Api.Models.AttributeGroups
{

    public partial class AttributeGroupAddAttributeAction : IAttributeGroupAddAttributeAction
    {
        public string Action { get; set; }

        public IAttributeReference Attribute { get; set; }
        public AttributeGroupAddAttributeAction()
        {
            this.Action = "addAttribute";
        }
    }
}
