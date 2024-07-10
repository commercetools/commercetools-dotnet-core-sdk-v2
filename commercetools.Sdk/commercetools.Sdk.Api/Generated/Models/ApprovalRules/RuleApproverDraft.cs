using commercetools.Sdk.Api.Models.AssociateRoles;


namespace commercetools.Sdk.Api.Models.ApprovalRules
{

    public partial class RuleApproverDraft : IRuleApproverDraft
    {
        public IAssociateRoleResourceIdentifier AssociateRole { get; set; }
    }
}
