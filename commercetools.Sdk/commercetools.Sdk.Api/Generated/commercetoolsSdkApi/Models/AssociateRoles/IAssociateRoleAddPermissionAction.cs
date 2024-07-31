using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.AssociateRoles
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleAddPermissionAction))]
    public partial interface IAssociateRoleAddPermissionAction : IAssociateRoleUpdateAction
    {
        IPermission Permission { get; set; }

    }
}
