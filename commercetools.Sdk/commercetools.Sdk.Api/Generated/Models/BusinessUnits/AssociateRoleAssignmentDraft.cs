using commercetools.Sdk.Api.Models.AssociateRoles;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class AssociateRoleAssignmentDraft : IAssociateRoleAssignmentDraft
    {
        public IAssociateRoleResourceIdentifier AssociateRole { get; set; }

        public IAssociateRoleInheritanceMode Inheritance { get; set; }
    }
}
