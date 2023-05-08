using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.AssociateRoles
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleKeyReference))]
    public partial interface IAssociateRoleKeyReference : IKeyReference
    {
        new string Key { get; set; }

    }
}
