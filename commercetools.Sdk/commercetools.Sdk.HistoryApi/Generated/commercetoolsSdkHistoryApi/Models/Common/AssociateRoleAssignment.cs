

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class AssociateRoleAssignment : IAssociateRoleAssignment
    {
        public IAssociateRoleKeyReference AssociateRole { get; set; }

        public IAssociateRoleInheritanceMode Inheritance { get; set; }
    }
}
