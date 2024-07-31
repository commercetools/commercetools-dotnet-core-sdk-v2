using commercetools.Sdk.Api.Models.AssociateRoles;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.AssociateRoleAssignment))]
    public partial interface IAssociateRoleAssignment
    {
        IAssociateRoleKeyReference AssociateRole { get; set; }

        IAssociateRoleInheritanceMode Inheritance { get; set; }

    }
}
