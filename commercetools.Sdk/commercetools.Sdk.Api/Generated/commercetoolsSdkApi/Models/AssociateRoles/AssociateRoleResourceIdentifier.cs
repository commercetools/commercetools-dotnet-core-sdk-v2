using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.AssociateRoles
{

    public partial class AssociateRoleResourceIdentifier : IAssociateRoleResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public AssociateRoleResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("associate-role");
        }
    }
}
