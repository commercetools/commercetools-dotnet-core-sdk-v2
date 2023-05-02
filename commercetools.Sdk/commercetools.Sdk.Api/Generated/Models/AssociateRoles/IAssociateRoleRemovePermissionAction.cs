using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.AssociateRoles
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleRemovePermissionAction))]
    public partial interface IAssociateRoleRemovePermissionAction : IAssociateRoleUpdateAction
    {
        IPermission Permission { get; set; }

    }
}
