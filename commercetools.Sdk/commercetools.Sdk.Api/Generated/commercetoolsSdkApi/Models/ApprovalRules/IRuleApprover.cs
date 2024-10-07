using commercetools.Sdk.Api.Models.AssociateRoles;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ApprovalRules
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ApprovalRules.RuleApprover))]
    public partial interface IRuleApprover
    {
        IAssociateRoleKeyReference AssociateRole { get; set; }

    }
}
