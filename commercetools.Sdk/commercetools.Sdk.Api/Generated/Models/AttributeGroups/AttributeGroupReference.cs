using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.AttributeGroups
{

    public partial class AttributeGroupReference : IAttributeGroupReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IAttributeGroup Obj { get; set; }
        public AttributeGroupReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("attribute-group");
        }
    }
}
