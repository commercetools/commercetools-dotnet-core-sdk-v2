using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.AttributeGroups
{

    public partial class AttributeGroupResourceIdentifier : IAttributeGroupResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public AttributeGroupResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("attribute-group");
        }
    }
}
