using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.BusinessUnits.AssociateRoleAssignmentDraft))]
    public partial interface IAssociateRoleAssignmentDraft
    {
        IAssociateRoleKeyReference AssociateRole { get; set; }

        IAssociateRoleInheritanceMode Inheritance { get; set; }

    }
}
