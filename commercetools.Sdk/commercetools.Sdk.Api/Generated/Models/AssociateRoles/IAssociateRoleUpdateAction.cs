using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.AssociateRoles
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleUpdateAction))]
    [SubTypeDiscriminator("addPermission", typeof(commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleAddPermissionAction))]
    [SubTypeDiscriminator("changeBuyerAssignable", typeof(commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleChangeBuyerAssignableAction))]
    [SubTypeDiscriminator("removePermission", typeof(commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleRemovePermissionAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleSetCustomTypeAction))]
    [SubTypeDiscriminator("setName", typeof(commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleSetNameAction))]
    [SubTypeDiscriminator("setPermissions", typeof(commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleSetPermissionsAction))]
    public partial interface IAssociateRoleUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleAddPermissionAction AddPermission(Action<commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleAddPermissionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleAddPermissionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleChangeBuyerAssignableAction ChangeBuyerAssignable(Action<commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleChangeBuyerAssignableAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleChangeBuyerAssignableAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleRemovePermissionAction RemovePermission(Action<commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleRemovePermissionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleRemovePermissionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleSetCustomFieldAction SetCustomField(Action<commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleSetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleSetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleSetCustomTypeAction SetCustomType(Action<commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleSetCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleSetCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleSetNameAction SetName(Action<commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleSetNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleSetNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleSetPermissionsAction SetPermissions(Action<commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleSetPermissionsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleSetPermissionsAction();
            init?.Invoke(t);
            return t;
        }
    }
}
