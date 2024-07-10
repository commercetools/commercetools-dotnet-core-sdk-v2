using commercetools.Sdk.Api.Models.AssociateRoles;


namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class BusinessUnitConfiguration : IBusinessUnitConfiguration
    {
        public IBusinessUnitConfigurationStatus MyBusinessUnitStatusOnCreation { get; set; }

        public IAssociateRoleKeyReference MyBusinessUnitAssociateRoleOnCreation { get; set; }
    }
}
