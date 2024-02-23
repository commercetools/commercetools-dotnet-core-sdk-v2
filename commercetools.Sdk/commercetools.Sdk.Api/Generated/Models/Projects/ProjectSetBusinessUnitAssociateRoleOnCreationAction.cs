using commercetools.Sdk.Api.Models.AssociateRoles;


namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class ProjectSetBusinessUnitAssociateRoleOnCreationAction : IProjectSetBusinessUnitAssociateRoleOnCreationAction
    {
        public string Action { get; set; }

        public IAssociateRoleResourceIdentifier AssociateRole { get; set; }
        public ProjectSetBusinessUnitAssociateRoleOnCreationAction()
        {
            this.Action = "setMyBusinessUnitAssociateRoleOnCreation";
        }
    }
}
