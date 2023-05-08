using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.AssociateRoles
{

    public partial class AssociateRoleKeyReference : IAssociateRoleKeyReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Key { get; set; }
        public AssociateRoleKeyReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("associate-role");
        }
    }
}
