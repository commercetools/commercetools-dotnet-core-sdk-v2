using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.AssociateRoles
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleReference))]
    public partial interface IAssociateRoleReference : IReference
    {
        new IReferenceTypeId TypeId { get; set; }

        IAssociateRole Obj { get; set; }

        new string Id { get; set; }

    }
}
