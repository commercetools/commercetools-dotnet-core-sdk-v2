using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.AttributeGroups
{

    public partial class AttributeGroupChangeNameAction : IAttributeGroupChangeNameAction
    {
        public string Action { get; set; }

        public ILocalizedString Name { get; set; }
        public AttributeGroupChangeNameAction()
        {
            this.Action = "changeName";
        }
    }
}
