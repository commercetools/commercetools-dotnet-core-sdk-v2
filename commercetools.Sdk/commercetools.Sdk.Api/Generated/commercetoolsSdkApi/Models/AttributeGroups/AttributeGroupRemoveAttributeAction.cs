namespace commercetools.Sdk.Api.Models.AttributeGroups
{

    public partial class AttributeGroupRemoveAttributeAction : IAttributeGroupRemoveAttributeAction
    {
        public string Action { get; set; }

        public IAttributeReference Attribute { get; set; }
        public AttributeGroupRemoveAttributeAction()
        {
            this.Action = "removeAttribute";
        }
    }
}
