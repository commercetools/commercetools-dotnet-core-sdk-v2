using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.AssociateRoles
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleChangeBuyerAssignableAction))]
    public partial interface IAssociateRoleChangeBuyerAssignableAction : IAssociateRoleUpdateAction
    {
        bool BuyerAssignable { get; set; }

    }
}
