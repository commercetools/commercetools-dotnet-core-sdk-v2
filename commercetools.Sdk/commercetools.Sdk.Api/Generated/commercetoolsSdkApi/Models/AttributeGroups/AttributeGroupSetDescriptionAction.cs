using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.AttributeGroups
{

    public partial class AttributeGroupSetDescriptionAction : IAttributeGroupSetDescriptionAction
    {
        public string Action { get; set; }

        public ILocalizedString Description { get; set; }
        public AttributeGroupSetDescriptionAction()
        {
            this.Action = "setDescription";
        }
    }
}
