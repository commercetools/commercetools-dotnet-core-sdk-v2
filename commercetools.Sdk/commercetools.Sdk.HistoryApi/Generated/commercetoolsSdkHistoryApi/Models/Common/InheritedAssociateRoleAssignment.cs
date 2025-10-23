

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class InheritedAssociateRoleAssignment : IInheritedAssociateRoleAssignment
    {
        public IAssociateRoleKeyReference AssociateRole { get; set; }

        public IBusinessUnitKeyReference Source { get; set; }
    }
}
