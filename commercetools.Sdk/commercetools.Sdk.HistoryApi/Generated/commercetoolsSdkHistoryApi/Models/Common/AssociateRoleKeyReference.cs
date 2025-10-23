

namespace commercetools.Sdk.HistoryApi.Models.Common
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
