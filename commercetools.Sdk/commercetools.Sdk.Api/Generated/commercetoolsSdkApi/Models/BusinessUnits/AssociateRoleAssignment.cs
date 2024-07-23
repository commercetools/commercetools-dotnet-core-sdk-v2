using commercetools.Sdk.Api.Models.AssociateRoles;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class AssociateRoleAssignment : IAssociateRoleAssignment
    {
        public IAssociateRoleKeyReference AssociateRole { get; set; }

        public IAssociateRoleInheritanceMode Inheritance { get; set; }
    }
}
