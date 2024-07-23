using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.AssociateRoles
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleResourceIdentifier))]
    public partial interface IAssociateRoleResourceIdentifier : IResourceIdentifier
    {
        new string Id { get; set; }

        new string Key { get; set; }

    }
}
