using commercetools.Sdk.Api.Models.AssociateRoles;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.BusinessUnitConfiguration))]
    public partial interface IBusinessUnitConfiguration
    {
        IBusinessUnitConfigurationStatus MyBusinessUnitStatusOnCreation { get; set; }

        IAssociateRoleKeyReference MyBusinessUnitAssociateRoleOnCreation { get; set; }

    }
}
