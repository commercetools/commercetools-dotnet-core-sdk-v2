using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.AssociateRoleAssignment))]
    public partial interface IAssociateRoleAssignment
    {
        IAssociateRoleKeyReference AssociateRole { get; set; }

        IAssociateRoleInheritanceMode Inheritance { get; set; }

    }
}
