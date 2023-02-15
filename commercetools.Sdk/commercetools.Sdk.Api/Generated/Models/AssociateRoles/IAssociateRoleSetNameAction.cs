using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.AssociateRoles
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleSetNameAction))]
    public partial interface IAssociateRoleSetNameAction : IAssociateRoleUpdateAction
    {
        string Name { get; set; }

    }
}
