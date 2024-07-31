

namespace commercetools.Sdk.Api.Models.AttributeGroups
{

    public partial class AttributeGroupSetKeyAction : IAttributeGroupSetKeyAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public AttributeGroupSetKeyAction()
        {
            this.Action = "setKey";
        }
    }
}
