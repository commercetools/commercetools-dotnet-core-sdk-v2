using commercetools.Sdk.Api.Models.AssociateRoles;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ProjectSetBusinessUnitAssociateRoleOnCreationAction))]
    public partial interface IProjectSetBusinessUnitAssociateRoleOnCreationAction : IProjectUpdateAction
    {
        IAssociateRoleResourceIdentifier AssociateRole { get; set; }

    }
}
