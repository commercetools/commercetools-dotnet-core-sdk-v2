using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.AssociateRoles
{

    public partial class AssociateRoleReference : IAssociateRoleReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IAssociateRole Obj { get; set; }
        public AssociateRoleReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("associate-role");
        }
    }
}
