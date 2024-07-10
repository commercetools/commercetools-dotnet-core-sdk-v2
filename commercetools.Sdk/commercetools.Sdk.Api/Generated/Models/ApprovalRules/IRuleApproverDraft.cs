using commercetools.Sdk.Api.Models.AssociateRoles;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ApprovalRules
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ApprovalRules.RuleApproverDraft))]
    public partial interface IRuleApproverDraft
    {
        IAssociateRoleResourceIdentifier AssociateRole { get; set; }

    }
}
