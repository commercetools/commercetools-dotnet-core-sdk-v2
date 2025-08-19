using commercetools.Sdk.ImportApi.Models.Common;


namespace commercetools.Sdk.ImportApi.Models.BusinessUnits
{

    public partial class AssociateRoleAssignmentDraft : IAssociateRoleAssignmentDraft
    {
        public IAssociateRoleKeyReference AssociateRole { get; set; }

        public IAssociateRoleInheritanceMode Inheritance { get; set; }
    }
}
