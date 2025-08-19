

namespace commercetools.Sdk.ImportApi.Models.Common
{

    public partial class AssociateRoleKeyReference : IAssociateRoleKeyReference
    {
        public string Key { get; set; }

        public IReferenceType TypeId { get; set; }
        public AssociateRoleKeyReference()
        {
            this.TypeId = IReferenceType.FindEnum("associate-role");
        }
    }
}
